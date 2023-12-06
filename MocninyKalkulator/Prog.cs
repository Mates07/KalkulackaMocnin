using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MocninyKalkulator;

internal class Prog
{
    public void Run()
    {
        bool c = true;
        while (c)
        {
            Console.WriteLine("zadejte zaklad");
            string a = Console.ReadLine();
            if (a == "end")
            {
                break;
            }
            else
            {
                Console.WriteLine("zadejte exponent");
                string b = Console.ReadLine();
                int cislo1 = ConvertToInt(a);
                int cislo2 = ConvertToInt(b);
                double vysledek = Math.Pow(cislo1, cislo2);
                Console.WriteLine($"vysledek je {vysledek}");
            }
            
        }
       
    }
    public int ConvertToInt(string x)
    {
        if (int.TryParse(x, out int result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }
}
