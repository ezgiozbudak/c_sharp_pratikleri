using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        { /*
           Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

           Negatif ve numeric olmayan girişleri engelleyin.
           Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
           Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
          
           ArrayList asalSayı = new ArrayList(); 
           ArrayList sayilar = new ArrayList();
           int sayi = 0;
           int toplam1 = 0;
           int toplam2 = 0;
           for (int i = 0; i < 20; i++)
           {
               Console.Write(i+1 +". sayı : ");
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
                   if( asalMı(sayi))
                   {
                    asalSayı.Add(sayi);
                    toplam1+=sayi;
                   }
                   else
                   {
                    sayilar.Add(sayi);
                    toplam2+=sayi;
                   }
                     
               }

           }
           Console.WriteLine("**** Asal Sayılar****");
           asalSayı.Sort();
           foreach (var item in asalSayı)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine("**** Asal Olmayan Sayılar****");
           sayilar.Sort();
           foreach (var item in sayilar)
           {
               Console.WriteLine(item);
           }

           int asalOrtalama = toplam1/asalSayı.Count;
           Console.WriteLine("Asal sayılar " + asalSayı.Count + " elemanlıdır ve ortalaması" + asalOrtalama );
           int Ortalama2 = toplam2/sayilar.Count;
           Console.WriteLine("Asal olmayan sayılar " + sayilar.Count + " elemanlıdır ve ortalaması" + Ortalama2 );


        }

        public static bool asalMı(int sayi )
        {
            int count=0;
            int i = 2;
            while (i < sayi)
            {
               if (sayi % i == 0)
               count++;
               i++;
            }

            if (count != 0)
                return false;
            else
                return true;

        }

      
        
    }
}
