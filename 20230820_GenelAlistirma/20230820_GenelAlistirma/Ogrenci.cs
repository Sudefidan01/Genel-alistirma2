using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230820_GenelAlistirma
{
    internal class Ogrenci
    {
        public string Ad,Soyad;
        public int okulNo;
        public double N1, N2;

        public double ortalama
        {
            get { return (N1 + N2) / 2; }
        }
        public string tamAd
        {
            get { return Ad + " " + Soyad; }
        }
        public void Yazdir()
        {
            Console.WriteLine("Öğrencinin Adı ve Soyadı : "+tamAd);
            Console.WriteLine("Öğrencinin Sınav Notları : {0} , {1}",N1,N2);
            Console.WriteLine("Öğrencinin Not Ortalaması : "+ortalama);
            Console.WriteLine("------------------------\n");
        }
        public void Yazdir(int siraNo)
        {
            Console.WriteLine(siraNo+ "-"+tamAd );
        }

    }
}
