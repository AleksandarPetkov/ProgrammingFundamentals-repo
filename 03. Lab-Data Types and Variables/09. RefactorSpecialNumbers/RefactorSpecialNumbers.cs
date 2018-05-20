using System;

class RefactorSpecialNumbers
{

    static void Main()
    {

        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= number; i++)
        {
            int digits = i;
            int sum = 0;

            while (digits > 0)
            {
                sum += digits % 10;
                digits = digits / 10;
            }

            bool isTrue = sum == 5 || sum == 7 || sum == 11;

            Console.WriteLine($"{i} -> {isTrue}");
        }
    }
}


