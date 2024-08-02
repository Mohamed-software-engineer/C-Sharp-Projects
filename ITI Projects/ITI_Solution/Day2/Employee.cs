using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public struct Employee
    {
        #region Data Field
        int id;
        string name;
        int age;
        string email;
        double salary;
        #endregion

        /*public Employee()
        {
            id = 0;
            name = " ";
            age = 23;
            email = " ";
            salary = 3000;
        }*/
        #region Methods
        public void setId(int _id)
        {
            if (_id >= 0)
            {
                id = _id;
            }
            else
            {
                Console.WriteLine("Invalide id");
            }
        }
        public int getId()
        {
            return id;
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
            return ($"{id} : {name} : {age} : {email} : {salary}");
        }
        #endregion

    }
}
