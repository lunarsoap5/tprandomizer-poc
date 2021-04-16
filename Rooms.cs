using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;

namespace tprandomizer_poc_main
{
    public class Room
		{
			public string name { get; set;} //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
			public List<string> neighbours { get; set;} //Refers to the rooms of the same stage that can be accesed from this room
			public List<string> neighbourRequirements { get; set;} //List of list of requirements to enter each neighbouring room
            public string accessRequirements { get; set;}
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
            RoomDict.Add("Lanayru Ice Puzzle Cave", new Room());
            RoomDict.Add("Cave of Ordeals 01 11", new Room());
            RoomDict.Add("Cave of Ordeals 12 21", new Room());
            RoomDict.Add("Cave of Ordeals 22 31", new Room());
            RoomDict.Add("Cave of Ordeals 32 41", new Room());
            RoomDict.Add("Cave of Ordeals 42 50", new Room());
            RoomDict.Add("Eldin Long Cave", new Room());
            RoomDict.Add("Lake Hylia Long Cave", new Room());
            RoomDict.Add("Goron Stockcave", new Room());
            RoomDict.Add("Grotto 1 0", new Room());
            RoomDict.Add("Grotto 1 1", new Room());
            RoomDict.Add("Grotto 1 2", new Room());
            RoomDict.Add("Grotto 1 3", new Room());
            RoomDict.Add("Grotto 2 0", new Room());
            RoomDict.Add("Grotto 2 1", new Room());
            RoomDict.Add("Grotto 2 2", new Room());
            RoomDict.Add("Grotto 3 0", new Room());
            RoomDict.Add("Grotto 4 0", new Room());
            RoomDict.Add("Grotto 4 1", new Room());
            RoomDict.Add("Grotto 4 2", new Room());
            RoomDict.Add("Grotto 4 3", new Room());
            RoomDict.Add("Grotto 5 0", new Room());
            RoomDict.Add("Grotto 5 2", new Room());
            RoomDict.Add("Grotto 5 3", new Room());
            RoomDict.Add("Grotto 5 4", new Room());
            RoomDict.Add("South Faron Woods Cave", new Room());
            RoomDict.Add("Ordon Province", new Room());
            RoomDict.Add("South Faron Woods", new Room());
            RoomDict.Add("Faron Mist Area", new Room());
            RoomDict.Add("Faron Mist Cave", new Room());
            RoomDict.Add("North Faron Woods", new Room());
            RoomDict.Add("Kakariko Village", new Room());
            RoomDict.Add("Death Mountain Trail", new Room());
            RoomDict.Add("Death Mountain Volcano", new Room());
            RoomDict.Add("Zoras Domain", new Room());
            RoomDict.Add("Snowpeak Climb", new Room());
            RoomDict.Add("Snowpeak Summit", new Room());
            RoomDict.Add("Lake Hylia", new Room());
            RoomDict.Add("Castle Town", new Room());
            RoomDict.Add("Lost Woods", new Room());
            RoomDict.Add("Sacred Grove Master Sword", new Room());
            RoomDict.Add("Sacred Grove Temple of Time", new Room());
            RoomDict.Add("Bublin Camp", new Room());
            RoomDict.Add("Outside Arbiters Grounds", new Room());
            RoomDict.Add("Eldin Field", new Room());
            RoomDict.Add("Kakariko Gorge", new Room());
            RoomDict.Add("Faron Field", new Room());
            RoomDict.Add("Lanayru Field", new Room());
            RoomDict.Add("Lake Hylia Bridge", new Room());
            RoomDict.Add("Outside Castle Town West", new Room());
            RoomDict.Add("Outside Castle Town South", new Room());
            RoomDict.Add("Gerudo Desert", new Room());
            RoomDict.Add("Mirror Chamber", new Room());
            RoomDict.Add("Hidden Village", new Room());
            RoomDict.Add("Death Mountain Interiors", new Room());
            return;
        }

        public void deserializeRooms()
        {
            foreach (string file in System.IO.Directory.GetFiles("./Assets/Rooms/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Singleton.getInstance().Rooms.RoomDict[fileName] = JsonConvert.DeserializeObject<Room>(contents);
                Room currentRoom = Singleton.getInstance().Rooms.RoomDict[fileName];
                var newList = currentRoom.neighbourRequirements.Select(s => s.Replace("Logic", "Logic.LogicFunctions")).ToList();
                currentRoom.neighbourRequirements = newList;
                Singleton.getInstance().Rooms.RoomDict[fileName] = currentRoom;
                Console.WriteLine("Room File Loaded " + fileName);
            }
            return;
        }

        

        
    }
}