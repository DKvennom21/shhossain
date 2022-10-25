using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cp, sp, amt;

            Console.Write("\n\n");
            Console.Write("Calculate profit and loss:\n");
            Console.Write("Input Cost Price: ");
            cp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            sp = Convert.ToInt32(Console.ReadLine());

            if (sp > cp)
            {
                amt = sp - cp;
                Console.Write("\nprofit amount :", amt);
            }
            else if (cp > sp)
            {
                amt = cp - sp;
                Console.Write("\nloss of amount :", amt);
            }
            else
            {
                Console.Write("\nno profit , no loss.");
            }
        }
    }
}
