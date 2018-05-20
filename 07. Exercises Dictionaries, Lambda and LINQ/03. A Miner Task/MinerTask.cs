using System;
using System.Collections.Generic;
using System.Linq;

class MinerTask
{
    static void Main()
    {
        Dictionary<string, int> materialsAndQuantity = new Dictionary<string, int>();
        string material = Console.ReadLine();

        while (material != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());

            if (materialsAndQuantity.ContainsKey(material))
            {
                materialsAndQuantity[material] += quantity;
            }
            else
            {
                materialsAndQuantity.Add(material, quantity);
            }
           
            material = Console.ReadLine();
        }

        foreach (var materials in materialsAndQuantity)
        {
            Console.WriteLine($"{materials.Key} -> {materials.Value}");
        }
    }
}

