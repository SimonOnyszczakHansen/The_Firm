using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Sweeper : Employee
    {
        public Sweeper(string name, string lastName, int cpr): base (name, lastName, cpr)//Inheret the values from employees 
        {

        }
        //Write the values in console
        protected internal override void Write()
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(CPR);
            Console.WriteLine("");
        }
    }
}
