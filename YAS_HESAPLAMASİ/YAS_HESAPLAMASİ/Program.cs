using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAS_HESAPLAMASİ
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2;
            Console.WriteLine("Doğum tarhinizi giriniz: ");
            tarih1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Bugünün tarihini giriniz: ");
            tarih2 = Convert.ToDateTime(Console.ReadLine());
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;
            Console.WriteLine("Yaşınız: " + gunfarki);
            Console.Read();

        }
    }
}
