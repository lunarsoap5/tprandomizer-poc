using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using Logic;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace tprandomizer_poc_main
{ 
    public class Randomizer
    {
        LogicFunctions Logic = new LogicFunctions();
        public void start()
        {
            Singleton.getInstance().Checks.InitializeChecks();
            Singleton.getInstance().Checks.deserializeChecks();

            Singleton.getInstance().Rooms.InitializeRooms();
            Singleton.getInstance().Rooms.deserializeRooms();
            
            Singleton.getInstance().Items.generateItemPool();

            Room startingRoom = Singleton.getInstance().Rooms.setupGraph();
            placeRequiredItems(startingRoom);

            
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }

        void startOver(Room startingRoom)
        {
            Console.WriteLine("Starting Over.");
            ItemFunctions.nbSkybooksPlaced = 0;
            Singleton.getInstance().Items.generateItemPool();
            foreach (var item in Singleton.getInstance().Items.PlacedImportantItems)
            {
                Singleton.getInstance().Items.ImportantItems.Add(item);
            }
            Singleton.getInstance().Items.PlacedImportantItems.Clear();
            Singleton.getInstance().Checks.deserializeChecks();

            placeRequiredItems(startingRoom);
        }

        void placeRequiredItems(Room startingRoom)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            Item itemToPlace;
            string checkToReciveItem;
            Singleton.getInstance().Items.ItemsToBeRandomized = Singleton.getInstance().Items.ImportantItems;

            foreach(var item in Singleton.getInstance().Items.ImportantItems)
            {
                Console.WriteLine(item);
            }
            while (Singleton.getInstance().Items.ItemsToBeRandomized.Count() > 0)
            {
                itemToPlace = Singleton.getInstance().Items.verifyItem(Singleton.getInstance().Items.ItemsToBeRandomized[rnd.Next(Singleton.getInstance().Items.ItemsToBeRandomized.Count()-1)]);
                Console.WriteLine("Item to place: " + itemToPlace);
                Singleton.getInstance().Items.heldItems.Remove(itemToPlace);
                Singleton.getInstance().Items.ItemsToBeRandomized.Remove(itemToPlace);
                availableChecks = listAllAvailableChecks(startingRoom);
                
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];

                
                while (!Singleton.getInstance().Checks.checkIfItemNotNeededToReachCheck(itemToPlace, checkToReciveItem, startingRoom))
                {
                    checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                }
                Singleton.getInstance().Items.heldItems.Add(itemToPlace);
                Singleton.getInstance().Checks.placeItemInCheck(itemToPlace,checkToReciveItem);

                availableChecks.Remove(checkToReciveItem);
            }
            if (Singleton.getInstance().Items.ItemsToBeRandomized.Count() > 0)
            {//no more available checks and still items to place, starting over
                //failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
                startOver(startingRoom);
            }
        }
        
        public List<string> listAllAvailableChecks(Room startingRoom)
        {
            Singleton.getInstance().Rooms.resetAllRoomsVisited();
            List<string> roomChecks = new List<string>();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
                
            while (roomsToExplore.Count() > 0)
            {
                Console.WriteLine("Currently exploring: " + roomsToExplore[0].name);
                for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                {
                    //Create reference to the dictionary entry of the room we are evaluating
                    
                    //Parse the neighbour's requirements to find out if we can access it
                    var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(roomsToExplore[0].neighbourRequirements[i], options).Result;
                    //If you can access the neighbour and it hasnt been visited yet.
                    if ((((bool)areNeighbourRequirementsMet == true)) &&  (Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]].visited == false))
                    {
                        Room currentNeighbour = Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                        currentNeighbour.visited = true;
                        Console.WriteLine("Neighbour: " + currentNeighbour.name + " added to room list.");
                        roomsToExplore.Add(currentNeighbour);
                    }
                }
                for (int i = 0; i < roomsToExplore[0].checks.Count(); i++)
                {
                    //Create reference to the dictionary entry of the check whose logic we are evaluating
                    Check currentCheck;
                    if (!Singleton.getInstance().Checks.CheckDict.TryGetValue(roomsToExplore[0].checks[i], out currentCheck)) 
                    {
                        if (roomsToExplore[0].checks[i].ToString() == "")
                        {
                            Console.WriteLine("Room has no checks, continuing on....");
                            break;
                        }
                        Console.WriteLine("Check: " + roomsToExplore[0].checks[i] + " does not exist.");
                    }
                    //Parse the requirements to see if we can get the check
                    var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    //Confirms that we can get the check and checks to see if an item was placed in it.
                    if (((bool)areCheckRequirementsMet == true) && currentCheck.itemWasPlaced == false)
                    {
                        roomChecks.Add(currentCheck.checkName);
                    }
                }
                Logic.checkBossFlags(roomsToExplore[0]);
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            return roomChecks;
        }  
    }
}