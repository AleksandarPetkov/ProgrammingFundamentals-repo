using System;
using System.Collections.Generic;
using System.Linq;

class Practise
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (input != "END")
        {
            string[] phoneArgs = input.Split(' ');

            string command = phoneArgs[0];
            string name = phoneArgs[1];
            string phoneNumber = phoneArgs[2];

            if (command == "A")
            {

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phoneNumber);
                }
                else
                {
                    phonebook[name] = phoneNumber;
                }
            }

            if (command == "S") 
            {
                phonebook.ContainsKey(name);
                Console.WriteLine($"{name} -> {phoneNumber}");
               
            }

            input = Console.ReadLine();
        }

    }
}

