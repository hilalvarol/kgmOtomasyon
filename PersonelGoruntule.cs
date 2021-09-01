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
    public partial class PersonelGoruntule : Form
    {
        public PersonelGoruntule()
        {
            InitializeComponent();
        }

        //Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True");
        DataTable tablo1 = new DataTable(); //geçici bir tablo oluşturduk
        DataTable tablo2 = new DataTable(); //geçici bir tablo oluşturduk

        private void PersonelGoruntule_Load(object sender, EventArgs e)
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
    }
}
