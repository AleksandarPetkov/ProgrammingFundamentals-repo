using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
             Split(' ').
             Select(int.Parse).
             ToList();

        string command = Console.ReadLine();

        while (command != "print")
        {
            string[] commanddArgs = command.Split(' ').ToArray(); // command. е -> (string command = Console.ReadLine();)
            // без да кажа, че commanddArgs е Array ми дава недостатъчно памет в judge
            if (commanddArgs[0] ==  "add")
            {
                numbers.Insert(int.Parse(commanddArgs[1]), int.Parse(commanddArgs[2]));
            }
            else if (commanddArgs[0] == "contains")
            {
                int number = int.Parse(commanddArgs[1]);

                if (numbers.Contains(number))
                {
                    Console.WriteLine(numbers.IndexOf(number));
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            else if (commanddArgs[0] == "addMany")
            {
                numbers.InsertRange(int.Parse(commanddArgs[1]), commanddArgs.Skip(2).Select(int.Parse).ToList());
                // Чрез InsertRange първо добавям индекса, после взимам колекцията  commanddArgs, скипвам 2 елемента
                // които няма да ми трябват парсвам всички към инт и към Лист
            }
            else if (commanddArgs[0] == "remove")
            {
                numbers.RemoveAt(int.Parse(commanddArgs[1]));
            }
            else if (commanddArgs[0] == "shift")
            {
                int number = int.Parse(commanddArgs[1]);
                number = number % numbers.Count; // Гарантирам си, че ще завъртя нужният брой пъти без да се счупи

                for (int i = 0; i < number; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else if (commanddArgs[0] == "sumPairs")
            {
                for (int i = 0; i < numbers.Count-1; i++)
                {
                    int sum = numbers[i] + numbers[i + 1];
                    numbers[i] = sum;
                    numbers.RemoveAt(i + 1);
                }
            }


            command = Console.ReadLine();
        }
        

        Console.WriteLine($"[{string.Join(", ",numbers)}]");
    }

 
}

