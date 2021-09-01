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
    public partial class PersonelUygulamaGüncelleme : Form
    {
        public PersonelUygulamaGüncelleme()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-62042VMP;Initial Catalog=KGM_Personal_List;Integrated Security=True");
        DataTable tablo1 = new DataTable(); //geçici bir tablo oluşturduk
        DataTable tablo2 = new DataTable(); //geçici bir tablo oluşturduk

        private void PersonelUygulamaGüncelleme_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Table_Personal_Listesi where Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                textBox1.Text = dr["Id"].ToString();
                textBox2.Text = dr["Ad"].ToString();
                textBox3.Text = dr["Soyad"].ToString();
                textBox4.Text = dr["Departman"].ToString();
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Personel bulunamadı.");
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Table_Personal_Listesi set  Ad=@Ad, Soyad=@Soyad, Departman=@Departman where Id=@Id", baglanti); //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Departman", textBox4.Text); //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Table_Uygulamalar where Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id", textBox5.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                textBox5.Text = dr["Id"].ToString();
                textBox7.Text = dr["Uygulama_ad"].ToString();
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Uygulama bulunamadı.");
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Table_Uygulamalar set  Uygulama_ad=@Uygulama_ad where Id=@Id", baglanti); //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.

            komut.Parameters.AddWithValue("@Id", textBox5.Text);
            komut.Parameters.AddWithValue("@Uygulama_ad", textBox7.Text);
            komut.ExecuteNonQuery();  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Uygulama bilgileri güncellendi.");
        }
    }
}
