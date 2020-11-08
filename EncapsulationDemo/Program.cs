
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.AdSoyad = "Çağıl Alsaç";
            customer.ErkekMi = true;
            customer.KartNo = "1234 5678 9012 3456";
            Console.WriteLine("Adı: " + customer.AdSoyad + "\n" + "Kart No: " + customer.KartNo);
            Console.ReadLine();
        }
    }
}
