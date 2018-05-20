using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBook
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (input != "END")
        {
            string[] phoneParameters = input.Split(' ').ToArray();

            string command = phoneParameters[0];// Командата ми е първата стойност на PhoneParameters

            if (command == "A")
            {
                string key = phoneParameters[1];   // Инициализирам си key,value от PhoneParameters
                string value = phoneParameters[2];

                //phonebook.Add(key, value)-> и с двете домабавям стойност, но с .Add немога да презапиша
                phonebook[key] = value; //-> с този синтаксис спокойно си презаписвам key and value но В РЕАЛНИЯ
                //ЖИВОТ НЕ Е ДОБРА ПРАКТИКА! ГУБЯТ СЕ ДАННИ!!!Мога да си запомня тази конструкция
                //if (! phonebook.ContainsKey(key))
                //{
                //    phonebook.Add(key, value);
                //}
            }
            else if (command == "S")
            {
                string key = phoneParameters[1];

                if (phonebook.ContainsKey(key))// Ако моя речник съдържа въпросният ключ
                {
                    Console.WriteLine($"{key} -> {phonebook[key]}");// Чрез този синтаксис phonebook[key] казвам: 
                                                                   //Речник дай ми стойноста на която стои този key

                }
                else
                {
                    Console.WriteLine($"Contact {key} does not exist.");
                }
            }


            input = Console.ReadLine();
        }
    }
}

