using System;
using System.Collections.Generic;

namespace AlgoritmaSorulari
{
     class Program
    {
        static void Main(string[] args)
        {
           /*1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
            
            int sayi = SayiGir();
            Console.WriteLine( sayi + " adet sayi giriniz");
            int[] dizi = new int[sayi];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write( i+1+ " . sayi :");
                int deger = int.Parse(Console.ReadLine());
                dizi[i] = deger;
            }
            Console.WriteLine("Çift Sayılar : ");
            ciftSayilar(dizi);*/
            
           /* 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
           Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
           Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
           int n = SayiGir();
           int m = SayiGir();
           Console.WriteLine( n + " adet sayi giriniz");
           int[] dizi2 = new int[n];
           for (int i = 0; i < dizi2.Length; i++)
           {
                Console.Write( i+1+ " . sayi :");
                int deger = int.Parse(Console.ReadLine());
                dizi2[i] = deger;
           }
           Console.WriteLine("m'e eşit ya da tam bölünen sayılar :");
           Sayilar(dizi2,m); */

          /* 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
          Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
          Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. 

          int n = SayiGir();
          Console.WriteLine( n + " adet kelime giriniz");
          string[] dizi3 = new string[n];
          for (int i = 0; i < dizi3.Length; i++)
          {
            Console.Write( i+1+ " . kelime :");
            string kelime = Console.ReadLine();
            dizi3[i] = kelime;
          }
          Array.Reverse(dizi3);
          Kelimeler(dizi3); */

          /* 4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
          Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
          Console.WriteLine("Bir cümle giriniz.");
          string cumle = Console.ReadLine();
          string[] kelime = cumle.Split(" ");
          Console.WriteLine(kelime.Length +"adet kelime vardır.");
          int harfSayisi = 0;
          for (int i = 0; i < kelime.Length; i++)
          {
            harfSayisi += kelime[i].Length;
          }
          Console.WriteLine("Bu cümlede {0} adet harf vardır.",harfSayisi);

        }

        public static int SayiGir()
        {
          Console.Write("Pozitif bir sayı giriniz: ");
          int sayi = Int32.Parse(Console.ReadLine());
          return sayi;
        
        }
    
        public static void ciftSayilar(int[] a)
        {
            foreach(var item in a)
            {
                if (item % 2 == 0)
                {
                   Console.Write(item +" ");
                }
            }

        }

         public static void Sayilar(int[] a , int m)
        {
            foreach(var item in a)
            {
                if (item % m == 0 || item == m)
                {
                   Console.Write(item +" ");
                }
            }

        }

        public static void Kelimeler(string[] a )
        {
            foreach(var item in a)
            {
                Console.Write(item +" ");
              
            }

        }

      
   
    }

}


