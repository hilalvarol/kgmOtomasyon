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
    public partial class PersonelUygulamaEkleme : Form
    {
        public PersonelUygulamaEkleme()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True");
        DataTable tablo1 = new DataTable(); //geçici bir tablo oluşturduk
        DataTable tablo2 = new DataTable(); //geçici bir tablo oluşturduk

        private void PersonelUygulamaEkleme_Load(object sender, EventArgs e)
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Personal_Listesi (Ad,Soyad,Departman) values (@Ad,@Soyad,@Departman)", baglanti);  //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Departman", textBox4.Text); //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery(); //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Personel Kayıt İşlemi Başarılı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Uygulamalar (Uygulama_ad) values (@Uygulama_ad)", baglanti);  //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@Uygulama_ad", textBox7.Text); //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery(); //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Personel Kayıt İşlemi Başarılı.");

           
        }
    }
}
