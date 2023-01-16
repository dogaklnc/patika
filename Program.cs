using System;
 namespace hata_yonetimi;
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Writeline("Girişiniz Olduğu Sayı;"+ sayi);
            {
                catch(Exception ex)
                {
                    Console.Writeline("Hata"+ ex.Message);
                }
                finally
                {
                    Console.Writeline("işlem tamam");
                }
            }
        }
    }
 }