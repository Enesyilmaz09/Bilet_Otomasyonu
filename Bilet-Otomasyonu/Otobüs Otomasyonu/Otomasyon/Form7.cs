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
    public partial class Form7 : Form
    {
        SqlConnection baglanti;
        public Form7()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server = WIN-97U941GM3L8\\SQLEXPRESS;Database=otomasyon3;Integrated Security = True");
            sefer_getir();
        }

        private void sefer_getir()
        {
            baglanti.Open();
            string sql = "SELECT top 1 * FROM Sefer_Musteri order by MusteriNo desc ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv1.DataSource = dt;
            baglanti.Close();
        }


        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
