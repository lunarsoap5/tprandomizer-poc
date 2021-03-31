using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Assets.Items;
using System.IO;
using Logic;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;

namespace tprandomizer_poc_main
{ 
    class Program
    {
        ItemFunctions Items = new ItemFunctions();
        
        
        void startOver(Room startingRoom)
        {
            
            Items.nbSkybooksPlaced = 0;
            for (int i = 0; i< Items.PlacedImportantItems.Count(); i++)
            {
                Items.heldItems.Add(Items.PlacedImportantItems[i]);
            }
            Items.PlacedImportantItems.Clear();
            //empty all checks of their items  
            placeRequiredItems(startingRoom);
        }

        void placeRequiredItems(Room startingRoom)
        {
            Random rnd = new Random();
            RoomFunctions Rooms = new RoomFunctions();
            CheckFunctions Checks = new CheckFunctions();
            List<string> availableChecks = new List<string>();
            availableChecks = Rooms.listAllAvailableChecks(startingRoom);
            Item itemToPlace = Items.verifyItem(Items.heldItems[rnd.Next(Items.heldItems.Count()-1)]);
            string checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
            
            while (Items.heldItems.Count() > 0 && availableChecks.Any())
            {
                while (!Checks.checkIfItemNotNeededToReachCheck(itemToPlace, checkToReciveItem, startingRoom))
                {
                    checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                }
                
                Checks.placeItemInCheck(itemToPlace,checkToReciveItem);
                
                availableChecks = Rooms.listAllAvailableChecks(startingRoom);
                itemToPlace = Items.verifyItem(Items.heldItems[rnd.Next(Items.heldItems.Count()-1)]);
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
            }
            if (Items.heldItems.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
        }
        
        static void Main(string[] args)
        {
            CheckFunctions Checks = new CheckFunctions();
            RoomFunctions Rooms = new RoomFunctions();
            
            
            Checks.InitializeChecks();
            foreach (string file in System.IO.Directory.GetFiles("./Checks/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Checks.CheckDict[fileName] = JsonConvert.DeserializeObject<Check>(contents);
                Check currentCheck = Checks.CheckDict[fileName];
                currentCheck.requirements = Regex.Replace(currentCheck.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                Checks.CheckDict[fileName] = currentCheck;
                Console.WriteLine("Check File Loaded " + fileName);
            }

            Rooms.InitializeRooms();
            foreach (string file in System.IO.Directory.GetFiles("./Assets/Rooms/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Rooms.RoomDict[fileName] = JsonConvert.DeserializeObject<Room>(contents);
                Room currentRoom = Rooms.RoomDict[fileName];
                var newList = currentRoom.neighbourRequirements.Select(s => s.Replace("Logic", "Logic.LogicFunctions")).ToList();
                currentRoom.neighbourRequirements = newList;
                Rooms.RoomDict[file] = currentRoom;
                Console.WriteLine("Room File Loaded " + fileName);
            }

            

            //Rooms.setupGraph();
            Console.WriteLine("Current Item Pool:");
           foreach (KeyValuePair<string, Check> checkList in Checks.CheckDict.ToList())
            {
                Check currentCheck = checkList.Value;
                Console.WriteLine(currentCheck.checkName + ": " + currentCheck.itemId);
            }
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }
    }
}
