using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        numbers.Sort();// Сортирам си номерата по възходящ ред

        int count = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            int currentNum = numbers[i];
            
            if (i < numbers.Count - 1 && numbers[i] != numbers[i+1] || i == numbers.Count - 1)
            {
                //Ако i е по малко от последната позиция -> 'i < numbers.Count-1'
                //Ако числата са ни различни -> numbers[i] != numbers[i+1]
                //Ако няма следваща позиция (стигнали сме послената позиция на цикъла) -> i == numbers.Count-1

                Console.WriteLine($"{currentNum} -> {count}");
                count = 0;
            }
            count++;
        }


                        //РЕШЕНИЕ С МАСИВ И FOR EACH
        //int[] counts = new int[numbers.Max() + 1];// Взимам най голямото число +1 и по този начин си оразмерявам
        //                                         // масива с нужните числа
        //foreach (var num in numbers)
        //{
        //    counts[num]++; // чрез този синтаксис [num]++, казвам да добавя елемента [num] в масива ми counts!

        //}

        //for (int i = 0; i < counts.Length; i++)
        //{
        //    if (counts[i] > 0)
        //    {
        //        Console.WriteLine($"{i} -> {string.Join(" ", counts[i])}");
        //    }
            
        //}

    }
}

