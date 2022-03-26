using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Yaşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanicilar[12]);
            foreach(var item in kullanicilar)
              Console.WriteLine(item);

            //Count 
            Console.WriteLine(kullanicilar.Count);
            //Contains 
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));
            //Remove 
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
               Console.WriteLine(item);
            
            //Keys 
            foreach(var item in kullanicilar.Keys)
              Console.WriteLine(item);
            //Values
            foreach(var item in kullanicilar.Values)
              Console.WriteLine(item);


             
        }
    }
}
