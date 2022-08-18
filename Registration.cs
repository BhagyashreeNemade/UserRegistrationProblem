﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Registration
    {

        public string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string EmailAddress = "^[a-zA-Z0-9_\\-\\.]+[@][a-z]+[\\.]([a-z]{2,3})([\\.]?[a-z]*)$";

        public void checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            if (Regex.IsMatch(Firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
        public void checklastname(string Lastname)
        {
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(Lastname))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
        public void checkEmail(string EmailID)
        {
            Regex regex = new Regex(EmailAddress);
            if (regex.IsMatch(EmailID))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }

    }
}
