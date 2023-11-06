using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otomasyon
{
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        public Form5()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server = WIN-97U941GM3L8\\SQLEXPRESS;Database=otomasyon3;Integrated Security = True");
            sefer_getir();
        }

        private void sefer_getir()
        {
            baglanti.Open();
            string sql = "select * from Seferler";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSeferler2.DataSource = dt;
            baglanti.Close();
        }
            
        private void dgvSeferler2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal ID = Convert.ToInt32(dgvSeferler2.Rows[e.RowIndex].Cells[0].Value);
            tbSeferNo.Text = ID + "";
            tbSeferAdi.Text = dgvSeferler2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbSeferTarihi.Text = dgvSeferler2.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbSeferSaati.Text = dgvSeferler2.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbOtobusAdi.Text = dgvSeferler2.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbPeronNo.Text = dgvSeferler2.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbSeferUcreti.Text = dgvSeferler2.Rows[e.RowIndex].Cells[6].Value.ToString();
            //seçilen seferadına göre otobus koltuk sayısı ayarlama
            baglanti.Open();

            DataRow[] seferSatirlari = null;
            DataTable seferTablosu = dgvSeferler2.DataSource as DataTable;

            if (seferTablosu != null)
            {
                // Seçilen satırdan "SeferAdi" değerini al
                string secilenSeferAdi = dgvSeferler2.Rows[e.RowIndex].Cells["SeferAdi"].Value.ToString();

                // Seferler tablosundan seçilen sefer adına karşılık gelen satırları bul
                seferSatirlari = seferTablosu.Select("SeferAdi = '" + secilenSeferAdi + "'");
            }

            // Otobusler tablosundan verileri al
            string sql = "SELECT OtobusAdi, KoltukAdedi FROM Otobusler";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable otobuslerTable = new DataTable();
            da.Fill(otobuslerTable);

            // ComboBox'taki önceki değerleri temizle
            tbKoltukNo.Items.Clear();

            if (seferSatirlari != null && seferSatirlari.Length > 0)
            {
                // Seçilen otobus adını bul
                string secilenOtobusAdi = seferSatirlari[0]["OtobusAdi"].ToString();

                // Otobusler tablosunda seçilen otobus adına karşılık gelen koltuk adedini bul
                DataRow[] otobusSatirlari = otobuslerTable.Select("OtobusAdi = '" + secilenOtobusAdi + "'");
                if (otobusSatirlari.Length > 0)
                {
                    int koltukAdedi = Convert.ToInt32(otobusSatirlari[0]["KoltukAdedi"]);

                    // Koltuk numaralarını ComboBox'a ekle
                    for (int i = 1; i <= koltukAdedi; i++)
                    {
                        tbKoltukNo.Items.Add(i);
                    }
                }
            }

            baglanti.Close();
        }

        private void btRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (tbKoltukNo.Text == "")
            {
                MessageBox.Show("Lütfen bir koltuk numarası seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tbMusteriAdi.Text != "" && tbMusteriSoyadi.Text != "" && tbMusteriTelNo.Text != "" && (rbErkek.Checked != true || rbKadın.Checked != true))
            {
                // Öncelikle belirli bir koltuk numarası için kayıt var mı diye kontrol edelim
                string koltukNo = tbKoltukNo.Text;
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Sefer_Musteri WHERE MusteriSeferi = @MusteriSeferi AND KoltukNo = @KoltukNo", baglanti);
                checkCmd.Parameters.AddWithValue("@MusteriSeferi", tbSeferNo.Text);
                checkCmd.Parameters.AddWithValue("@KoltukNo", koltukNo);
                baglanti.Open();
                int koltukSayisi = (int)checkCmd.ExecuteScalar();
                baglanti.Close();

                if (koltukSayisi == 0)
                {
                    // Koltuk boş ise rezervasyonu yapabiliriz
                    SqlCommand cmd = new SqlCommand("INSERT INTO Sefer_Musteri(MusteriAdi, MusteriSoyadi, MusteriCinsiyeti, MusteriTelNo, MusteriSeferi, KoltukNo) VALUES(@MusteriAdi, @MusteriSoyadi, @MusteriCinsiyeti, @MusteriTelNo, @MusteriSeferi, @KoltukNo)", baglanti);
                    baglanti.Open();

                    cmd.Parameters.AddWithValue("@MusteriAdi", tbMusteriAdi.Text);
                    cmd.Parameters.AddWithValue("@MusteriSoyadi", tbMusteriSoyadi.Text);

                    if (rbErkek.Checked == true)
                        cmd.Parameters.AddWithValue("@MusteriCinsiyeti", rbErkek.Text);
                    else
                        cmd.Parameters.AddWithValue("@MusteriCinsiyeti", rbKadın.Text);

                    cmd.Parameters.AddWithValue("@MusteriTelNo", tbMusteriTelNo.Text);
                    cmd.Parameters.AddWithValue("@MusteriSeferi", tbSeferNo.Text);
                    cmd.Parameters.AddWithValue("@KoltukNo", koltukNo);

                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarıyla eklendi. Biletinize ulaşmak için Tamam'a basın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form7 frm7 = new Form7();
                    frm7.Show();
                }
                else
                {
                    MessageBox.Show("Seçilen koltuk zaten dolu. Lütfen başka bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Eksik ya da hatalı giriş yaptınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void tbKoltukNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
