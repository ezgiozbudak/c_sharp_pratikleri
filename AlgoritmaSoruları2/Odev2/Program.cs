using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun 
            kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı 
            yazınız. (Array sınıfını kullanarak yazınız.)*/
            int[] sayilar = new int[20];
            ArrayList buyukList = new ArrayList();
            List<int> kucukList = new List<int>();
            int sayi = 0; 
            for (int i = 0; i < 20; i++)
           {
               Console.Write(i+". sayı : ");
               try 
               {
                sayi = Int32.Parse(Console.ReadLine());
               }
               catch 
               {
                Console.WriteLine("Girdiğiniz değer sayı değil.Lütfen sayı giriniz!");
                i--;
                  
               }

               if(sayi<=0) 
               {
                Console.WriteLine("Pozitif sayı giriniz!");
                i--;
               }
               else
               {
                  sayilar[i] = sayi;
                     
               }

           }
           Array.Sort(sayilar);
           int toplam2=0;
            for (int i = 0; i<3; i++)
           {
               kucukList.Add(sayilar[i]);
               toplam2 += sayilar[i];
           }
           
           Array.Reverse(sayilar);
           int toplam1 =0;
           for (int i = 0; i<3; i++)
           {
               buyukList.Add(sayilar[i]);
               toplam1 += sayilar[i];
           }
           
           Console.WriteLine("*******");

           foreach (var item in buyukList)
           {
               Console.WriteLine(item);
           }
           foreach (var item in kucukList)
           {
               Console.WriteLine(item);
           }

           int OrtBuyuk = Ort(toplam1,buyukList.Count);
           Console.WriteLine("Büyük sayıların ortalaması : " + OrtBuyuk);
           int OrtKucuk = Ort(toplam2,kucukList.Count);
           Console.WriteLine("Küçük sayıların ortalaması : " + OrtKucuk);
           Console.WriteLine("Ortalamalar toplamı : " + (OrtKucuk+OrtBuyuk));

            

        }

        public static int Ort(int sayi, int sayi2)
        {
            
            int ortalama = sayi/sayi2;
            return ortalama;
        }


    }

}
