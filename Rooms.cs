using System;
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
			public List<string> neighbourRequirments { get; set;} //List of list of requirements to enter each neighbouring room
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
            RoomDict.Add("lakebed_temple_00_01", new Room());
            RoomDict.Add("lakebed_temple_02_03", new Room());
            RoomDict.Add("lakebed_temple_05", new Room());
            RoomDict.Add("lakebed_temple_06", new Room());
            RoomDict.Add("lakebed_temple_07", new Room());
            RoomDict.Add("lakebed_temple_08", new Room());
            RoomDict.Add("lakebed_temple_09", new Room());
            RoomDict.Add("lakebed_temple_10", new Room());
            RoomDict.Add("lakebed_temple_11", new Room());
            RoomDict.Add("lakebed_temple_12", new Room());
            RoomDict.Add("lakebed_temple_13", new Room());
            RoomDict.Add("deku_toad", new Room());
            RoomDict.Add("morpheel", new Room());
            RoomDict.Add("goron_mines_01", new Room());
            RoomDict.Add("goron_mines_03", new Room());
            RoomDict.Add("goron_mines_04_05", new Room());
            RoomDict.Add("goron_mines_06", new Room());
            RoomDict.Add("goron_mines_07", new Room());
            RoomDict.Add("goron_mines_09_17", new Room());
            RoomDict.Add("goron_mines_11", new Room());
            RoomDict.Add("goron_mines_12", new Room());
            RoomDict.Add("goron_mines_13", new Room());
            RoomDict.Add("goron_mines_14", new Room());
            RoomDict.Add("goron_mines_16", new Room());
            RoomDict.Add("fyrus", new Room());
            RoomDict.Add("dangoro", new Room());
            RoomDict.Add("forest_temple_00_01", new Room());
            RoomDict.Add("forest_temple_02", new Room());
            RoomDict.Add("forest_temple_03", new Room());
            RoomDict.Add("forest_temple_05", new Room());
            RoomDict.Add("forest_temple_07", new Room());
            RoomDict.Add("forest_temple_09", new Room());
            RoomDict.Add("forest_temple_10", new Room());
            RoomDict.Add("forest_temple_11", new Room());
            RoomDict.Add("forest_temple_12", new Room());
            RoomDict.Add("forest_temple_19", new Room());
            RoomDict.Add("forest_temple_22", new Room());
            RoomDict.Add("ook", new Room());
            RoomDict.Add("diababa", new Room());
            RoomDict.Add("temple_of_time_00", new Room());
            RoomDict.Add("temple_of_time_01", new Room());
            RoomDict.Add("temple_of_time_02", new Room());
            RoomDict.Add("temple_of_time_03", new Room());
            RoomDict.Add("temple_of_time_04", new Room());
            RoomDict.Add("temple_of_time_05", new Room());
            RoomDict.Add("temple_of_time_06", new Room());
            RoomDict.Add("temple_of_time_07", new Room());
            RoomDict.Add("temple_of_time_08", new Room());
            RoomDict.Add("darknut", new Room());
            RoomDict.Add("armogohma", new Room());
            RoomDict.Add("city_in_the_sky_00_16", new Room());
            RoomDict.Add("city_in_the_sky_01", new Room());
            RoomDict.Add("city_in_the_sky_02_03_14", new Room());
            RoomDict.Add("city_in_the_sky_04", new Room());
            RoomDict.Add("city_in_the_sky_05", new Room());
            RoomDict.Add("city_in_the_sky_06", new Room());
            RoomDict.Add("city_in_the_sky_07_lower", new Room());
            RoomDict.Add("city_in_the_sky_07_upper", new Room());
            RoomDict.Add("city_in_the_sky_08", new Room());
            RoomDict.Add("city_in_the_sky_10", new Room());
            RoomDict.Add("city_in_the_sky_11", new Room());
            RoomDict.Add("city_in_the_sky_12", new Room());
            RoomDict.Add("city_in_the_sky_13", new Room());
            RoomDict.Add("city_in_the_sky_15", new Room());
            RoomDict.Add("argorok", new Room());
            RoomDict.Add("aeralfos", new Room());
            RoomDict.Add("palace_of_twilight_00_01", new Room());
            RoomDict.Add("palace_of_twilight_02", new Room());
            RoomDict.Add("palace_of_twilight_04", new Room());
            RoomDict.Add("palace_of_twilight_05", new Room());
            RoomDict.Add("hyrule_castle_01", new Room());
            RoomDict.Add("hyrule_castle_02", new Room());
            RoomDict.Add("hyrule_castle_03", new Room());
            RoomDict.Add("hyrule_castle_04", new Room());
            RoomDict.Add("hyrule_castle_05", new Room());
            RoomDict.Add("hyrule_castle_06", new Room());
            RoomDict.Add("hyrule_castle_08", new Room());
            RoomDict.Add("hyrule_castle_09", new Room());
            RoomDict.Add("hyrule_castle_11", new Room());
            RoomDict.Add("hyrule_castle_12", new Room());
            RoomDict.Add("hyrule_castle_13", new Room());
            RoomDict.Add("hyrule_castle_14", new Room());
            RoomDict.Add("hyrule_castle_15", new Room());
            RoomDict.Add("ganondorf_castle", new Room());
            RoomDict.Add("arbiters_grounds_00", new Room());
            RoomDict.Add("arbiters_grounds_01", new Room());
            RoomDict.Add("arbiters_grounds_02_06_15", new Room());
            RoomDict.Add("arbiters_grounds_03", new Room());
            RoomDict.Add("arbiters_grounds_04", new Room());
            RoomDict.Add("arbiters_grounds_05", new Room());
            RoomDict.Add("arbiters_grounds_07", new Room());
            RoomDict.Add("arbiters_grounds_08", new Room());
            RoomDict.Add("arbiters_grounds_09", new Room());
            RoomDict.Add("arbiters_grounds_10", new Room());
            RoomDict.Add("arbiters_grounds_11", new Room());
            RoomDict.Add("arbiters_grounds_12", new Room());
            RoomDict.Add("arbiters_grounds_13", new Room());
            RoomDict.Add("arbiters_grounds_14", new Room());
            RoomDict.Add("arbiters_grounds_16", new Room());
            RoomDict.Add("stallord", new Room());
            RoomDict.Add("death_sword", new Room());
            RoomDict.Add("snowpeak_ruins_00_01_02_03", new Room());
            RoomDict.Add("snowpeak_ruins_04_E", new Room());
            RoomDict.Add("snowpeak_ruins_04_W", new Room());
            RoomDict.Add("snowpeak_ruins_05_lower", new Room());
            RoomDict.Add("snowpeak_ruins_05_upper", new Room());
            RoomDict.Add("snowpeak_ruins_06", new Room());
            RoomDict.Add("snowpeak_ruins_07", new Room());
            RoomDict.Add("snowpeak_ruins_08", new Room());
            RoomDict.Add("snowpeak_ruins_09", new Room());
            RoomDict.Add("snowpeak_ruins_11", new Room());
            RoomDict.Add("snowpeak_ruins_13", new Room());
            RoomDict.Add("blizzeta", new Room());
            RoomDict.Add("darkhammer", new Room());
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
    }
}