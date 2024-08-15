namespace Day3.EmployeeClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass[] employees = new EmployeeClass[3];
            Guid id = Guid.NewGuid();
            string name;
            int age;
            string email;
            double salary;

            Console.WriteLine("Enter Employee Data.");
            for (int i = 0; i < employees.Length; i++)
            {
                id = Guid.NewGuid();
                Console.Write("Name:");
                name = Console.ReadLine();
                Console.Write("Age:");
                age = int.Parse(Console.ReadLine());
                Console.Write("Email:");
                email = Console.ReadLine();
                Console.Write("Salary:");
                salary = double.Parse(Console.ReadLine());

                employees[i] = new EmployeeClass(id, name, age, email, salary);
            }

            Console.Clear();
            for (int i = 0 ; i < employees.Length ; i++)
            {
                Console.WriteLine(employees[i].print());
                Console.WriteLine("=======================================");
            }
            Console.WriteLine($"Number of all employees is: {EmployeeClass.getNumberOfEmployee()}");

        }
    }
}
