using System;
using System.Collections;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            ve dizinin elemanlarını sıralayan programı yazınız.*/

            Console.WriteLine("Bir cümle girinziz:");
            string[] cumle = Console.ReadLine().Split(' ');
            string[] sesliler = {"a","e","ı","i","o","ö","ü","u"};
            ArrayList cumleSesliHarf = new ArrayList();
        
            for(int i = 0; i < cumle.Length; i++)
            {
                foreach (var item in sesliler)
                {
                    if(cumle[i].Contains(item))
                    {
                        cumleSesliHarf.Add(item);
                    }
                }  
            }
            
            Console.WriteLine("Cümledeki sesli harfler :");
            foreach (var item in cumleSesliHarf)
            {
                Console.WriteLine(item);
            }
        }
    }
}
