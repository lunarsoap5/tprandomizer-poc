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
    public struct Room
		{
			public string name { get; set;} //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
			public List<string> neighbours { get; set;} //Refers to the rooms of the same stage that can be accesed from this room
			public List<string> neighbourRequirements { get; set;} //List of list of requirements to enter each neighbouring room
			public bool isStartingRoom { get; set;} //Defines if it is the stage you start the game in
			public List<string> checks { get; set;} //Checks contained inside the room
			public bool visited { get; set;}
			public string region { get; set;}
		}
    
    public class RoomFunctions
    {
        
        public Dictionary<string, Room> RoomDict = new Dictionary<string, Room>();
        public void InitializeRooms()
        {
            
            RoomDict.Add("Lakebed Temple 00 01", new Room());
            RoomDict.Add("Lakebed Temple 02 03", new Room());
            RoomDict.Add("Lakebed Temple 05", new Room());
            RoomDict.Add("Lakebed Temple 06", new Room());
            RoomDict.Add("Lakebed Temple 07", new Room());
            RoomDict.Add("Lakebed Temple 08", new Room());
            RoomDict.Add("Lakebed Temple 09", new Room());
            RoomDict.Add("Lakebed Temple 10", new Room());
            RoomDict.Add("Lakebed Temple 11", new Room());
            RoomDict.Add("Lakebed Temple 12", new Room());
            RoomDict.Add("Lakebed Temple 13", new Room());
            RoomDict.Add("Deku Toad", new Room());
            RoomDict.Add("Morpheel", new Room());
            RoomDict.Add("Goron Mines 01", new Room());
            RoomDict.Add("Goron Mines 03", new Room());
            RoomDict.Add("Goron Mines 04 05", new Room());
            RoomDict.Add("Goron Mines 06", new Room());
            RoomDict.Add("Goron Mines 07", new Room());
            RoomDict.Add("Goron Mines 09 17", new Room());
            RoomDict.Add("Goron Mines 11", new Room());
            RoomDict.Add("Goron Mines 12", new Room());
            RoomDict.Add("Goron Mines 13", new Room());
            RoomDict.Add("Goron Mines 14", new Room());
            RoomDict.Add("Goron Mines 16", new Room());
            RoomDict.Add("Fyrus", new Room());
            RoomDict.Add("Dangoro", new Room());
            RoomDict.Add("Forest Temple 00 01", new Room());
            RoomDict.Add("Forest Temple 02", new Room());
            RoomDict.Add("Forest Temple 03", new Room());
            RoomDict.Add("Forest Temple 05", new Room());
            RoomDict.Add("Forest Temple 07", new Room());
            RoomDict.Add("Forest Temple 09", new Room());
            RoomDict.Add("Forest Temple 10", new Room());
            RoomDict.Add("Forest Temple 11", new Room());
            RoomDict.Add("Forest Temple 12", new Room());
            RoomDict.Add("Forest Temple 19", new Room());
            RoomDict.Add("Forest Temple 22", new Room());
            RoomDict.Add("Ook", new Room());
            RoomDict.Add("Diababa", new Room());
            RoomDict.Add("Temple of Time 00", new Room());
            RoomDict.Add("Temple of Time 01", new Room());
            RoomDict.Add("Temple of Time 02", new Room());
            RoomDict.Add("Temple of Time 03", new Room());
            RoomDict.Add("Temple of Time 04", new Room());
            RoomDict.Add("Temple of Time 05", new Room());
            RoomDict.Add("Temple of Time 06", new Room());
            RoomDict.Add("Temple of Time 07", new Room());
            RoomDict.Add("Temple of Time 08", new Room());
            RoomDict.Add("Darknut", new Room());
            RoomDict.Add("Armogohma", new Room());
            RoomDict.Add("City in The Sky 00 16", new Room());
            RoomDict.Add("City in The Sky 01", new Room());
            RoomDict.Add("City in The Sky 02 03 14", new Room());
            RoomDict.Add("City in The Sky 04", new Room());
            RoomDict.Add("City in The Sky 05", new Room());
            RoomDict.Add("City in The Sky 06", new Room());
            RoomDict.Add("City in The Sky 07 Lower", new Room());
            RoomDict.Add("City in The Sky 07 Upper", new Room());
            RoomDict.Add("City in The Sky 08", new Room());
            RoomDict.Add("City in The Sky 10", new Room());
            RoomDict.Add("City in The Sky 11", new Room());
            RoomDict.Add("City in The Sky 12", new Room());
            RoomDict.Add("City in The Sky 13", new Room());
            RoomDict.Add("City in The Sky 15", new Room());
            RoomDict.Add("Argorok", new Room());
            RoomDict.Add("Aeralfos", new Room());
            RoomDict.Add("Palace of Twilight 00 01", new Room());
            RoomDict.Add("Palace of Twilight 02", new Room());
            RoomDict.Add("Palace of Twilight 04", new Room());
            RoomDict.Add("Palace of Twilight 05", new Room());
            RoomDict.Add("Palace of Twilight 07", new Room());
            RoomDict.Add("Palace of Twilight 08", new Room());
            RoomDict.Add("Palace of Twilight 09", new Room());
            RoomDict.Add("Palace of Twilight 11", new Room());
            RoomDict.Add("Phantom Zant 1", new Room());
            RoomDict.Add("Phantom Zant 2", new Room());
            RoomDict.Add("Zant", new Room());
            RoomDict.Add("Hyrule Castle 01", new Room());
            RoomDict.Add("Hyrule Castle 02", new Room());
            RoomDict.Add("Hyrule Castle 03", new Room());
            RoomDict.Add("Hyrule Castle 04", new Room());
            RoomDict.Add("Hyrule Castle 05", new Room());
            RoomDict.Add("Hyrule Castle 06", new Room());
            RoomDict.Add("Hyrule Castle 08", new Room());
            RoomDict.Add("Hyrule Castle 09", new Room());
            RoomDict.Add("Hyrule Castle 11", new Room());
            RoomDict.Add("Hyrule Castle 12", new Room());
            RoomDict.Add("Hyrule Castle 13", new Room());
            RoomDict.Add("Hyrule Castle 14", new Room());
            RoomDict.Add("Hyrule Castle 15", new Room());
            RoomDict.Add("Ganondorf Castle", new Room());
            RoomDict.Add("Arbiters Grounds 00", new Room());
            RoomDict.Add("Arbiters Grounds 01", new Room());
            RoomDict.Add("Arbiters Grounds 02 06 15", new Room());
            RoomDict.Add("Arbiters Grounds 03", new Room());
            RoomDict.Add("Arbiters Grounds 04", new Room());
            RoomDict.Add("Arbiters Grounds 05", new Room());
            RoomDict.Add("Arbiters Grounds 07", new Room());
            RoomDict.Add("Arbiters Grounds 08", new Room());
            RoomDict.Add("Arbiters Grounds 09", new Room());
            RoomDict.Add("Arbiters Grounds 10", new Room());
            RoomDict.Add("Arbiters Grounds 11", new Room());
            RoomDict.Add("Arbiters Grounds 12", new Room());
            RoomDict.Add("Arbiters Grounds 13", new Room());
            RoomDict.Add("Arbiters Grounds 14", new Room());
            RoomDict.Add("Arbiters Grounds 16", new Room());
            RoomDict.Add("Stallord", new Room());
            RoomDict.Add("Death Sword", new Room());
            RoomDict.Add("Snowpeak Ruins 00 01 02 03", new Room());
            RoomDict.Add("Snowpeak Ruins 04 E", new Room());
            RoomDict.Add("Snowpeak Ruins 04 W", new Room());
            RoomDict.Add("Snowpeak Ruins 05 Lower", new Room());
            RoomDict.Add("Snowpeak Ruins 05 Upper", new Room());
            RoomDict.Add("Snowpeak Ruins 06", new Room());
            RoomDict.Add("Snowpeak Ruins 07", new Room());
            RoomDict.Add("Snowpeak Ruins 08", new Room());
            RoomDict.Add("Snowpeak Ruins 09", new Room());
            RoomDict.Add("Snowpeak Ruins 11", new Room());
            RoomDict.Add("Snowpeak Ruins 13", new Room());
            RoomDict.Add("Blizzeta", new Room());
            RoomDict.Add("Darkhammer", new Room());
            RoomDict.Add("lanayru_ice_puzzle_cave", new Room());
            RoomDict.Add("cave_of_ordeals_01_11", new Room());
            RoomDict.Add("cave_of_ordeals_12_21", new Room());
            RoomDict.Add("cave_of_ordeals_22_31", new Room());
            RoomDict.Add("cave_of_ordeals_32_41", new Room());
            RoomDict.Add("cave_of_ordeals_42_50", new Room());
            RoomDict.Add("eldin_long_cave", new Room());
            RoomDict.Add("lake_hylia_long_cave", new Room());
            RoomDict.Add("goron_stockcave", new Room());
            RoomDict.Add("grotto_1_0", new Room());
            RoomDict.Add("grotto_1_1", new Room());
            RoomDict.Add("grotto_1_2", new Room());
            RoomDict.Add("grotto_1_3", new Room());
            RoomDict.Add("grotto_2_0", new Room());
            RoomDict.Add("grotto_2_1", new Room());
            RoomDict.Add("grotto_2_2", new Room());
            RoomDict.Add("grotto_3_0", new Room());
            RoomDict.Add("grotto_4_0", new Room());
            RoomDict.Add("grotto_4_1", new Room());
            RoomDict.Add("grotto_4_2", new Room());
            RoomDict.Add("grotto_4_3", new Room());
            RoomDict.Add("grotto_5_0", new Room());
            RoomDict.Add("grotto_5_2", new Room());
            RoomDict.Add("grotto_5_3", new Room());
            RoomDict.Add("grotto_5_4", new Room());
            RoomDict.Add("south_faron_woods_cave", new Room());
            RoomDict.Add("ordon_province", new Room());
            RoomDict.Add("south_faron_woods", new Room());
            RoomDict.Add("faron_mist_area", new Room());
            RoomDict.Add("faron_mist_cave", new Room());
            RoomDict.Add("north_faron_woods", new Room());
            RoomDict.Add("kakariko_village", new Room());
            RoomDict.Add("death_mountain_trail", new Room());
            RoomDict.Add("death_mountain_volcano", new Room());
            RoomDict.Add("zoras_domain", new Room());
            RoomDict.Add("snowpeak_climb", new Room());
            RoomDict.Add("snowpeak_summit", new Room());
            RoomDict.Add("lake_hylia", new Room());
            RoomDict.Add("castle_town", new Room());
            RoomDict.Add("lost_woods", new Room());
            RoomDict.Add("sacred_grove_master_sword", new Room());
            RoomDict.Add("sacred_grove_temple_of_time", new Room());
            RoomDict.Add("bublin_camp", new Room());
            RoomDict.Add("outside_arbiters_grounds", new Room());
            RoomDict.Add("eldin_field", new Room());
            RoomDict.Add("kakariko_gorge", new Room());
            RoomDict.Add("faron_field", new Room());
            RoomDict.Add("lanayru_field", new Room());
            RoomDict.Add("lake_hylia_bridge", new Room());
            RoomDict.Add("outside_castle_town_west", new Room());
            RoomDict.Add("outside_castle_town_south", new Room());
            RoomDict.Add("gerudo_desert", new Room());
            RoomDict.Add("mirror_chamber", new Room());
            RoomDict.Add("hidden_village", new Room());
            RoomDict.Add("death_mountain_interiors", new Room());

            
        }

        public void setupGraph()
        {
            resetAllRoomsVisited();
            Room startingRoom = RoomDict["ordon_province"];
            startingRoom.isStartingRoom = true;
            RoomDict["ordon_province"] = startingRoom;
        }

        public void resetAllRoomsVisited()
        {
            foreach (KeyValuePair<string, Room> roomList in RoomDict.ToList())
            {
                Room currentRoom = roomList.Value;
                currentRoom.visited = false;
                RoomDict[roomList.Key] = currentRoom;
            }
        }

        public List<string> listAllAvailableChecks(Room startingRoom)
        {
            resetAllRoomsVisited();
            CheckFunctions Checks = new CheckFunctions();
            List<string> checks = new List<string>();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                
            while (roomsToExplore.Count() > 0)
            {
                for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                {
                    //Create reference to the dictionary entry of the room we are evaluating
                    Room currentNeighbour = RoomDict[roomsToExplore[0].neighbours[i]];
                    //Parse the neighbour's requirements to find out if we can access it
                    var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(roomsToExplore[0].neighbourRequirements[i], options).Result;
                    //If you can access the neighbour and it hasnt been visited yet.
                    if ((((bool)areNeighbourRequirementsMet == true)) &&  (currentNeighbour.visited == false))
                    {
                        currentNeighbour.visited = true;
                        roomsToExplore.Add(currentNeighbour);
                    }
                }
                for (int i = 0; i < roomsToExplore[0].checks.Count(); i++)
                {
                    //Create reference to the dictionary entry of the check whose logic we are evaluating
                    Check currentCheck = Checks.CheckDict[roomsToExplore[0].checks[i]];
                    //Parse the requirements to see if we can get the check
                    var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    //Confirms that we can get the check and checks to see if an item was placed in it.
                    if (((bool)areCheckRequirementsMet == true) && currentCheck.itemWasPlaced == false)
                    {
                        checks.Add(currentCheck.ToString());
                    }
                }
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            return checks;
        }
    }
}