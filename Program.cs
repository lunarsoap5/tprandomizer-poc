using System;
using Newtonsoft.Json;
using Assets.Items;
using System.IO;
using Logic;
using System.Collections.Generic;

namespace tprandomizer_poc_main
{
    public class Check
    {
        public string checkName { set; get;} //the common name for the check this can be used in the randomizer to identify the check."
        public bool empty { get; set;} //Identifies if we already placed an item on this check (starts at true)
        public string requirements { get; set;} //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
        public string hash { get; set;} //the fletcher hash that will be compared to on stage load
        public bool isExcluded { get; set;} //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
        public List<string> category { get; set;} //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
        public string itemId { get; set;} //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            LogicFunctions Logic = new LogicFunctions();
            var myJsonString = File.ReadAllText("./Checks/Overworld/Ordonia Province/Gift_From_Rusl.json");
            Check myJsonObject = JsonConvert.DeserializeObject<Check>(myJsonString);
		    Console.WriteLine("The check name is " + myJsonObject.checkName);
            Console.WriteLine("Is the check empty? " + myJsonObject.empty);
            Console.WriteLine("The Logic for the check is: " + myJsonObject.requirements);
            Console.WriteLine("The hash for the check is: " + myJsonObject.hash);
            Console.WriteLine("Hello World!");
        }
    }
}
