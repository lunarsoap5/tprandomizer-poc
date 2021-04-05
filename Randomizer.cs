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

namespace tprandomizer_poc_main
{ 
    public class Randomizer
    {
        LogicFunctions Logic = new LogicFunctions();
        public void start()
        {
            Singleton.getInstance().Checks.InitializeChecks();

            Singleton.getInstance().Rooms.InitializeRooms();
            
            Singleton.getInstance().Items.generateItemPool();
            /*foreach (KeyValuePair<string, Room> roomList in Singleton.getInstance().Rooms.RoomDict.ToList())
            {
                var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
                Room currentRoom = roomList.Value;
                Console.WriteLine("Room requirements for room: " + currentRoom.name);
                
                foreach (var requirement in currentRoom.neighbourRequirements)
                {
                    var now = CSharpScript.EvaluateAsync(requirement, options).Result;
                    Console.WriteLine("    " + now);
                }
                
            }*/
            Room startingRoom = Singleton.getInstance().Rooms.setupGraph();
            placeRequiredItems(startingRoom);

            
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }

        void startOver(Room startingRoom)
        {
            Console.WriteLine("Starting Over.");
            Singleton.getInstance().Items.nbSkybooksPlaced = 0;
            for (int i = 0; i< Singleton.getInstance().Items.PlacedImportantItems.Count(); i++)
            {
                Singleton.getInstance().Items.heldItems.Add(Singleton.getInstance().Items.PlacedImportantItems[i]);
            }
            Singleton.getInstance().Items.PlacedImportantItems.Clear();
            //empty all checks of their items  

            placeRequiredItems(startingRoom);
        }

        void placeRequiredItems(Room startingRoom)
        {
            Random rnd = new Random();
            List<string> availableChecks = new List<string>();
            availableChecks = listAllAvailableChecks(startingRoom);
            Item itemToPlace = Singleton.getInstance().Items.verifyItem(Singleton.getInstance().Items.heldItems[rnd.Next(Singleton.getInstance().Items.heldItems.Count()-1)]);
            if (availableChecks.Count <= 0)
            {
                Console.WriteLine("No checks available for randomization....");
            }
            string checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
            
            while (Singleton.getInstance().Items.heldItems.Count() > 0 && availableChecks.Any())
            {
                while (!Singleton.getInstance().Checks.checkIfItemNotNeededToReachCheck(itemToPlace, checkToReciveItem, startingRoom))
                {
                    checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
                }
                
                Singleton.getInstance().Checks.placeItemInCheck(itemToPlace,checkToReciveItem);
                
                availableChecks = listAllAvailableChecks(startingRoom);
                itemToPlace = Singleton.getInstance().Items.verifyItem(Singleton.getInstance().Items.heldItems[rnd.Next(Singleton.getInstance().Items.heldItems.Count()-1)]);
                checkToReciveItem = availableChecks[rnd.Next(availableChecks.Count()-1)];
            }
            if (Singleton.getInstance().Items.heldItems.Count() > 0)
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
                        roomChecks.Add(currentCheck.ToString());
                    }
                }
                Logic.checkBossFlags(roomsToExplore[0]);
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            return roomChecks;
        }    
    }
}