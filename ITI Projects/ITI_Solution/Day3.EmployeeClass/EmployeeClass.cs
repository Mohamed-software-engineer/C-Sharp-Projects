using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.EmployeeClass
{
    public class EmployeeClass
    {
        #region Data Field
        Guid id;
        string name;
        int age;
        string email;
        double salary;
        #endregion

        #region Static Data Field
        static int numberOfEmployee = 0;
        #endregion

        #region Constructor
        public EmployeeClass() {
            numberOfEmployee++;
        }
        public EmployeeClass(Guid id, string name, int age, string email, double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
            this.salary = salary;
            numberOfEmployee++;
        }
        #endregion

        #region Methods
        
        public Guid getId()
        {
            return id;
        }

        public static int getNumberOfEmployee()
        {
            return numberOfEmployee;
        }

        public void setName(string _name)
        {
            if (_name != null)
            {
                name = _name;
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
        }
        public string getName()
        {
            return name;
        }

        public void setAge(int _age)
        {
            if (_age > 22)
            {
                age = _age;
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
        public int getAge()
        {
            return age;
        }
        public void setEmail(string _email)
        {
            if (_email != null)
            {

                email = _email;
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }

        public void setSalary(double _salary)
        {
            if (_salary >= 3000)
            {
                salary = _salary;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }
        }

        public string print()
        {
            return ($"id:{id} : Name:{name} : Age:{age} : Email:{email} : Salary:{salary}");
        }
        #endregion

    }
}
