namespace what_s_greater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("-------------------The greater number---------------------");
            Console.WriteLine("\nEnter three numbers to check the greater one.");

            Console.Write("The first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("The second number: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("The third number: ");
            z = int.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine($"The greater number is {x}");
            }
            else if (y > z && y > x) {
                Console.WriteLine($"The greater number is {y}");
            }
            else
            {
                Console.WriteLine($"The greater number is {z}");
            }

        }
    }
}
