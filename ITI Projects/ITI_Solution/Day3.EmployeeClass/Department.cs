using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.EmployeeClass
{
    public class Department
    {
        #region Data Field
        Guid id = Guid.NewGuid();
        string name;
        EmployeeClass employee;
        #endregion

        #region Constructors
        public Department()
        {

        }
        public Department(Guid _id, string _name, EmployeeClass _employee)
        {
            id = _id;
            name = _name;
            employee = _employee;
        }
        #endregion

        #region Methods
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public EmployeeClass getEmployeeClass()
        {
            return employee;
        }

        public Guid getId()
        {
            return id;
        }
        #endregion
    }
}
