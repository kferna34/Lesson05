using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_01
{
    /**
    *
    
    *<summary>
    * the teacher is derived from the person.cs
    *</summary>
    *@ class Teacher
    *@ person.cs
    */
    class Teacher : Person
    {
        //private ins var====================================

        private string _employeeID;

        // public  property ===============================

        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }

            set
            {
                _employeeID = value;
            }

        }
        public Teacher(string name, int age, string employeeID) : base(name, age)
        {
            this.EmployeeID = _employeeID;
        }

        public void Teaches()
        {
            Console.WriteLine(this.Name + "teaches.");
        }
    }
}
