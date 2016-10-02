using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
   abstract class Personel
    {
        string ad;

        public abstract string Ad
        {
            get;
            set;
        }
        string soyad;

        public abstract string Soyad
        {
            get;
            set;
        }
    }
}
