namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[1];
            int id;
            int age;
            string name;
            string email;
            double salary;

            Console.WriteLine("Enter employee data.");

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter data for employee number {i + 1}.");

                Console.Write("Name:");
                name = Console.ReadLine();
                employees[i].setName(name);

                Console.Write("id:");
                id = int.Parse(Console.ReadLine());
                employees[i].setId(id);

                Console.Write("Age:");
                age = int.Parse(Console.ReadLine());
                employees[i].setAge(age);

                Console.Write("Salary:");
                salary = double.Parse(Console.ReadLine());
                employees[i].setSalary(salary);

                Console.Write("Email:");
                email = Console.ReadLine();
                employees[i].setEmail(email);

            }

            for (int i = 0; i < employees.Length; i++)
            {
                {
                    Console.WriteLine($"Data of employee number ({i + 1}): {employees[i].print()}");
                }

            }
        }
    }
}
