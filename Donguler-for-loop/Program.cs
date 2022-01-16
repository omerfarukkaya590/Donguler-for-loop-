using System;

namespace Donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
             //Ekrandan yazılan sayıya kadar olan tek sayıları yazdır
            Console.Write("Lütfen Bir Sayı Giriniz");
             int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                Console.WriteLine(i);
            }
            int TekToplam = 0;
            int ÇiftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 1)
                TekToplam += i; // tekToplam = tekToplam + i;

                else
                ÇiftToplam += i; // ÇiftToplam = ÇiftToplam+1;
            }
          Console.WriteLine("Tek Toplam:"+ TekToplam);
          Console.WriteLine("ÇiftToplam:" +ÇiftToplam);
                  //break continue
                  for (int i = 1; i < 10; i++)
                  {
                      if(i == 4)
                      continue;
                      Console.WriteLine(i);
                      
                  }
        }
    }
}
