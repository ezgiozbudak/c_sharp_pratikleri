using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
              Console.WriteLine(sayi);
            foreach(var renk in renkListesi)
              Console.WriteLine(renk);
            

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde arama 
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu!");
            }

            //Eleman ile index'e erişme 
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //diziyi list'e'çevirme 
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanListedi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListedi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı = new Kullanıcılar();
            kullanıcı.Isim="Ayşe";
            kullanıcı.Soyisim="Yılmaz";
            kullanıcı.Yas=26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim="Çalışkan";
            kullanıcı2.Yas=26;

            kullaniciListesi.Add(kullanıcı);
            kullaniciListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar() {
                Isim="Deniz",
                Soyisim="Arca",
                Yas=24 
            });

            foreach (var kullanicilar in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanicilar.Isim);
                Console.WriteLine("Kullanıcı Soyadı" + kullanicilar.Soyisim);
                Console.WriteLine("Kullanıcı Yas:" + kullanicilar.Yas);
            }

            yeniListe.Clear();


            
             
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim {get=> isim; set=> isim = value;}
        public string Soyisim {get=> soyisim; set=> soyisim = value;}
        public int Yas {get=> yas; set=> yas = value;}
 



    }
}
