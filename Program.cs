using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GetPraceEth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm is runing!!!");
            Console.WriteLine("=====================");

            string min;
            int sec;

            while (true)
            {
                min = DateTime.Now.ToString("mm");
                sec = DateTime.Now.Second;

                WorkClass.Show();
                Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.ToString("mm")} | Mail sent!!!");
                Console.WriteLine("=====================");

            }
        }
    }
}
