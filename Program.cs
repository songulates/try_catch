using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            try
            {
                Console.WriteLine("sayi gri");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girilen sayi "+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);

            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");

            }
           


        }
    }
}

