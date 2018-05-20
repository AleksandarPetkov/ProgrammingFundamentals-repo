using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UsersLog
{
    static void Main()
    {
        var users = new Dictionary<string, Dictionary<string,int>>();// user-ip-counter

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] commandArgs = input.Split(' ').ToArray();

            string name = commandArgs[2].Replace("user=","");// Премахвам "users=" за да взема само name

            string ip = commandArgs[0].Replace("IP=", "");// take the current IP

            if (!users.ContainsKey(name))
            {
                users.Add(name, new Dictionary<string, int>());

            }
            if (!users[name].ContainsKey(ip)) //users[name] e value-то на name
            {
                users[name].Add(ip, 0);// Тук вече съм във втория речник! Искам всеки път да го увеличавам
            }                         //  с едно ако го срещна

            users[name][ip] = users[name][ip] + 1;// ? ? ?


            input = Console.ReadLine();
        }

        foreach (var user in users.OrderBy(x => x.Key))
        {
            Console.WriteLine(user.Key+":");

            StringBuilder sb = new StringBuilder();

            foreach (var ipAndCount in user.Value) // Със вложения foreach обикалям value-to(което е Dictionary) 
            {                                     // на нашият key

                sb.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");// защото тук са 2 ел
            }                                                                           // за remove
            sb.Remove(sb.Length - 2, 2);  // По този начин махам последната ","(-2 е защото lenght-та е -1)
            sb.Append(".");              // Тук долепям "."
            Console.WriteLine(sb.ToString());
            
        }
    }
}

