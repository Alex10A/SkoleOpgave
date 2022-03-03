using System;

namespace SkoleOpgave
{
    public class opgave
    {
        public string Navn()
        {
            Console.WriteLine("Hvad hedder du ?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}");
            return name;
        }

        public void Klog()
        {
            Console.WriteLine("Er du klog?");
            string ErDuKlog = Console.ReadLine();
            if (ErDuKlog.ToLower().Equals("ja"))
            {
                Console.WriteLine($"Er der andre der er kloge end dig ?");
                return;
            }
            else
            {
                Console.WriteLine("Du er åbenbart ikke klog :/\nHvem er så klog?");
                return;
            }
        }

        public void Hvem()
        {
            string hvem = Console.ReadLine();
            if (hvem.ToLower().Equals(""))
            {
                Console.WriteLine("Lukker.... Du skal svar :(");
                Console.ReadKey();
                Environment.Exit(0);
                return;
            }
            else
            {
                Console.WriteLine("Hvad hedder personen?");
                return;
            }
        }

        public void navn2()
        {
           string navn2 = Console.ReadLine();
           if (navn2.ToLower().Equals(""))
            {
                Console.WriteLine("Lukker.... Du skal svar :(");
                Console.ReadKey();
                Environment.Exit(0);
                return;
            } 
           else
            {
                Console.WriteLine($"Jeg syntes også {navn2} er klog");
                return;
            }
        }
    }
}
