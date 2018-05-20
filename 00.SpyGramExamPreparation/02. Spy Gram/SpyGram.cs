using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class SpyGram
{
    static void Main()
    {
        string pattern = @"^TO: [A-Z]+; MESSAGE: .*;$";

        int code = int.Parse(Console.ReadLine());

        List<int> codeList = new List<int>();
        List<string> fackingResult = new List<string>();
        while (code > 0)
        {
            int n = code % 10;
            codeList.Add(n);

            code /= 10;
        }
        codeList.Reverse();


        while (true)
        {
            string text = Console.ReadLine();
            if (text == "END")
            {
                break;
            }

            if (Regex.IsMatch(text, pattern) == false)
            {
                continue;
            }

            StringBuilder sb = new StringBuilder();
            int maxCodeLenght = codeList.Count - 1;
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {

                int adding = (text[i] + codeList[counter]);
                char newChar = (char)adding;
                sb.Append(newChar);

                if (maxCodeLenght == counter)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }

            }
            fackingResult.Add(sb.ToString());

        }
        foreach (var result in fackingResult.OrderBy(x => x))
        {
            Console.WriteLine(result);
        }
    }
}

