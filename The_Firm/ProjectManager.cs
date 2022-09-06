using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class ProjectManager : Manager
    {
        private string eMail;//Instance variable

        public string EMail { get { return eMail; } }//Encapsulation

        public ProjectManager(string eMail, int phoneNumber, string name, string lastName, int cpr):base(phoneNumber, name, lastName, cpr)//Constructor where we use the variables from the other class
        {
            this.eMail = eMail;
        }

        //Write the values in console
        protected internal void Write()
        {
            base.Write();
            Console.WriteLine(EMail);
            Console.WriteLine("");
        }
    }
}
