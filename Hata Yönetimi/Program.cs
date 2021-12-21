using System;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //try 
            //{
              //  Console.WriteLine("Bir Sayı Giriniz:");
                //int sayi = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Giriniz olduğunuz sayi : "+ sayi);
            //}
            //catch(Exception ex)
            //{
            //   Console.WriteLine("Hata: "+ ex.Message.ToString());

            //} 
            //finally 
            //{
             //   Console.Write("İşlem tamamlandı.");


            //}
            
            try 
            {
               //int a = int.Parse("test");
               int a = int.Parse("=20000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer");
                Console.WriteLine(ex);
               
            }
            finally 
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }

        }
    }
}
