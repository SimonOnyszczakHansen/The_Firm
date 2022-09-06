using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal abstract class Employee
    {
        //Instance variables
        private string name;
        private string lastName;
        private int cpr;

        //Encapsulations
        public string Name { get { return name; } }
        public string LastName { get { return lastName; } }
        public int CPR { get { return cpr; } }

        //Constructor
        public Employee(string name, string lastName, int cpr)
        {
            this.name = name;
            this.lastName = lastName;
            this.cpr = cpr;
        }
        protected internal abstract void Write();//MEthod
        
    }
}
