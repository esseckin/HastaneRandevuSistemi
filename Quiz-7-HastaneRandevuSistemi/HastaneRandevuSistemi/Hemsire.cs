using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class Hemsire : Personel
    {
        List<Doktor> doktorList;

        internal List<Doktor> DoktorList
        {
            get { return doktorList; }
            set { doktorList = value; }
        }

        string ad;
        public override string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        string soyad;

        public override string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        string bolum;

        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }

        public Hemsire()
        {
            DoktorList = new List<Doktor>();
        }
        public override string ToString()
        {
            return Ad;
        }
    }
}

