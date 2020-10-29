using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitVSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "H#$@el#%lo #Wo$%*&(*@rld";

            var result = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.None)
                .Select(x => string.Concat(x.Where(y => Char.IsLetterOrDigit(y)))));

            Console.WriteLine(result);

            Console.WriteLine("Sasai kudasai");

            1q

            2w

            3e
        }
    }
}
