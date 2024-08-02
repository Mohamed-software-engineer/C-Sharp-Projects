namespace Day2.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string _operator;
            string choice;

            Console.WriteLine("-------------------Calculator---------------------");
            do
            {
                Console.Write("Enter first number:");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter second number:");
                y = int.Parse(Console.ReadLine());
                Console.Write("Enter your operator(+,-,*,/):");
                _operator = Console.ReadLine();
                switch (_operator)
                {
                    case "+":
                        {
                            Console.WriteLine($"{x} + {y} = {x + y}");
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine($"{x} - {y} = {x - y}");
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine($"{x} * {y} = {x * y}");
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine($"{x} / {y} = {x / y}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.Write("Again ? (y/n)");
                choice = Console.ReadLine();

            } while (choice == "y" || choice == "Y");

            Console.WriteLine("Thank You .");
        }
    }
}
