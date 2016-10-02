using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    class Menuler
    {
        public static int secim;
        public static int hata = 0;

        public static void Menu()
        {
            Console.WriteLine("1-DataGirisi\n2-Calısanlarımız\n3-Randevu Al\n4-Kaydol\n5-Cikis\nLütfen Secim yapınız..:");
            secim = int.Parse(Console.ReadLine());

            do
            {
                hata = 0;
                switch (secim)
                {
                    case 1: Console.WriteLine("----DataGirişi----");
                        DataGirisi();
                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("yanlıs secim yaptınız");
                        hata++;
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                        System.Threading.Thread.Sleep(200);
                        Menu();
                        break;
                }

            } while (hata != 0);

        }

        public static void DataGirisi()
        {
            Console.WriteLine("****Calısanlar****\n1-Doktor\n2-Hemşire\n3-Hizmetli\n4.Cikis\nLutfen seciniz..:");
            secim = int.Parse(Console.ReadLine());

            do
            {
                hata = 0;
                switch (secim)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: Environment.Exit(0);break;
                   
                    default: Console.WriteLine("yanlıs secim yaptınız");
                        hata++;
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Menu();
                        break;
                }

            } while (hata != 0);
        }
    }
}
