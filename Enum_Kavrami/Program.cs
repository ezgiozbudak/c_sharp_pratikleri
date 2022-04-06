using System;

namespace Enum_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi );
            
            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");
            else if(sıcaklık >= (int)HavaDurumu.Sıcak) 
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık <(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi Dışarı çıkalım");
       
        } 
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma =23,
        Cumartesi,
        Pazar

    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSicak = 30

    }

}
