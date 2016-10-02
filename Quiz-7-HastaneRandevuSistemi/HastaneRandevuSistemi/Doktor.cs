using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class Doktor:Personel
    {
        List<Hemsire> hemsireList;
        List<DateTime> calısmaList;

        public List<DateTime> CalısmaList
        {
            get { return calısmaList; }
            set { calısmaList = value; }
        }
        internal List<Hemsire> HemsireList
        {
            get { return hemsireList; }
            set { hemsireList = value; }
        }

        public override string Ad
        {
            get
            {
                return Ad;
            }
            set
            {
                Ad = value;
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
                Soyad = value;
            }
        }
        string bolum;

        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public Doktor()
        {
             hemsireList= new List<Hemsire>();
             CalısmaList = new List<DateTime>();
        }
        public override string ToString()
        {
            return "Ad: "+Ad+" Soyad: "+Soyad+" Bolum: "+Bolum;
        }
    }
}
