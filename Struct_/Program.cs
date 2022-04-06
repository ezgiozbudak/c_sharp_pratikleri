using System;

namespace Struct_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            // dikdortgen.KısaKenar = 3;
            // dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen.AlanHesapla());
             
            Dikdörtgen_Struct dstruct = new Dikdörtgen_Struct(3,4);
            // dstruct.KısaKenar= 3;
            // dstruct.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}",dstruct.AlanHesapla());
        
        }
    }

    class Dikdortgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KısaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar* this.UzunKenar;
        }
    }

    struct Dikdörtgen_Struct
    {
       public int KısaKenar;
        public int UzunKenar;

        public Dikdörtgen_Struct (int kisakenar,int uzunKenar)
        {
            KısaKenar = 3;
            UzunKenar = 4;
            KısaKenar = kisakenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar* this.UzunKenar;
        }

    }
}
