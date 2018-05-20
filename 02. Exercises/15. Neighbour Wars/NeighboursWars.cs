using System;

class NeighboursWars
{
    static void Main()
    {
        int peshoAttack = int.Parse(Console.ReadLine());
        int goshoAttack = int.Parse(Console.ReadLine());

        int round = 0;

        int peshoHp = 100;
        int goshoHp = 100;

        //While loop

        while (peshoHp != 0 || goshoHp != 0)
        {
            round++;

            if (round % 2 == 1)
            {
                goshoHp -= peshoAttack;

                if (goshoHp <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;

                }

                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
            }
            else
            {
                peshoHp -= goshoAttack;

                if (peshoHp <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }

                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
            }



            if (round % 3 == 0)
            {
                goshoHp += 10;
                peshoHp += 10;
            }

            //if (goshoHp <= 0 )
            //{
            //    Console.WriteLine($"Pesho won in {round}th round.");
            //    return;

            //}
            //else if (peshoHp <= 0)
            //{
            //    Console.WriteLine($"Gosho won in {round}th round.");
            //    return;
            //}

            


        }
    }
}

