using System;
using System.Collections.Generic;
using System.Linq;

class SearchForNumber
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<int> elements = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        int countOfElements = elements[0];
        List<int> fisrtNumbers = numbers.Take(countOfElements).ToList();

        int removeElements = elements[1];
        List<int> skipedNumbers = fisrtNumbers.Skip(removeElements).ToList();

        int checker = elements[2];
        if (skipedNumbers.Contains(checker))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }

       

        //List<int> countOfElements = new List<int>();
        //for (int i = 0; i < elements[0]; i++)
        //{
        //    countOfElements.Add(numbers[i]);
        //}

        //for (int i = 0; i < countOfElements.Count; i++)
        //{
        //    int deleteNumber = elements[1];
        //    if (deleteNumber == countOfElements[i])
        //    {
        //        countOfElements.Remove(countOfElements[i]);
        //    }
        //}

        //for (int i = 0; i < countOfElements.Count; i++)
        //{
        //    int checker = elements[2];
        //    if (countOfElements.Contains(checker))
        //    {
        //        Console.WriteLine("YES!");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO!");
        //    }
            
           
        //}

        
       
    }
}

