using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class RegexClass
    {
        public string firstName, lastName, emailId, phoneNumber, password;

        public void regexClass()
        {
            Console.WriteLine("\nEnter the first name");
            this.firstName = Console.ReadLine();
            while (!validateFirstName(this.firstName))
            {
                Console.WriteLine("Invalid First Name. Should start with an uppercase and contain minimum 3 characters");
                Console.WriteLine("Re-enter First Name");
                this.firstName = Console.ReadLine();
            }
            Console.WriteLine("Valid First Name");


          
    }
}
