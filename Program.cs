﻿namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            RegexClass regex = new RegexClass();
            regex.ValidateFirstNameRegex("Bhagyashree");
            regex.ValidateLastNameRegex("Nemade");
            regex.ValidateEmailAddressRegex("b.nemade@rgit.com");


        }
    }
}