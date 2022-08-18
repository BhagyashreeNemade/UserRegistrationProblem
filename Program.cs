namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            RegexClass regex = new RegexClass();
            regex.ValidateFirstNameRegex("Bhagyashree");
            regex.ValidateLastNameRegex("Nemade");
            string[] EmailList = { "abc@yohoo.com","abc-100@yohoo.com",
                                    "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                                     "abc.100@abc.com.au", "abc@1.com","abc","abc@.com.my",
                                    "abc123@gmail.a",
                                     "abc1232.com"
                                     ,".abc@abc.com","abc123.com.my", "abc123@.com.com","bhagyashreenemade2000@gmail.com"};

            regex.ValidateEmailAddressRegex("b.nemade@rgit.com");
            foreach (string SampleEmailAddress in EmailList)
            {
                regex.ValidateEmailAddressRegex(SampleEmailAddress);
            }
            regex.ValidatePhoneNumberRegex("91 7020794997");
            regex.ValidatePasswordRegex("Bhagyashree@2000");
            
        }
    }
}