using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna numero: ");
            string line = Console.ReadLine();
            int luku;

            bool result = Int32.TryParse(line, out luku);
            if (result)
            {
                switch (luku)
                {
                    case 1: Console.WriteLine("yksi"); break;
                    case 2: Console.WriteLine("kaksi"); break;
                    case 3: Console.WriteLine("kolme"); break;
                    default: Console.WriteLine("joku muu luku"); break;
                }
            }
            else
            {
                Console.WriteLine("Voisit antaa numeron");
            }
            Console.ReadLine();
        }
    }
}
