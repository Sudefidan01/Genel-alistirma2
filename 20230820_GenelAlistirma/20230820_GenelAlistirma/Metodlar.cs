using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230820_GenelAlistirma
{
    internal static class Metodlar
    {
        public static string GetString(string metin)
        {
            string text=string.Empty;
            bool hata = true;

            do
            {
                Console.Write(metin);
                text=Console.ReadLine();
                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Boş Bırakılamaz");
                    hata = true;
                }
                else
                {
                    hata = false;
                }


            } while (hata);
            return text;

        }
        public static int GetInt(string metin,int min=int.MinValue,int max=int.MaxValue)
        {
            int sayi = 0;
            bool hata = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi>=min && sayi<=max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Girilen sayı {0} ile {1} aralığında olmalı",min,max);
                        hata = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    hata = true;
                   
                }

            } while (hata);
            return sayi;

        }
        public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Girilen sayı {0} ile {1} aralığında olmalı", min, max);
                        hata = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    hata = true;

                }

            } while (hata);
            return sayi;

        }
    }
}
