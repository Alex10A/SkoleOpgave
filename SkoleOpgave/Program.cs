using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opgave opgave = new opgave();
            opgave.Navn();
            opgave.Klog();
            opgave.Hvem();
            opgave.navn2();


            
            Console.ReadKey();
        }
    }
}
