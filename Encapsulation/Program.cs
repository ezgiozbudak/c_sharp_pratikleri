using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim ="Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo1 = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int OgrenciNo;
        private int sinif;

        public string Isim { 
            get {return isim;}
            set {isim = value;}
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo1 { get => OgrenciNo; set => OgrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set{
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif=1;
                }
                else
                {
                    sinif= value;
                }
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo1, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo1 = ogrenciNo1;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****");
            Console.WriteLine("Öğrenci Adı    :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı    :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No   :{0}",this.OgrenciNo1);
            Console.WriteLine("Öğrenci Sınıfı    :{0}",this.sinif);


        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1 ;
        }
        
         public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1 ;
        }
    }
}
