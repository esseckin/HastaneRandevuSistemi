using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class Hizmetli:Personel
    {
        public override string Ad
        {
            get
            {
                return Ad;
            }
            set
            {
                Ad=value;
            }
        }

        public override string Soyad
        {
            get
            {
                return Soyad;
            }
            set
            {
                Soyad=value;
            }
        }
    }
}
