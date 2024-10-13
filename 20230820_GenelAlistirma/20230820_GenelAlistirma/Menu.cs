using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20230820_GenelAlistirma
{
    internal static class Menu
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static void Islemler(ConsoleKey secim)
        {
            switch (secim)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    OgrenciEkle("Öğrenci Ekleme Sayfası");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    OgrenciSil("Öğrenci Silme Sayfası");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    OgrenciListele("Kayıtlı Öğrencilerin Listesi");
                    break;
                 case ConsoleKey.D4: case ConsoleKey.NumPad4:
                    OgrenciAra("Kayıtlı Öğrenci Arama Sayfası");
                    break;
                case ConsoleKey.D5: case ConsoleKey.NumPad5:
                    ToplamOgrenci("Toplam Öğrenci Sayısı");
                    break;
                case ConsoleKey.D6: case ConsoleKey.NumPad6:
                    GenelNotOrtalamasi("Öğrencilerin Genel Not Ortalaması");
                    break;
                default:
                    break;
            }
        }

        private static void BaslikYazdir(string metin)
        {
            Console.Clear();
            Console.WriteLine(metin);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }
        private static void AnaMenuyeDon(string metin)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(metin);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
            Console.ReadKey();
        }

        // ------------- İşlem Yapma Metodları ------------------------
        private static void OgrenciEkle(string metin)
        {
              BaslikYazdir(metin);
            Ogrenci o = new Ogrenci();
            o.Ad=Metodlar.GetString("Öğrencinin Adını Giriniz : ");
            o.Soyad = Metodlar.GetString("Öğrencinin Soyadını Giriniz : ");
            o.okulNo = Metodlar.GetInt("Öğrencinin Numarasını Giriniz : ",1,9999);
            o.N1 = Metodlar.GetDouble("Öğrencinin 1.Sınav Notunu Giriniz :",1,100);
            o.N2 = Metodlar.GetDouble("Öğrencinin 2.Sınav Notunu Giriniz : ", 1, 100);
            ogrenciler.Add(o);
            AnaMenuyeDon("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleşti");


        }

        private static void OgrenciSil(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Count>0)
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i+1);
                }
                int siraNo = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz :",1,ogrenciler.Count);
                ogrenciler.RemoveAt(siraNo - 1);
                AnaMenuyeDon("Silme İşlemi Başarılı Bir Şekilde Gerçekleşmiştir");
            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunamadı");
            }
        }

        private static void OgrenciListele(string metin)
        {
            BaslikYazdir(metin);
            //Koleksiyon içerisinde bulunan Any() metodu , koleksiyon içerisinde bir öğre var mı yok mu sorgulaması yapar.Geriye bool veritipinde bir değer döndürür.var ise "true " yok ise "false" değer döner
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir();

                }
                AnaMenuyeDon(string.Format("Toplam {0} adet öğrenci listelenmiştir",ogrenciler.Count));
            }
            else 
            {
                AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı");
            }
        }
        private static void OgrenciAra(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                string aranacakOgrenci = Metodlar.GetString("Aranacak öğrencinin adını veya soyadını giriniz : ");
                int adet = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    if (ogrenci.tamAd.ToLower().Contains(aranacakOgrenci.ToLower()))
                    {
                        adet++;
                        ogrenci.Yazdir(adet);
                    }
                }

                AnaMenuyeDon(string.Format("{0} kelimesine karşılık {1} tane öğrenci bulunmuştur", aranacakOgrenci, adet));

            }
            else
            {
                AnaMenuyeDon("Listede Aranacak Kayıtlı Öğrenci Bulunamadı");
            }
        }
        private static void ToplamOgrenci(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any()) 
            {
                AnaMenuyeDon(string.Format("Listede {0} kayıtlı öğrenci vardır",ogrenciler.Count));
            }
            else { AnaMenuyeDon("Kayıtlı Öğrenci Bulunamadı"); }
        }
        private static void GenelNotOrtalamasi(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                double genelOrt = 0;
                foreach (var item in ogrenciler)
                {
                    genelOrt += item.ortalama;
                }
                double sonuc = genelOrt / ogrenciler.Count;
                AnaMenuyeDon(string.Format("{0} adet öğrencinin genel not ortalaması = {1}", ogrenciler.Count, sonuc));
            }
            else
            {
                AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı");
            }
        }

    }
}
