﻿using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
           int month = DateTime.Now.Month;

           //Expression
           switch (month)
           {
               case 1:
                   Console.WriteLine("Ocak ayındasındır");
                   break;
                case 2:
                   Console.WriteLine("Şubat ayındasındır");
                   break;
                case 3:
                   Console.WriteLine("Mart ayındasındır");
                   break;
                case 4:
                   Console.WriteLine("Nisan ayındasındır");
                   break;
               default:
                   Console.WriteLine("Yanlış veri girişi");                
               break;
           }

           switch (month)
           {
               case 12:
               case 1 :
               case 2 :
                    Console.WriteLine("Kış ayındasındır");
                    break;
                
               case 3:
               case 4:
               case 5:
                    Console.WriteLine("İlkbahar ayındasındır");
                    break;
               case 6:
               case 7:
               case 8:
                    Console.WriteLine("Yaz ayındasındır");
                    break;
               case 9:
               case 10:
               case 11:
                    Console.WriteLine("Sonbahar ayındasındır");
                    break;


               default:
               break;
           }
        }
    }
}
