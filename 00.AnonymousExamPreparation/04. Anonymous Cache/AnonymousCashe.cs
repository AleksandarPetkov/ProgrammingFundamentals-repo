using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//•	{dataSet}
//•	{dataKey} -> {dataSize} | {dataSet}


class Anonymous
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> dictDatHolders = new Dictionary<string, Dictionary<string, long>>();
        List<string> remaider = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "thetinggoesskrra")
            {
                break;
            }
            string[] inputArgs = input.Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputArgs.Length == 1)
            {
                remaider.Add(inputArgs[0]);
            }
            else
            {
                string dataKey = inputArgs[2];
                string dataSet = inputArgs[0];
                long dataSize = long.Parse(inputArgs[1]);

                if (dictDatHolders.ContainsKey(dataKey) == false)
                {
                    dictDatHolders.Add(dataKey, new Dictionary<string, long>());
                }
                if (dictDatHolders[dataKey].ContainsKey(dataSet) == false)
                {
                    dictDatHolders[dataKey].Add(dataSet, dataSize);
                }
            }

        }

        foreach (var data in dictDatHolders.OrderByDescending(x => x.Value.Values.Sum()))
        {
            if (remaider.Contains(data.Key))
            {
                Console.WriteLine($"Data Set: {data.Key}, Total Size: {data.Value.Values.Sum()}");

                foreach (var item in data.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
                return;
            }
        }
    }
}


