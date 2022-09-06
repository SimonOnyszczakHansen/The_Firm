using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee//Here we inheret the class
    {
        private int phoneNumber;//We create our instance variable
        public int PhoneNumber { get { return phoneNumber; } }//Encapsulation
        public Manager(int phoneNumber, string name, string lastName, int cpr): base (name, lastName, cpr)//Constructor where we use the values from the employee class
        {
            this.phoneNumber = phoneNumber;            
        }
        protected internal override void Write()//Method to write the values in console
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(CPR);
            Console.WriteLine("");
        }
        
    }
}
