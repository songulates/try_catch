using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
           
             try
            {
                
                //int a=int.Parse(null);
                //int a =int.Parse("test");
                int b =int.Parse("11111111111111");
               
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("çok büyük veya çok küçük değer girdiniz");
                Console.WriteLine(ex);

            }


        }
    }
}

