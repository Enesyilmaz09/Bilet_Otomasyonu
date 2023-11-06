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
    public partial class Form6 : Form
    {
        SqlConnection baglanti;
        public Form6()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server = WIN-97U941GM3L8\\SQLEXPRESS;Database=otomasyon3;Integrated Security = True");
            bilet_getir();
            
        }

        private void bilet_getir()
        {
            baglanti.Open();
            string sql = "select * from sefer_musteri";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvbilet.DataSource = dt;
            baglanti.Close();
        }

        private void dgvbilet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal ID = Convert.ToInt32(dgvbilet.Rows[e.RowIndex].Cells[0].Value);
            tbmusterino.Text = ID + "";
            tbadi.Text = dgvbilet.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbsoyadi.Text = dgvbilet.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbcinsiyet.Text = dgvbilet.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtel.Text = dgvbilet.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbsefer.Text = dgvbilet.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbkoltuk.Text = dgvbilet.Rows[e.RowIndex].Cells[6].Value.ToString();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbmusterino.Text != "" && tbadi.Text != "" && tbsoyadi.Text != "" && tbcinsiyet.Text != "" && tbtel.Text != "" && tbsefer.Text != "" && tbkoltuk.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update sefer_musteri set MusteriAdi = @MusteriAdi, MusteriSoyadi = @MusteriSoyadi, MusteriCinsiyeti = @MusteriCinsiyeti, MusteriTelNo = @MusteriTelNo, MusteriSeferi = @MusteriSeferi, KoltukNo = @KoltukNo where MusteriNo = @EMusteriNo", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@EMusteriNo", dgvbilet.Rows[dgvbilet.SelectedRows[0].Index].Cells[0].Value);
                cmd.Parameters.AddWithValue("@MusteriNo", tbmusterino.Text);
                cmd.Parameters.AddWithValue("@MusteriAdi", tbadi.Text);
                cmd.Parameters.AddWithValue("@MusteriSoyadi", tbsoyadi.Text);
                cmd.Parameters.AddWithValue("@MusteriCinsiyeti", tbcinsiyet.Text);
                cmd.Parameters.AddWithValue("@MusteriTelNo", tbtel.Text);
                cmd.Parameters.AddWithValue("@MusteriSeferi", tbsefer.Text);
                cmd.Parameters.AddWithValue("@KoltukNo", tbkoltuk.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bilet_getir();
                veri_temizle();
            }
            else
            {
                MessageBox.Show("Eksik bilgiler var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }                      
        }

        private void veri_temizle()
        {
            tbmusterino.Text = "";
            tbadi.Text = "";
            tbsoyadi.Text = "";
            tbcinsiyet.Text = "";
            tbtel.Text = "";
            tbsefer.Text = "";
            tbkoltuk.Text = "";
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from sefer_musteri where MusteriNo = @MusteriNo", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@MusteriNo", dgvbilet.Rows[dgvbilet.SelectedRows[0].Index].Cells[0].Value);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bilet_getir();
            veri_temizle();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            veri_temizle();
        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dgvbilet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
