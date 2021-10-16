using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan kullacıdan sayı alıp sayının karesini yazan prog.
            Console.Write("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = sayi * sayi;
            Console.WriteLine("Sonuç=>" + sonuc);
            Console.ReadKey();

        }
    }
}
