using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBookUpgrade
{
    static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (input != "END")
        {
            string[] phoneArgs = input.Split(' ').ToArray();

            string command = phoneArgs[0];

            if (command == "A")
            {
                string key = phoneArgs[1];
                string value = phoneArgs[2];

                if (!phonebook.ContainsKey(key))
                {
                    phonebook.Add(key, value);
                }
                else
                {
                    phonebook[key] = value;    
                }
               
            }
            else if (command == "S")
            {
                string key = phoneArgs[1];
                if (phonebook.ContainsKey(key))
                {
                    Console.WriteLine($"{key} -> {phonebook[key]}");
                }
                else
                {
                    Console.WriteLine($"Contact {key} does not exist.");
                }
            }
            else if (command == "ListAll")
            {
                foreach (var phone in phonebook)
                {
                    Console.WriteLine($"{phone.Key} -> {phone.Value}");
                }
                
            }

            input = Console.ReadLine();

        }
    }
}

