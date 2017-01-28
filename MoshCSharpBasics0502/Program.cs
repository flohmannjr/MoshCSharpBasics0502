using System;

namespace MoshCSharpBasics0502
{
    class Program
    {
        const int DivisiblesBy3 = 1;
        const int AddingValue = 2;
        const int Factorial = 3;
        const int GuessTheNumber = 4;
        const int MaximumNumber = 5;

        static void Main(string[] args)
        {
            Console.Write("1 - Divisibles by 3\n2 - Adding Value\n3 - Factorial\n4 - Guess the Number\n5 - Maximum Number\n\nChoose an exercise: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case DivisiblesBy3:
                    Console.Write("Divisibles by 3 between 1 and 100: ");
                    for(int i = 1; i <= 100; i++)
                        if(i%3 == 0)
                            Console.Write(i + " ");
                    Console.WriteLine();
                    break;

                case AddingValue:
                    int totalValue = 0;
                    string input = "";

                    while(true)
                    {
                        Console.Write("Enter a number: ");
                        input = Console.ReadLine();

                        if(input == "ok")
                        {
                            Console.WriteLine("Total value: " + totalValue);
                            break;
                        }
                        else
                        {
                            totalValue += Convert.ToInt32(input);
                        }
                    }

                    break;
                case Factorial:
                    Console.Write("Enter a number: ");
                    int numberF = Convert.ToInt32(Console.ReadLine());
                    int factorial = 1;

                    for (int f = numberF; f > 0; f--)
                        factorial *= f;

                    Console.WriteLine("Factorial of " + numberF + " is: " + factorial);

                    break;
                case GuessTheNumber:
                    var random = new Random();
                    int secretNumber = random.Next(1, 10);
                    int guess = 0;
                    int chance = 0;

                    while(chance < 4)
                    {
                        Console.Write("Guess the secret number: ");
                        guess = Convert.ToInt32(Console.ReadLine());

                        if(guess == secretNumber)
                        {
                            Console.WriteLine("You won!");
                            break;
                        }

                        chance++;
                    }

                    if(chance >= 4)
                        Console.WriteLine("You lost. The secret number was " + secretNumber + ".");

                    break;
                case MaximumNumber:
                    Console.Write("Enter numbers separated by comma: ");
                    var numbers = Console.ReadLine().Split(',', ' ');
                    var max = 0;

                    foreach (var n in numbers)
                        if (Convert.ToInt32(n) > max)
                            max = Convert.ToInt32(n);

                    Console.WriteLine("Maximum number: " + max);

                    break;
                default:
                    Console.WriteLine("Invalid exercise.");
                    break;
            }
        }
    }
}
