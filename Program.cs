using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>();
            showRoom.Add("Civic");
            showRoom.Add("Explorer");
            showRoom.Add("Malibu");
            showRoom.Add("Impala");
            showRoom.Add("Civic");
            Console.WriteLine(showRoom.Count);
            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("Tahoe");
            usedLot.Add("Jeep");
            showRoom.UnionWith(usedLot);
            showRoom.Remove("Explorer");
            HashSet<string> junkYard = new HashSet<string>();
            junkYard.Add("Civic");
            junkYard.Add("Jeep");
            junkYard.Add("Corvette");
            junkYard.Add("Charger");
            HashSet<string> clone = new HashSet<string>(showRoom);
            clone.IntersectWith(showRoom);
            showRoom.UnionWith(junkYard);
            junkYard.Remove("Charger");
        }
    }
}
