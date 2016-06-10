using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class Person
    {
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        private int _age
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private int _name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Speak()
        {
            throw new System.NotImplementedException();
        }
    }
}