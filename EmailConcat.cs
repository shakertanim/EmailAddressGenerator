namespace EmailAddressGenerator;

public class EmailConcat
{
    public string emailaddress(string fname, string lname, int dob)
    {
        string email;

        email = fname + lname + dob + "@robertsoncollege.ca";

        return email;
    }
}