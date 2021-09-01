using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGM_Personal
{
    public partial class PersonelUygulamaArama : Form
    {
        public PersonelUygulamaArama()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True");
        DataTable tablo1 = new DataTable(); //geçici bir tablo oluşturduk
        DataTable tablo2 = new DataTable(); //geçici bir tablo oluşturduk

        private void PersonelUygulamaArama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter d1 = new SqlDataAdapter("Select * From Table_Personal_Listesi", baglanti);
            SqlDataAdapter d2 = new SqlDataAdapter("Select * From Table_Uygulamalar", baglanti);
            d1.Fill(tablo1);
            d2.Fill(tablo2);
            dataGridView1.DataSource = tablo1;
            dataGridView2.DataSource = tablo2;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo1.Clear();
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Table_Personal_Listesi where Ad like '%" + textBox1.Text + "%'", baglanti); //isimden arama yapmak
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Table_Personal_Listesi where Soyad like '%" + textBox1.Text + "%'", baglanti); // soyaddan arama yapmak
            da1.Fill(tablo1);
            da2.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablo2.Clear();
            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Table_Uygulamalar where Uygulama_ad like '%" + textBox2.Text + "%'", baglanti); //uygulama adından arama yapmak
            da2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
    }
}
