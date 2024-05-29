using Labb5_Kalkylator;
using System.Diagnostics;

namespace Labb6_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculations = new Calculations();
            var historyList = new List<Calculations>();
            double result = 0;


            bool program = true;
            while (program)
            {
                DisplayMenu();

                (int choice, double tal1, double tal2) = UserInput();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        result = calculations.Addition(tal1, tal2);
                        DisplayCalculation(tal1, tal2, "+", result);
                        Calculations additionHistory = calculations.AddCalculation(tal1, tal2, "+", result);
                        historyList.Add(additionHistory);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        result = calculations.Subtraktion(tal1, tal2);
                        DisplayCalculation(tal1, tal2, "-", result);
                        Calculations subHistory = calculations.AddCalculation(tal1, tal2, "-", result);
                        historyList.Add(subHistory);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        result = calculations.Multiplikation(tal1, tal2);
                        DisplayCalculation(tal1, tal2, "*", result);
                        Calculations multiHistory = calculations.AddCalculation(tal1, tal2, "*", result);
                        historyList.Add(multiHistory);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        result = calculations.Division(tal1, tal2);
                        DisplayCalculation(tal1, tal2, "/", result);
                        Calculations divHistory = calculations.AddCalculation(tal1, tal2, "/", result);
                        historyList.Add(divHistory);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        DisplayHistory(historyList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Programmet avslutas . . .");
                        Thread.Sleep(2000);
                        program = false;
                        break;
                }
            }
            
        }



        public static (int choice, double tal1, double tal2) UserInput()
        {
            double tal1 = 0;
            double tal2 = 0;
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 0 && choice < 5)
            {
                Console.Clear();
                Console.WriteLine("Skriv in ditt första tal: ");
                tal1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Skriv in ditt andra tal: ");
                tal2 = Convert.ToDouble(Console.ReadLine());
            }
            else if (choice > 6 || choice < 1)
            {
                Console.WriteLine("Skriv in en siffra mellan 1-6");
                Console.ReadKey();
                Console.Clear();
            }


            return (choice, tal1, tal2);
        }

        public static void DisplayHistory(List<Calculations> historyList)
        {
            foreach (Calculations Item in historyList)
            {
                Console.WriteLine($"{Item.Num1} {Item.Sign} {Item.Num2} = {Math.Round(Item.Result, 2)}");
            }
        }

        public static void DisplayCalculation(double tal1, double tal2, string sign, double result)
        {
            Console.WriteLine($"{tal1} {sign} {tal2} = {Math.Round(result, 2)}");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Välkommen till kalkylatorn!\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Se tidigare uträkningar");
            Console.WriteLine("6. Avsluta");
        }
    }
}
