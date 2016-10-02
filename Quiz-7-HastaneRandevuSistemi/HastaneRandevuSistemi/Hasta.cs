using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class Hasta
    {
        List<Hasta> randevuList;

        internal List<Hasta> RandevuList
        {
            get { return randevuList; }
            set { randevuList = value; }
        }
        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        string tc;

        public string Tc
        {
            get { return tc; }
            set { tc = value; }
        }
        string telNo;

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public Hasta()
        {
            randevuList = new List<Hasta>();
        }
        public override string ToString()
        {
            return "Ad: " + Ad + " Soyad: " + Soyad+" Tc: "+Tc+" TelNo: "+telNo+" Mail: "+Mail;
        }

        



    }
}
