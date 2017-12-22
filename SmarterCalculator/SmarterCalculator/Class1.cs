using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterCalculator
{
    class MathParser
    {
        // funkcija, kas sanem lietotaju ievadiju tekstu
        // un saparse to, veic matematiskas darbibas,
        // un atgriezis rezultatu
        public int ParseMath(string input)
        {
            // "16+5-4" skaits ir 6 pedeja simbola pozicija ir 5
            // "1a" Skaits ir 2 pedeja pozicija ir 1
            //izveido mainigo kura saglaba ievadito ciparu tekstu
            string firstenterNumber = "";
            string secondenterNumber = "";
            char enteredOperation = ' ';
            bool operationFound = false;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {
                    //ja iepresheja operacija ir atrasta operacija
                    //tad javeic operacija
                    if (operationFound == true)
                    {
                        int result = Int32.Parse(firstEnterNumber) + Int32.Parse(secondEnterNumber);
                        return result;
                    }
                    // saglaba operaciju mainigaja
                    enteredOperation = symbol;
                    // ieliek karodzinu, ka tad tiks pabeigts

                    // ielasit nakosho skaitl, operacija ir 1
                    operationFound = true;
                }
                else
                {
                    // kad cipars ir atrasts;
                    // Ja operacija vel nav bijusi, tad ierakstam vertibu
                    if (operationFound == false)
                    {
                        // pirmaja skaitli
                        secondEnterNumber = secondNumber + symbol;

                    }

                    // ja operacija ir bijusi
                    // Saglabat simbolu teksta virkni, lai tam
                    // var pieklut, kad tiek veikta darbiba
                    firstenterNumber = firstenterNumber + symbol;
                }

                counter = counter + 1;

                return 99999;
            }
        }
    }
}