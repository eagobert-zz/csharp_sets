using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

        // Create an empty HashSet named Showroom that will contain strings.
        HashSet<string> Showroom = new HashSet<string>();

        //Add four of your favorite car model names to the set.
        Showroom.Add("Tesla");
        Showroom.Add("Honda");
        Showroom.Add("BMW");
        Showroom.Add("Volkswagen");

        //Print to the console how many cars are in your show room.
        Console.WriteLine(Showroom.Count);

        //Pick one of the items in your show room and add it to the set again.
        Showroom.Add("Honda");

        //Print your showroom again, and notice how there's still only one representation of that model in there.
        Console.WriteLine(Showroom.Count);

        //Create another set named UsedLot and add two more car model strings to it.
        HashSet<string> UsedLot = new HashSet<string>();
        UsedLot.Add("Ford");
        UsedLot.Add("Ferrari");

        //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
        HashSet<string> CombinedLot = new HashSet<string>(Showroom);
        CombinedLot.UnionWith(UsedLot);

        //Print new set CombinedLot
        Console.WriteLine(CombinedLot.Count);
    

        //You've sold one of your cars. Remove it from the set with the Remove() method.
        CombinedLot.Remove("Ferrari");

        //Print set
        Console.WriteLine(CombinedLot.Count);
        Console.WriteLine("");

        //Now create another HashSet of cars in a variable Junkyard. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.

        HashSet<string> Junkyard = new HashSet<string>();
        Junkyard.Add("Ferrari");
        Junkyard.Add("Ford");
        Junkyard.Add("Honda");
        Junkyard.Add("Toyota");
        Junkyard.Add("Subaru");

        //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
        CombinedLot.IntersectWith(Junkyard);

        //Display each car in CombinedLot that intersects with Junkyard
        foreach(string car in CombinedLot){
            Console.WriteLine(car);
            Console.WriteLine("");
        }

        //Use the UnionWith() method to combine the junkyard into your showroom.
        CombinedLot.UnionWith(Junkyard);

        //Print set
        foreach(string car in CombinedLot){
            Console.WriteLine(car);
            Console.WriteLine("");
        }

        //Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
        CombinedLot.Remove("Subaru");

        //Print set
        foreach(string car in CombinedLot) {
            Console.WriteLine(car);
        }

        }
    }
}
