using System;
using System.Collections.Generic;
using System.Linq;

class FixMails
{
    static void Main()
    {
        Dictionary<string, string> nameAndEmails = new Dictionary<string, string>();

        string name = Console.ReadLine();

        while (name != "stop")
        {
            string email = Console.ReadLine();

            if (!email.EndsWith("uk") && !email.EndsWith("us"))
            {
                if (!nameAndEmails.ContainsKey(name))
                {
                    nameAndEmails.Add(name, email);
                }
            }
          
            name = Console.ReadLine();
        }

        foreach (var names in nameAndEmails)
        {
            Console.WriteLine($"{names.Key} -> {names.Value}");
        } 
    }
}

