using System;

namespace EmailAddressGenerator;

class EmailAddress
{
    public static void Main(String[] args)
    {
        LowerCase lower = new LowerCase();
        EmailConcat emailaddress = new EmailConcat();
        string fname, firstName;
        string lname, lastName;
        string input;
        string email;
        int dob;
        Console.Write("Your First Name : ");
        fname = Console.ReadLine();
        Console.Write("Your Last Name : ");
        lname = Console.ReadLine();
        Console.Write("Enter your date of birth : ");
        input = Console.ReadLine();

        try
        {
            dob = Convert.ToInt32(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine("There might be some error with your input. Please fix it.");
            dob = 0;
        }

        firstName = fname;
        lastName = lname;
        fname = lower.convertcase(fname.Substring(0,1));
        lname = lower.convertcase(lname);
        email = emailaddress.emailaddress(fname, lname, dob);
        
        Console.WriteLine($"'Hello {firstName} {lastName}, welcome to Robertson College!");
        Console.WriteLine($"Your new email address is {email}'");
    }
}