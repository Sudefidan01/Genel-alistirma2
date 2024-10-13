using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230820_GenelAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Program Ne Yapacak
            //Öğrenci Kayıt Programı
            //1-Öğrenci Ekle
            //2-Öğrenci Sil
            //3-Öğrenci Listele
            //4-Öğrenci Ara
            //5-Toplam Öğrenci Sayısı
            //6-Öğrencilerin Genel Not Ortalaması
            //0-Programdan Çıkış
            #endregion
            ConsoleKey cevap;

            do
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Kayıt Programı");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1-Öğrenci Ekle");
                Console.WriteLine("2-Öğrencileri Sil");
                Console.WriteLine("3-Öğrencileri Listele");
                Console.WriteLine("4-Öğrenci Ara");
                Console.WriteLine("5-Toplam Öğrenci Sayısı");
                Console.WriteLine("6-Öğrencilerin Genel Not Ortalaması");
                Console.WriteLine("0-Programdan Çık");
                cevap =Console.ReadKey().Key;

                Menu.Islemler(cevap);
                
            } while (cevap != ConsoleKey.D0 && cevap!=ConsoleKey.NumPad0 );

            Console.Clear();
            Console.WriteLine("Programı Kullandığınız için Teşekkür Ederiz");
            Console.WriteLine("Kapatmak İçin Herhangi bir Tuşa Basınız");
            Console.ReadKey();
        }
    }
}
