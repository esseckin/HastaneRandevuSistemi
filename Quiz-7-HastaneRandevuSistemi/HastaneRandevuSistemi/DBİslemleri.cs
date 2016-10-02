using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class DBİslemleri
    {
        static List<Hasta> hastaListesi;
        static List<Hemsire> hemsireListesi;
        static List<Doktor> doktorListesi;
        static List<Hizmetli> hizmetliListesi;
        static DBİslemleri()
        {
            hastaListesi = new List<Hasta>();
            hemsireListesi = new List<Hemsire>();
            doktorListesi = new List<Doktor>();
            hizmetliListesi = new List<Hizmetli>();
        }

        public static void HastaListele()
        {
            foreach (var item in hastaListesi)
            {
                Console.WriteLine(item);
            }
        }
        public static void DoktorListele()
        {
            foreach (var item in doktorListesi)
            {
                Console.WriteLine(item);
            }
        }
        public static void HizmetliListele()
        {
            foreach (var item in hizmetliListesi)
            {
                Console.WriteLine(item);
            }
        }
        public static void HemsireEkle()
        {
            Hemsire hemsire = null;
            string[] hemsiredizisi;

            String oku = "";
            string path = @".\Data\Hemsire.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                do
                {
                    oku = sr.ReadLine();
                    if (oku != null)
                    {
                        hemsire = new Hemsire();
                        hemsiredizisi = new string[2];
                        hemsiredizisi = oku.Split(',');

                        hemsire.Ad = hemsiredizisi[0];
                        hemsire.Soyad = hemsiredizisi[1];
                        hemsire.Bolum = hemsiredizisi[2];

                        hemsireListesi.Add(hemsire);
                    }


                } while (oku != null);
            }
            foreach (var item in hemsireListesi)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void DoktorEkle()
        {
            Doktor doktor = null;
            string[] doktordizisi;
            string[] saatdizisi;
            string oku = " ";
            string path = @".\Data\Doktorlar.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                while (oku != null)
                {
                    oku = sr.ReadLine();
                    doktor = new Doktor();
                    doktordizisi = new string[oku.Split(',').Length];
                    saatdizisi = new string[17];
                    doktordizisi = oku.Split(',');

                    for (int i = 0; i < doktordizisi.Length; i++)
                    {
                        doktor.Ad = doktordizisi[i];
                        doktor.Soyad = doktordizisi[i + 1];
                        doktor.Bolum = doktordizisi[i + 2];
                        saatdizisi = doktordizisi[i + 3].Split(';');
                        for (int j = 0; j < saatdizisi.Length; j++)
                        {
                            doktor.CalısmaList.Add(Convert.ToDateTime(saatdizisi[i]));
                        }
                    }
                    doktorListesi.Add(doktor);
                }
            }
        }
        public static void UyeEkle(Hasta hasta)
        {
            hastaListesi.Add(hasta);
            string path = @".\Data\Uyeler.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < hastaListesi.Count; i++)
                {
                    sw.Write(hastaListesi[i].ToString());
                }
            }

        }

    }
}
