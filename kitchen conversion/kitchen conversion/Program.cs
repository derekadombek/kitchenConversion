using System;
using static System.Console;

namespace convertionTool
{
    class Program
    {
        public static void Main(string[] args)
        {
            double actualAmount;
            String enteredUnit, ConvertFrom, ConvertTo;



            WriteLine("what is the measurement you would like to convert from? ");
            ConvertFrom = ReadLine();
            
            WriteLine("what is the measurement you would like to convert to? ");
            ConvertTo = ReadLine();
            
            Write("how many {0} would you like in {1}? ", ConvertFrom, ConvertTo);
            enteredUnit = ReadLine();
            double.TryParse(enteredUnit, out actualAmount);

            WriteLine("it is {0} {1}'s", CalcForConvert(ConvertFrom, ConvertTo, actualAmount), ConvertTo);

        }
        static double CalcForConvert(string ConvertFrom, string ConvertTo, double actualAmount)
        {
            double teaspoon = 0;
            double tablespoon = 0;
            double cup = 0;
            double pint = 0;
            double quart = 0;
            double gallon = 0;

            switch (ConvertFrom)
            {
                case "teaspoons":
                    teaspoon = actualAmount;
                    tablespoon = teaspoon * 0.333333;
                    teaspoon = teaspoon * 1;
                    cup = teaspoon * 0.0205372;
                    pint = teaspoon * 0.0104167;
                    quart = teaspoon * 0.00520833;
                    gallon = teaspoon * 0.00130208;
                    break;

                case "tablespoons":
                    tablespoon = actualAmount;
                    teaspoon = tablespoon * 3;
                    tablespoon = tablespoon * 1;
                    cup = tablespoon * 0.0625;
                    pint = tablespoon * 0.03125;
                    quart = tablespoon * 0.015625;
                    gallon = tablespoon * 0.00390625;
                    break;

                case "cups":
                    cup = actualAmount;
                    teaspoon = cup * 48;
                    tablespoon = cup * 16;
                    cup = cup * 1;
                    pint = cup * 0.5;
                    quart = cup * 0.025;
                    gallon = cup * 0.0625;
                    break;

                case "pints":
                    pint = actualAmount;
                    teaspoon = pint * 96;
                    tablespoon = pint * 32;
                    cup = pint * 2;
                    pint = pint * 1;
                    quart = pint * 0.5;
                    gallon = pint * 0.125;
                    break;

                case "quarts":
                    quart = actualAmount;
                    teaspoon = quart * 192;
                    tablespoon = quart * 64;
                    cup = quart * 4;
                    pint = quart * 2;
                    quart = quart * 2;
                    gallon = quart * 0.25;
                    break;

                case "gallons":
                    gallon = actualAmount;
                    teaspoon = gallon * 768;
                    tablespoon = gallon * 256;
                    cup = gallon * 16;
                    pint = gallon * 8;
                    quart = gallon * 4;
                    gallon = gallon * 1;
                    break;

                default:
                    WriteLine("That was not a correct entry");
                    break;

            }
            switch (ConvertTo)
            {
                case "teaspoons":                    
                    return teaspoon;

                case "tablespoons":
                    return tablespoon;

                case "cups":
                    return cup;

                case "pints":
                    return pint;

                case "quarts":
                    return quart;

                case "gallons":
                    return gallon;

                default:
                    WriteLine("That was not a correct entry");
                    break;

            }
            return 0;
        }
    }
}
