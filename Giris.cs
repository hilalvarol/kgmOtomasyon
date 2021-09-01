using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGM_Personal
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelUygulamaEkleme personelUygulamaEkleme = new PersonelUygulamaEkleme();
            personelUygulamaEkleme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelGoruntule personelGoruntule = new PersonelGoruntule();
            personelGoruntule.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelUygulamaArama personelUygulamaArama = new PersonelUygulamaArama();
            personelUygulamaArama.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelUygulamaGüncelleme personelUygulamaGüncelleme = new PersonelUygulamaGüncelleme();
            personelUygulamaGüncelleme.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelUygulamaSilme personelUygulamaSilme = new PersonelUygulamaSilme();
            personelUygulamaSilme.Show();
        }
    }
}
