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
using System.Collections.Specialized;
using System.Configuration;



namespace Otomasyon
{
    
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server = WIN-97U941GM3L8\\SQLEXPRESS;Database=otomasyon3;Integrated Security = True");
        }


        private void tbParola_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btGiris_Click(this, new EventArgs());
            }
        }

        private void btGiris_Click(Form1 giris, EventArgs eventArgs)
        {
            
        }

        private void btGiris_Click(object sender, EventArgs e)
        {
            string kadi = tbKAdi.Text;
            string parola = tbParola.Text;
            baglanti.Open();
            string sql = "select * from Yoneticiler where YoneticiAdi = @YoneticiAdi and YoneticiParola = @YoneticiParola";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(new SqlParameter("@YoneticiAdi", kadi));
            komut.Parameters.Add(new SqlParameter("@YoneticiParola", parola));

            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbKAdi.Clear();
                tbParola.Clear();
            }

            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
