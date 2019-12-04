using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaIsciKimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fabrika fabrika = new Fabrika();

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            fabrika.Ad = "Seyrek Fabrikası";
            int no = Convert.ToInt32(txtPersonelNo.Text);
            Personel personel = new Personel(no);
            personel.Kimlik.Ad = txtAd.Text;
            personel.Kimlik.Soyad = txtSoyad.Text;
            personel.Birim = txtBirim.Text;

            fabrika.Personeller = new List<Personel>();

            fabrika.PersonelEkle(personel);
            MessageBox.Show("Personel eklendi.");
        }

        private void BtnPersonelListele_Click(object sender, EventArgs e)
        {
            txtListele.Text = fabrika.PersonelListele();
        }
    }
}
