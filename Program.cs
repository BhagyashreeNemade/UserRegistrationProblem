namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Registration registration = new Registration();
            Console.WriteLine("Enter the First Name");
            string fName = Console.ReadLine();
            registration.checkfirstname(fName);


            Console.WriteLine("Enter the Last Name");
            string lName = Console.ReadLine();
            registration.checklastname(lName);

            Console.WriteLine("Enter the Email Address");
            string Email = Console.ReadLine();
            registration.checkEmail(Email);


        }
    }
}