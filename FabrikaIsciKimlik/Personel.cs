using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaIsciKimlik
{
    public class Personel
    {
        public int PersonelNo { get; private set; }
        public string Birim { get; set; }
        public KimlikBilgileri Kimlik { get; set; }

        public Personel(int perNo)
        {
            this.Kimlik = new KimlikBilgileri();
            this.PersonelNo = perNo;
        }
    }
}
