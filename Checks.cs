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
            CheckDict.Add("South Faron Cave Chest", new Check());
            CheckDict.Add("Faron Mist Cave Open Chest", new Check());
            CheckDict.Add("Faron Mist Cave Lantern Chest", new Check());
            CheckDict.Add("North Faron Woods Deku Baba Chest", new Check());
            CheckDict.Add("Links_Basement_Chest", new Check());
            CheckDict.Add("Forest Temple Entrance Vine Chest", new Check());
            CheckDict.Add("Forest Temple Central Chest Behind Stairs", new Check());
            CheckDict.Add("Forest Temple Central North Chest", new Check());
            CheckDict.Add("Forest Temple Windless Bridge Chest", new Check());
            CheckDict.Add("Forest Temple Second Monkey Under Bridge Chest", new Check());
            CheckDict.Add("Forest Temple Totem Pole Chest", new Check());
            CheckDict.Add("Forest Temple West Tile Worm Room Vines Chest", new Check());
            CheckDict.Add("Forest Temple West Deku Like Chest", new Check());
            CheckDict.Add("Forest Temple West Tile Worm Chest Behind Stairs", new Check());
            CheckDict.Add("Forest Temple Central Chest Hanging From Web", new Check());
            CheckDict.Add("Forest Temple Big Key Chest", new Check());
            CheckDict.Add("Forest Temple East Water Cave Chest", new Check());
            CheckDict.Add("Forest Temple North Deku Like Chest", new Check());
            CheckDict.Add("Forest Temple East Tile Worm Chest", new Check());
            CheckDict.Add("Kakariko Inn Chest", new Check());
            CheckDict.Add("Wrestling_With_Bo", new Check());
            CheckDict.Add("Goron Mines Entrance Chest", new Check());
            CheckDict.Add("Goron Mines Main Magnet Room Bottom Chest", new Check());
            CheckDict.Add("Goron Mines Gor Amato Chest", new Check());
            CheckDict.Add("Goron Mines Gor Amato Small Chest", new Check());
            CheckDict.Add("Goron Mines Magnet Maze Chest", new Check());
            CheckDict.Add("Goron Mines Crystal Switch Room Underwater Chest", new Check());
            CheckDict.Add("Goron Mines Crystal Switch Room Small Chest", new Check());
            CheckDict.Add("Goron Mines After Crystal Switch Room Magnet Wall Chest", new Check());
            CheckDict.Add("Goron Mines Outside Beamos Chest", new Check());
            CheckDict.Add("Goron Mines Gor Ebizo Chest", new Check());
            CheckDict.Add("Goron Mines Chest Before Dangoro", new Check());
            CheckDict.Add("Goron Mines Dangoro Chest", new Check());
            CheckDict.Add("Goron Mines Beamos Room Chest", new Check());
            CheckDict.Add("Goron Mines Gor Liggs Chest", new Check());
            CheckDict.Add("Goron Mines Main Magnet Room Top Chest", new Check());
            CheckDict.Add("Goron Mines Outside Underwater Chest", new Check());
            CheckDict.Add("Eldin Spring Underwater Chest", new Check());
            CheckDict.Add("Kakariko Graveyard Lantern Chest", new Check());
            CheckDict.Add("Kakariko Watchtower Chest", new Check());
            CheckDict.Add("Kakariko Watchtower Alcove Chest", new Check());
            CheckDict.Add("Eldin_Field_Bomb_Rock_Chest", new Check());
            CheckDict.Add("Zoras_Domain_Chest_By_Mother_and_Child_Isles", new Check());
            CheckDict.Add("Zoras_Domain_Chest_Behind_Waterfall", new Check());
            CheckDict.Add("Lake_Hylia_Underwater_Chest", new Check());
            CheckDict.Add("Lakebed Temple Lobby Left Chest", new Check());
            CheckDict.Add("Lakebed Temple Lobby Rear Chest", new Check());
            CheckDict.Add("Lakebed Temple Stalactite Room Chest", new Check());
            CheckDict.Add("Lakebed Temple Central Room Small Chest", new Check());
            CheckDict.Add("Lakebed Temple Central Room Chest", new Check());
            CheckDict.Add("Lakebed Temple East Lower Waterwheel Stalactite Chest", new Check());
            CheckDict.Add("Lakebed Temple East Second Floor Southwest Chest", new Check());
            CheckDict.Add("Lakebed Temple East Second Floor Southeast Chest", new Check());
            CheckDict.Add("Lakebed Temple East Water Supply Small Chest", new Check());
            CheckDict.Add("Lakebed Temple Before Deku Toad Alcove Chest", new Check());
            CheckDict.Add("Lakebed Temple Before Deku Toad Underwater Left Chest", new Check());
            CheckDict.Add("Lakebed Temple Before Deku Toad Underwater Right Chest", new Check());
            CheckDict.Add("Lakebed Temple Deku Toad Chest", new Check());
            CheckDict.Add("Lakebed Temple Chandelier Chest", new Check());
            CheckDict.Add("Lakebed Temple East Water Supply Clawshot Chest", new Check());
            CheckDict.Add("Lakebed Temple Central Room Spire Chest", new Check());
            CheckDict.Add("Lakebed Temple West Lower Small Chest", new Check());
            CheckDict.Add("Lakebed Temple West Water Supply Small Chest", new Check());
            CheckDict.Add("Lakebed Temple West Water Supply Chest", new Check());
            CheckDict.Add("Lakebed Temple West Second Floor Southwest Underwater Chest", new Check());
            CheckDict.Add("Lakebed Temple West Second Floor Central Small Chest", new Check());
            CheckDict.Add("Lakebed Temple West Second Floor Northeast Chest", new Check());
            CheckDict.Add("Lakebed Temple West Second Floor Southeast Chest", new Check());
            CheckDict.Add("Lakebed Temple Big Key Chest", new Check());
            CheckDict.Add("Lakebed Temple Underwater Maze Small Chest", new Check());
            CheckDict.Add("Lakebed Temple East Lower Waterwheel Bridge Chest", new Check());
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
            CheckDict.Add("Death Mountain Alcove Chest", new Check());
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
            CheckDict.Add("Faron Mist Stump Chest", new Check());
            CheckDict.Add("Faron Mist North Chest", new Check());
            CheckDict.Add("Faron Mist South Chest", new Check());
            CheckDict.Add("Snowpeak Ruins West Courtyard Buried Chest", new Check());
            CheckDict.Add("Snowpeak Ruins East Courtyard Buried Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Ordon Pumpkin Chest", new Check());
            CheckDict.Add("Snowpeak Ruins East Courtyard Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Wooden Beam Central Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Wooden Beam Northwest Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Courtyard Central Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Chest After Darkhammer", new Check());
            CheckDict.Add("Snowpeak Ruins Broken Floor Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Wooden Beam Chandelier Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Lobby Chandelier Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Lobby West Armor Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Lobby East Armor Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Northeast Chandelier Chest", new Check());
            CheckDict.Add("Snowpeak Ruins West Cannon Room Central Chest", new Check());
            CheckDict.Add("Snowpeak Ruins West Cannon Room Corner Chest", new Check());
            CheckDict.Add("Snowpeak Ruins Chapel Chest", new Check());
            CheckDict.Add("Snowpeak_Cave_Ice_Lantern_Chest", new Check());
            CheckDict.Add("Snowpeak_Freezard_Grotto_Chest", new Check());
            CheckDict.Add("Lanayru_Ice_Block_Puzzle_Cave_Chest", new Check());
            CheckDict.Add("Lost_Woods_Lantern_Chest", new Check());
            CheckDict.Add("Sacred_Grove_Spinner_Chest", new Check());
            CheckDict.Add("Temple of Time Lobby Lantern Chest", new Check());
            CheckDict.Add("Temple of Time First Staircase Gohma Gate Chest", new Check());
            CheckDict.Add("Temple of Time First Staircase Window Chest", new Check());
            CheckDict.Add("Temple of Time First Staircase Armos Chest", new Check());
            CheckDict.Add("Temple of Time Statue Throws Room East Chest", new Check());
            CheckDict.Add("Temple of Time Moving Wall Beamos Room Chest", new Check());
            CheckDict.Add("Temple of Time Scales Gohma Chest", new Check());
            CheckDict.Add("Temple of Time Gilloutine Chest", new Check());
            CheckDict.Add("Temple of Time Chest Before Darknut", new Check());
            CheckDict.Add("Temple of Time Darknut Chest", new Check());
            CheckDict.Add("Temple of Time Scales Upper Chest", new Check());
            CheckDict.Add("Temple of Time Big Key Chest Room Upper Chest", new Check());
            CheckDict.Add("Temple of Time Big Key Chest", new Check());
            CheckDict.Add("Temple of Time Moving Wall Dinalfos Room Chest", new Check());
            CheckDict.Add("Temple of Time Statue Throws Room North Chest", new Check());
            CheckDict.Add("Temple of Time Statue Throws Room Statue Chest", new Check());
            CheckDict.Add("Sacred_Grove_Past_Owl_Statue_Chest", new Check());
            CheckDict.Add("Doctors Office Balcony Chest", new Check());
            CheckDict.Add("Bridge_of_Eldin_Owl_Statue_Chest", new Check());
            CheckDict.Add("Kakariko_Gorge_Owl_Statue_Chest", new Check());
            CheckDict.Add("Hyrule_Field_Ampitheater_Owl_Statue_Chest", new Check());
            CheckDict.Add("Lake_Hylia_Bridge_Owl_Statue_Chest", new Check());
            CheckDict.Add("Faron Woods Owl Statue Chest", new Check());
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
            CheckDict.Add("Palace of Twilight West Wing First Room Central Chest", new Check());
            CheckDict.Add("Palace of Twilight West Wing Second Room Central Chest", new Check());
            CheckDict.Add("Palace of Twilight West Wing Second Room Lower South Chest", new Check());
            CheckDict.Add("Palace of Twilight West Wing Second Room Southeast Chest", new Check());
            CheckDict.Add("Palace of Twilight West Wing Chest Behind Wall of Darkness", new Check());
            CheckDict.Add("Palace of Twilight East Wing First Room North Small Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing First Room Zant Head Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing Second Room Northeast Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing Second Room Northwest Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing Second Room Southwest Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing Second Room Southeast Chest", new Check());
            CheckDict.Add("Palace of Twilight East Wing First Room East Alcove", new Check());
            CheckDict.Add("Palace of Twilight East Wing First Room West Alcove", new Check());
            CheckDict.Add("Palace of Twilight Central First Room Chest", new Check());
            CheckDict.Add("Palace of Twilight Big Key Chest", new Check());
            CheckDict.Add("Palace of Twilight Central Outdoor Chest", new Check());
            CheckDict.Add("Palace of Twilight Central Tower Chest", new Check());
            CheckDict.Add("Hyrule Castle Graveyard Grave Switch Room Right Chest", new Check());
            CheckDict.Add("Hyrule Castle Graveyard Grave Switch Room Front Left Chest", new Check());
            CheckDict.Add("Hyrule Castle Graveyard Grave Switch Room Back Left Chest", new Check());
            CheckDict.Add("Hyrule Castle Graveyard Owl Statue Chest", new Check());
            CheckDict.Add("Hyrule Castle East Wing Boomerang Puzzle Chest", new Check());
            CheckDict.Add("Hyrule Castle East Wing Balcony Chest", new Check());
            CheckDict.Add("Hyrule Castle West Courtyard North Small Chest", new Check());
            CheckDict.Add("Hyrule Castle West Courtyard Central Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Main Hall Northeast Chest", new Check());
            CheckDict.Add("Hyrule Castle Lantern Staircase Chest", new Check());
            CheckDict.Add("Hyrule Castle Main Hall Southwest Chest", new Check());
            CheckDict.Add("Hyrule Castle Main Hall Northwest Chest", new Check());
            CheckDict.Add("Hyrule Castle Southeast Balcony Tower Chest", new Check());
            CheckDict.Add("Hyrule Castle Big Key Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Eighth Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Seventh Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Sixth Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Fifth Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Fourth Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Third Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Second Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room First Small Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Fifth Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Fourth Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Third Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room Second Chest", new Check());
            CheckDict.Add("Hyrule Castle Treasure Room First Chest", new Check());
            CheckDict.Add("Kakariko_Village_Bomb_Rock_Spire_Heart_Piece", new Check());
            CheckDict.Add("Faron_Field_Tree_Heart_Piece", new Check());
            CheckDict.Add("Kakariko_Gorge_Spire_Heart_Piece", new Check());
            CheckDict.Add("Zant Heart Container", new Check());
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