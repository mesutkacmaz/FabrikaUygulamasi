using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaIsciKimlik
{
    public class Fabrika
    {
        public string Ad { get; set; }
        public string Adress { get; set; }
        public List<Personel> Personeller { get; set; }
        public void PersonelEkle(Personel per)
        {
            Personeller.Add(per);
        }

        public string PersonelListele()
        {
            string deger="";
            foreach (Personel per in Personeller)
            {
                deger += "Personel No: " + per.PersonelNo + "Ad: " + per.Kimlik.Ad + "Soyad: " + per.Kimlik.Soyad + "Birim: " + per.Birim;
            }
            return deger;
        }
    }    
    
}
