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
    public struct Check
    {
        public string checkName { set; get;} //the common name for the check this can be used in the randomizer to identify the check."
        public string requirements { get; set;} //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
        public string hash { get; set;} //the fletcher hash that will be compared to on stage load
        public bool isExcluded { get; set;} //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
        public List<string> category { get; set;} //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
        public Item itemId { get; set;} //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
        public bool itemWasPlaced { get; set;} //Identifies if we already placed an item on this check.
    }

    public class CheckFunctions
    {
        
        //RoomFunctions Rooms = new RoomFunctions();
        ItemFunctions Items = new ItemFunctions();
        RoomFunctions Rooms = new RoomFunctions();
        public Dictionary<string, Check> CheckDict = new Dictionary<string, Check>();
        public void InitializeChecks()
        {

            CheckDict.Add("Gift_From_Rusl", new Check());
            CheckDict.Add("South_Faron_Cave_Chest", new Check());
            CheckDict.Add("Faron_Mist_Cave_Open_Chest", new Check());
            CheckDict.Add("Faron_Mist_Cave_Lantern_Chest", new Check());
            CheckDict.Add("North_Faron_Woods_Deku_Baba_Chest", new Check());
            CheckDict.Add("Links_Basement_Chest", new Check());
            CheckDict.Add("Forest_Temple_Entrance_Vine_Chest", new Check());
            CheckDict.Add("Forest_Temple_Central_Chest_Behind_Stairs", new Check());
            CheckDict.Add("Forest_Temple_Central_North_Chest", new Check());
            CheckDict.Add("Forest_Temple_Windless_Bridge_Chest", new Check());
            CheckDict.Add("Forest_Temple_Second_Monkey_Under_Bridge_Chest", new Check());
            CheckDict.Add("Forest_Temple_Totem_Pole_Chest", new Check());
            CheckDict.Add("Forest_Temple_West_Tile_Worm_Room_Vines_Chest", new Check());
            CheckDict.Add("Forest_Temple_West_Deku_Like_Chest", new Check());
            CheckDict.Add("Forest_Temple_West_Tile_Worm_Chest_Behind_Stairs", new Check());
            CheckDict.Add("Forest_Temple_Central_Chest_Hanging_From_Web", new Check());
            CheckDict.Add("Forest_Temple_Big_Key_Chest", new Check());
            CheckDict.Add("Forest_Temple_East_Water_Cave_Chest", new Check());
            CheckDict.Add("Forest_Temple_North_Deku_Like_Chest", new Check());
            CheckDict.Add("Forest_Temple_East_Tile_Worm_Chest", new Check());
            CheckDict.Add("Kakariko_Inn_Chest", new Check());
            CheckDict.Add("Wrestling_With_Bo", new Check());
            CheckDict.Add("Goron_Mines_Entrance_Chest", new Check());
            CheckDict.Add("Goron_Mines_Main_Magnet_Room_Bottom_Chest", new Check());
            CheckDict.Add("Goron_Mines_Gor_Amato_Chest", new Check());
            CheckDict.Add("Goron_Mines_Gor_Amato_Small_Chest", new Check());
            CheckDict.Add("Goron_Mines_Magnet_Maze_Chest", new Check());
            CheckDict.Add("Goron_Mines_Crystal_Switch_Room_Underwater_Chest", new Check());
            CheckDict.Add("Goron_Mines_Crystal_Switch_Room_Small_Chest", new Check());
            CheckDict.Add("Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest", new Check());
            CheckDict.Add("Goron_Mines_Outside_Beamos_Chest", new Check());
            CheckDict.Add("Goron_Mines_Gor_Ebizo_Chest", new Check());
            CheckDict.Add("Goron_Mines_Chest_Before_Dangoro", new Check());
            CheckDict.Add("Goron_Mines_Dangoro_Chest", new Check());
            CheckDict.Add("Goron_Mines_Beamos_Room_Chest", new Check());
            CheckDict.Add("Goron_Mines_Gor_Liggs_Chest", new Check());
            CheckDict.Add("Goron_Mines_Main_Magnet_Room_Top_Chest", new Check());
            CheckDict.Add("Goron_Mines_Outside_Underwater_Chest", new Check());
            CheckDict.Add("Eldin_Spring_Underwater_Chest", new Check());
            CheckDict.Add("Kakariko_Graveyard_Lantern_Chest", new Check());
            CheckDict.Add("Kakariko_Watchtower_Chest", new Check());
            CheckDict.Add("Kakariko_Watchtower_Alcove_Chest", new Check());
            CheckDict.Add("Eldin_Field_Bomb_Rock_Chest", new Check());
            CheckDict.Add("Zoras_Domain_Chest_By_Mother_and_Child_Isles", new Check());
            CheckDict.Add("Zoras_Domain_Chest_Behind_Waterfall", new Check());
            CheckDict.Add("Lake_Hylia_Underwater_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Lobby_Left_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Lobby_Rear_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Stalactite_Room_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Central_Room_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Central_Room_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Second_Floor_Southwest_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Second_Floor_Southeast_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Water_Supply_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Before_Deku_Toad_Alcove_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Deku_Toad_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Chandelier_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Water_Supply_Clawshot_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Central_Room_Center_Spire_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Lower_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Water_Supply_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Water_Supply_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Second_Floor_Central_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Second_Floor_Northeast_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_West_Second_Floor_Southeast_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Big_Key_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_Underwater_Maze_Small_Chest", new Check());
            CheckDict.Add("Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest", new Check());
            CheckDict.Add("Sacred_Grove_Deku_Baba_Grotto_Chest", new Check());
            CheckDict.Add("West_Hyrule_Field_Helmasaur_Grotto_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_First_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Second_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Third_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Fourth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Fifth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Sixth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Seventh_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Eighth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Ninth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Tenth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Eleventh_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Twelfth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Thirtennth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_Fourteenth_Chest", new Check());
            CheckDict.Add("Lake_Lantern_Cave_End_Lantern_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Water_Toadpoli_Grotto_Chest", new Check());
            CheckDict.Add("Outside_Lanayru_Spring_Left_Statue_Chest", new Check());
            CheckDict.Add("Outside_Lanayru_Spring_Right_Statue_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_Underwater_Left_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_Underwater_Right_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_Back_Room_Left_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_Back_Room_Right_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_Back_Room_Lantern_Chest", new Check());
            CheckDict.Add("Flight_By_Fowl_Top_Platform_Chest", new Check());
            CheckDict.Add("Flight_By_Fowl_Second_Platform_Chest", new Check());
            CheckDict.Add("Flight_By_Fowl_Third_Platform_Chest", new Check());
            CheckDict.Add("Flight_By_Fowl_Fourth_Platform_Chest", new Check());
            CheckDict.Add("Flight_By_Fowl_Fifth_Platform_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Shell_Blade_Grotto_Chest", new Check());
            CheckDict.Add("Zoras_Domain_Light_All_Torches_Chest", new Check());
            CheckDict.Add("Zoras_Domain_Extinguish_All_Torches_Chest", new Check());
            CheckDict.Add("Lanayru_Field_Skulltula_Grotto_Chest", new Check());
            CheckDict.Add("Lanayru_Field_Behind_Gate_Underwater_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Bridge_Vines_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Bridge_Bubble_Grotto_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Bridge_Cliff_Chest", new Check());
            CheckDict.Add("Faron_Field_Bridge_Chest", new Check());
            CheckDict.Add("Faron_Field_Corner_Grotto_Right_Chest", new Check());
            CheckDict.Add("Faron_Field_Corner_Grotto_Rear_Chest", new Check());
            CheckDict.Add("Faron_Field_Corner_Grotto_Left_Chest", new Check());
            CheckDict.Add("Death_Mountain_Alcove_Chest", new Check());
            CheckDict.Add("Goron_Mines_Outside_Clawshot_Chest", new Check());
            CheckDict.Add("Eldin_Lantern_Cave_First_Chest", new Check());
            CheckDict.Add("Eldin_Lantern_Cave_Lantern_Chest", new Check());
            CheckDict.Add("Eldin_Lantern_Cave_Second_Chest", new Check());
            CheckDict.Add("Outside_South_Castle_Town_Field_Tightrope_Chest", new Check());
            CheckDict.Add("Outside_South_Castle_Town_Tetike_Grotto_Chest", new Check());
            CheckDict.Add("Eldin_Field_Bomskit_Grotto_Left_Chest", new Check());
            CheckDict.Add("Eldin_Field_Bomskit_Grotto_Lantern_Chest", new Check());
            CheckDict.Add("Eldin_Field_Water_Bomb_Fish_Grotto_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Skulltula_Grotto_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Peahat_Ledge_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_East_Canyon_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Lone_Small_Chest", new Check());
            CheckDict.Add("Eldin_Stockcave_Upper_Chest", new Check());
            CheckDict.Add("Eldin_Stockcave_Lantern_Chest", new Check());
            CheckDict.Add("Eldin_Stockcave_Lowest_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_West_Canyon_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Poe_Grotto_Lantern_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Northeast_Chest_Behind_Gates", new Check());
            CheckDict.Add("Gerudo_Desert_South_Chest_Behind_Wooden_Gates", new Check());
            CheckDict.Add("Gerudo_Desert_Campfire_North_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Campfire_East_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Campfire_West_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Northwest_Chest_Behind_Gates", new Check());
            CheckDict.Add("North_Small_Chest_Before_Bublin_Camp", new Check());
            CheckDict.Add("Bublin_Camp_First_Chest_Under_Tower_at_Entrance", new Check());
            CheckDict.Add("Bublin_Camp_Small_Chest_in_Back_of_Camp", new Check());
            CheckDict.Add("Outside_Arbiters_Grounds_Lantern_Chest", new Check());
            CheckDict.Add("Arbiters Grounds Lobby Chest", new Check());
            CheckDict.Add("Arbiters Grounds East Lower Turnable Redead Chest", new Check());
            CheckDict.Add("Arbiters Grounds Torch Room East Chest", new Check());
            CheckDict.Add("Arbiters Grounds Torch Room West Chest", new Check());
            CheckDict.Add("Arbiters Grounds East Upper Turnable Chest", new Check());
            CheckDict.Add("Arbiters Grounds East Upper Turnable Redead Chest", new Check());
            CheckDict.Add("Arbiters Grounds Ghoul Rat Room Chest", new Check());
            CheckDict.Add("Arbiters Grounds West Small Chest Behind Block", new Check());
            CheckDict.Add("Arbiters Grounds West Chandelier Chest", new Check());
            CheckDict.Add("Arbiters Grounds West Stalfos North Chest", new Check());
            CheckDict.Add("Arbiters Grounds West Stalfos Southeast Chest", new Check());
            CheckDict.Add("Arbiters Grounds North Turning Room Chest", new Check());
            CheckDict.Add("Arbiters Grounds Death Sword Chest", new Check());
            CheckDict.Add("Arbiters Grounds Spinner Room First Small Chest", new Check());
            CheckDict.Add("Arbiters Grounds Spinner Room Second Small Chest", new Check());
            CheckDict.Add("Arbiters Grounds Spinner Room Lower Central Small Chest", new Check());
            CheckDict.Add("Arbiters Grounds Spinner Room Stalfos Alcove Chest", new Check());
            CheckDict.Add("Arbiters Grounds Spinner Room Lower North Chest", new Check());
            CheckDict.Add("Arbiters Grounds Big Key Chest", new Check());
            CheckDict.Add("Lanayru_Field_Spinner_Track_Chest", new Check());
            CheckDict.Add("Lanayru_Field_Stalfos_Grotto_Right_Small_Chest", new Check());
            CheckDict.Add("Lanayru_Field_Stalfos_Grotto_Left_Small_Chest", new Check());
            CheckDict.Add("Lanayru_Field_Stalfos_Grotto_Stalfos_Chest", new Check());
            CheckDict.Add("Outside_South_Castle_Town_Fountain_Chest", new Check());
            CheckDict.Add("Ordon_Ranch_Grotto_Lantern_Chest", new Check());
            CheckDict.Add("Faron_Mist_Stump_Chest", new Check());
            CheckDict.Add("Faron_Mist_North_Chest", new Check());
            CheckDict.Add("Faron_Mist_South_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_West_Courtyard_Buried_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_East_Courtyard_Buried_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Ordon_Pumpkin_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_East_Courtyard_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Wooden_Beam_Central_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Wooden_Beam_Northwest_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Courtyard_Central_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Chest_After_Darkhammer", new Check());
            CheckDict.Add("Snowpeak_Ruins_Broken_Floor_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Lobby_Chandelier_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Lobby_West_Armor_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Lobby_East_Armor_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Northeast_Chandelier_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_West_Cannon_Room_Central_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_West_Cannon_Room_Corner_Chest", new Check());
            CheckDict.Add("Snowpeak_Ruins_Chapel_Chest", new Check());
            CheckDict.Add("Snowpeak_Cave_Ice_Lantern_Chest", new Check());
            CheckDict.Add("Snowpeak_Freezard_Grotto_Chest", new Check());
            CheckDict.Add("Lanayru_Ice_Block_Puzzle_Cave_Chest", new Check());
            CheckDict.Add("Lost_Woods_Lantern_Chest", new Check());
            CheckDict.Add("Sacred_Grove_Spinner_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Lobby_Lantern_Chest", new Check());
            CheckDict.Add("Temple_of_Time_First_Staircase_Gohma_Gate_Chest", new Check());
            CheckDict.Add("Temple_of_Time_First_Staircase_Window_Chest", new Check());
            CheckDict.Add("Temple_of_Time_First_Staircase_Armos_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Statue_Throws_Room_East_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Moving_Wall_Beamos_Room_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Scales_Gohma_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Gilloutine_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Chest_Before_Midboss", new Check());
            CheckDict.Add("Temple_of_Time_Darknut_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Scales_Upper_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Big_Key_Chest_Room_Upper_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Big_Key_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Statue_Throws_Room_North_Chest", new Check());
            CheckDict.Add("Temple_of_Time_Statue_Throws_Room_Statue_Chest", new Check());
            CheckDict.Add("Sacred_Grove_Past_Owl_Statue_Chest", new Check());
            CheckDict.Add("Doctors_Office_Balcony_Chest", new Check());
            CheckDict.Add("Bridge_of_Eldin_Owl_Statue_Chest", new Check());
            CheckDict.Add("Kakariko_Gorge_Owl_Statue_Chest", new Check());
            CheckDict.Add("Hyrule_Field_Ampitheater_Owl_Statue_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Bridge_Owl_Statue_Chest", new Check());
            CheckDict.Add("Faron_Woods_Owl_Statue_Chest", new Check());
            CheckDict.Add("Gerudo_Desert_Owl_Statue_Chest", new Check());
            CheckDict.Add("City in The Sky Underwater West Chest", new Check());
            CheckDict.Add("City in The Sky Underwater East Chest", new Check());
            CheckDict.Add("City in The Sky West Wing First Chest", new Check());
            CheckDict.Add("City in The Sky East First Wing Chest After Fans", new Check());
            CheckDict.Add("City in The Sky East Tile Worm Small Chest", new Check());
            CheckDict.Add("City in The Sky East Wing After Dinalfos Alcove Chest", new Check());
            CheckDict.Add("City in The Sky East Wing After Dinalfos Ledge Chest", new Check());
            CheckDict.Add("City in The Sky Aeralfos Chest", new Check());
            CheckDict.Add("City in The Sky East Wing Lower Level Chest", new Check());
            CheckDict.Add("City in The Sky West Wing Baba Balcony Chest", new Check());
            CheckDict.Add("City in The Sky West Wing Narrow Ledge Chest", new Check());
            CheckDict.Add("City in The Sky West Wing Tile Worm Chest", new Check());
            CheckDict.Add("City in The Sky Baba Tower Top Small Chest", new Check());
            CheckDict.Add("City in The Sky Baba Tower Narrow Ledge Chest", new Check());
            CheckDict.Add("City in The Sky Baba Tower Alcove Chest", new Check());
            CheckDict.Add("City in The Sky West Garden Corner Chest", new Check());
            CheckDict.Add("City in The Sky West Garden Lone Island Chest", new Check());
            CheckDict.Add("City in The Sky West Garden Lower Chest", new Check());
            CheckDict.Add("City in The Sky West Garden Ledge Chest", new Check());
            CheckDict.Add("City in The Sky Central Outside Ledge Chest", new Check());
            CheckDict.Add("City in The Sky Central Outside Poe Island Chest", new Check());
            CheckDict.Add("City in The Sky Big Key Chest", new Check());
            CheckDict.Add("City in The Sky Chest Below Big Key Chest", new Check());
            CheckDict.Add("City in The Sky Chest Behind North Fan", new Check());
            CheckDict.Add("Kakariko_Gorge_Double_Clawshot_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_East_Double_Clawshot_Chest", new Check());
            CheckDict.Add("Lanayru_Spring_West_Double_Clawshot_Chest", new Check());
            CheckDict.Add("South_of_Castle_Town_Double_Clawshot_Chasm_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_West_Wing_First_Room_Central_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_West_Wing_Second_Room_Central_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_First_Room_East_Alcove", new Check());
            CheckDict.Add("Palace_of_Twilight_East_Wing_First_Room_West_Alcove", new Check());
            CheckDict.Add("Palace_of_Twilight_Central_First_Room_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_Big_Key_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_Central_Outdoor_Chest", new Check());
            CheckDict.Add("Palace_of_Twilight_Central_Tower_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Graveyard_Grave_Switch_Room_Back_Left_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Graveyard_Owl_Statue_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_East_Wing_Balcony_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_West_Courtyard_North_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_West_Courtyard_Central_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Main_Hall_Northeast_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Lantern_Staircase_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Main_Hall_Southwest_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Main_Hall_Northwest_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Southeast_Balcony_Tower_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Big_Key_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Eighth_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Seventh_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Sixth_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Fifth_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Fourth_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Third_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Second_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_First_Small_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Fifth_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Fourth_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Third_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_Second_Chest", new Check());
            CheckDict.Add("Hyrule_Castle_Treasure_Room_First_Chest", new Check());
            CheckDict.Add("Kakariko_Village_Bomb_Rock_Spire_Heart_Piece", new Check());
            CheckDict.Add("Faron_Field_Tree_Heart_Piece", new Check());
            CheckDict.Add("Kakariko_Gorge_Spire_Heart_Piece", new Check());
            CheckDict.Add("Zant_Heart_Container", new Check());
            CheckDict.Add("Fishing_Hole_Heart_Piece", new Check());
            CheckDict.Add("Cats_Hide_and_Seek_Minigame", new Check());

            
        }

        public void placeItemInCheck(Item item, string check)
        {
            //Create reference to the current check, tell the program that it was placed, set the item id of the check, and then save the changes to the check.
            Check currentCheck = CheckDict[check];
            currentCheck.itemWasPlaced = true;
            Items.heldItems.Remove(item);
            currentCheck.itemId = item;
            Items.PlacedImportantItems.Add(item);
            CheckDict[check] = currentCheck;
        }

        public bool checkIfItemNotNeededToReachCheck(Item item, string check, Room startingRoom)
        {
            Rooms.resetAllRoomsVisited();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
            while (roomsToExplore.Count() > 0)
            {
                for (int i = 0; i < roomsToExplore[0].checks.Count(); i++)
                {
                    Check currentCheck = CheckDict[roomsToExplore[0].checks[i]];
                    var areCheckRequirementsMet = CSharpScript.EvaluateAsync(currentCheck.requirements, options).Result;
                    if (roomsToExplore[0].checks[i] == check)
                    {
                        return ((bool)areCheckRequirementsMet &&
                            currentCheck.itemWasPlaced == false);
                    }
                }
                for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                {
                    Room currentRoom = Rooms.RoomDict[roomsToExplore[0].neighbourRequirements[i]];
                    Room currentNeighbour = Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                    var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(currentRoom.neighbourRequirements[i], options).Result;
                    if ((bool)areNeighbourRequirementsMet
                        && currentNeighbour.visited == false)
                    {
                        currentNeighbour.visited = true;
                        roomsToExplore.Add(currentNeighbour);
                    }
                }
                roomsToExplore.Remove(roomsToExplore[0]);
            }
            return false;
        }

        public bool isRequirementMet(string requirement)
        {
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
            var logicResult = CSharpScript.EvaluateAsync(requirement, options).Result;
            return (bool)logicResult;
        }
    } 

}