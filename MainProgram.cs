using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Converter_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*every time there is an edit / update, change the version number (appart from comments)*/
            Console.WriteLine("***Binary and Hex Coverter 1.2*** \n <Press enter to continue>");
            Console.ReadLine();

            Start:

            Console.WriteLine("Would You Like to Convert Binary (Press 1) or Hexedecimal (Press 2)? \n <Then Press enter>");
            int keypress = Convert.ToInt32 (Console.ReadLine());

            if (keypress == 1)
            {    
                //goes straight into conversion
                Console.Write("Enter a decimal number: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("Binary =  {0}", result);
                Console.ReadLine();
            }
            else if (keypress == 2)
            {
                int decimalNumber, quotient;
                int i = 1, j, temp = 0;
                char[] hexadecimalNumber = new char[100];
                char temp1;
                Console.WriteLine("Enter a decimal number: ");
                decimalNumber = int.Parse(Console.ReadLine());
                quotient = decimalNumber;
                while (quotient != 0)
                {
                    temp = quotient % 16;
                    if (temp < 10)
                        temp = temp + 48;
                    else
                        temp = temp + 55;
                    temp1 = Convert.ToChar(temp);
                    hexadecimalNumber[i++] = temp1;
                    quotient = quotient / 16;
                }
                Console.Write("HexaDecimal = ");
                for (j = i - 1; j > 0; j--)
                    Console.Write(hexadecimalNumber[j]);
                Console.Read();
                
            }
            //this might have to be changed.
            Console.WriteLine();
            Console.ReadLine();
            goto Start; 
        }
    }
}
