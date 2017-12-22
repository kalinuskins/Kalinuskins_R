using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveidosim kalk objektu
            MathParser;
            parser = new MathParser();

            // Paprasit lietotajam ievadit ievadi
            Console.WriteLine("Please enter darbiba");
            string input = Console.ReadLine();

            int result = MathParser.ParseMath(input);
            Console.WriteLine("your result" + result);
            
            Console.ReadLine();
        }
    }
}
