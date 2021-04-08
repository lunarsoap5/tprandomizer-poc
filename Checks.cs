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
    public class Check
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
        public Dictionary<string, Check> CheckDict = new Dictionary<string, Check>();
        public void InitializeChecks()
        {

            CheckDict.Add("Uli Cradle Delivery", new Check());
            CheckDict.Add("Sera Cat Fishing Reward", new Check());
            CheckDict.Add("Sera Shop Slingshot", new Check());
            CheckDict.Add("Gift From Rusl", new Check());
            CheckDict.Add("Coro Lantern", new Check());
            CheckDict.Add("South Faron Cave Chest", new Check());
            CheckDict.Add("Faron Mist Cave Open Chest", new Check());
            CheckDict.Add("Faron Mist Cave Lantern Chest", new Check());
            CheckDict.Add("North Faron Woods Deku Baba Chest", new Check());
            CheckDict.Add("Links Basement Chest", new Check());
            CheckDict.Add("Forest Temple Entrance Vines Chest", new Check());
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
            CheckDict.Add("Wrestling With Bo", new Check());
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
            CheckDict.Add("Barnes Bomb Bag", new Check());
            CheckDict.Add("Eldin Spring Underwater Chest", new Check());
            CheckDict.Add("Kakariko Graveyard Lantern Chest", new Check());
            CheckDict.Add("Kakariko Watchtower Chest", new Check());
            CheckDict.Add("Kakariko Watchtower Alcove Chest", new Check());
            CheckDict.Add("Eldin Field Bomb Rock Chest", new Check());
            CheckDict.Add("Zoras Domain Chest By Mother and Child Isles", new Check());
            CheckDict.Add("Zoras Domain Chest Behind Waterfall", new Check());
            CheckDict.Add("Lake Hylia Underwater Chest", new Check());
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
            CheckDict.Add("Sacred Grove Baba Serpent Grotto Chest", new Check());
            CheckDict.Add("West Hyrule Field Helmasaur Grotto Chest", new Check());
            CheckDict.Add("Lake Lantern Cave First Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Second Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Third Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Fourth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Fifth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Sixth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Seventh Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Eighth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Ninth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Tenth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Eleventh Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Twelfth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Thirteenth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave Fourteenth Chest", new Check());
            CheckDict.Add("Lake Lantern Cave End Lantern Chest", new Check());
            CheckDict.Add("Lake Hylia Water Toadpoli Grotto Chest", new Check());
            CheckDict.Add("Outside Lanayru Spring Left Statue Chest", new Check());
            CheckDict.Add("Outside Lanayru Spring Right Statue Chest", new Check());
            CheckDict.Add("Lanayru Spring Underwater Left Chest", new Check());
            CheckDict.Add("Lanayru Spring Underwater Right Chest", new Check());
            CheckDict.Add("Lanayru Spring Back Room Left Chest", new Check());
            CheckDict.Add("Lanayru Spring Back Room Right Chest", new Check());
            CheckDict.Add("Lanayru Spring Back Room Lantern Chest", new Check());
            CheckDict.Add("Flight By Fowl Top Platform Chest", new Check());
            CheckDict.Add("Flight By Fowl Second Platform Chest", new Check());
            CheckDict.Add("Flight By Fowl Third Platform Chest", new Check());
            CheckDict.Add("Flight By Fowl Fourth Platform Chest", new Check());
            CheckDict.Add("Flight By Fowl Fifth Platform Chest", new Check());
            CheckDict.Add("Lake Hylia Shell Blade Grotto Chest", new Check());
            CheckDict.Add("Zoras Domain Light All Torches Chest", new Check());
            CheckDict.Add("Zoras Domain Extinguish All Torches Chest", new Check());
            CheckDict.Add("Lanayru Field Skulltula Grotto Chest", new Check());
            CheckDict.Add("Lanayru Field Behind Gate Underwater Chest", new Check());
            CheckDict.Add("Lake Hylia Bridge Vines Chest", new Check());
            CheckDict.Add("Lake Hylia Bridge Bubble Grotto Chest", new Check());
            CheckDict.Add("Lake Hylia Bridge Cliff Chest", new Check());
            CheckDict.Add("Faron Field Bridge Chest", new Check());
            CheckDict.Add("Faron Field Corner Grotto Right Chest", new Check());
            CheckDict.Add("Faron Field Corner Grotto Rear Chest", new Check());
            CheckDict.Add("Faron Field Corner Grotto Left Chest", new Check());
            CheckDict.Add("Death Mountain Alcove Chest", new Check());
            CheckDict.Add("Goron Mines Outside Clawshot Chest", new Check());
            CheckDict.Add("Eldin Lantern Cave First Chest", new Check());
            CheckDict.Add("Eldin Lantern Cave Lantern Chest", new Check());
            CheckDict.Add("Eldin Lantern Cave Second Chest", new Check());
            CheckDict.Add("Outside South Castle Town Tightrope Chest", new Check());
            CheckDict.Add("Outside South Castle Town Tetike Grotto Chest", new Check());
            CheckDict.Add("Eldin Field Bomskit Grotto Left Chest", new Check());
            CheckDict.Add("Eldin Field Bomskit Grotto Lantern Chest", new Check());
            CheckDict.Add("Eldin Field Water Bomb Fish Grotto Chest", new Check());
            CheckDict.Add("Gerudo Desert Skulltula Grotto Chest", new Check());
            CheckDict.Add("Gerudo Desert Peahat Ledge Chest", new Check());
            CheckDict.Add("Gerudo Desert East Canyon Chest", new Check());
            CheckDict.Add("Gerudo Desert Lone Small Chest", new Check());
            CheckDict.Add("Eldin Stockcave Upper Chest", new Check());
            CheckDict.Add("Eldin Stockcave Lantern Chest", new Check());
            CheckDict.Add("Eldin Stockcave Lowest Chest", new Check());
            CheckDict.Add("Gerudo Desert West Canyon Chest", new Check());
            CheckDict.Add("Gerudo Desert Poe Grotto Lantern Chest", new Check());
            CheckDict.Add("Gerudo Desert Northeast Chest Behind Gates", new Check());
            CheckDict.Add("Gerudo Desert South Chest Behind Wooden Gates", new Check());
            CheckDict.Add("Gerudo Desert Campfire North Chest", new Check());
            CheckDict.Add("Gerudo Desert Campfire East Chest", new Check());
            CheckDict.Add("Gerudo Desert Campfire West Chest", new Check());
            CheckDict.Add("Gerudo Desert Northwest Chest Behind Gates", new Check());
            CheckDict.Add("Gerudo Desert North Small Chest Before Bublin Camp", new Check());
            CheckDict.Add("Bublin Camp First Chest Under Tower At Entrance", new Check());
            CheckDict.Add("Bublin Camp Small Chest in Back of Camp", new Check());
            CheckDict.Add("Outside Arbiters Grounds Lantern Chest", new Check());
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
            CheckDict.Add("Lanayru Field Spinner Track Chest", new Check());
            CheckDict.Add("Lanayru Field Stalfos Grotto Right Small Chest", new Check());
            CheckDict.Add("Lanayru Field Stalfos Grotto Left Small Chest", new Check());
            CheckDict.Add("Lanayru Field Stalfos Grotto Stalfos Chest", new Check());
            CheckDict.Add("Outside South Castle Town Fountain Chest", new Check());
            CheckDict.Add("Ordon Ranch Grotto Lantern Chest", new Check());
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
            CheckDict.Add("Snowpeak Cave Ice Lantern Chest", new Check());
            CheckDict.Add("Snowpeak Freezard Grotto Chest", new Check());
            CheckDict.Add("Lanayru Ice Block Puzzle Cave Chest", new Check());
            CheckDict.Add("Lost Woods Lantern Chest", new Check());
            CheckDict.Add("Sacred Grove Spinner Chest", new Check());
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
            CheckDict.Add("Sacred Grove Past Owl Statue Chest", new Check());
            CheckDict.Add("Doctors Office Balcony Chest", new Check());
            CheckDict.Add("Bridge of Eldin Owl Statue Chest", new Check());
            CheckDict.Add("Kakariko Gorge Owl Statue Chest", new Check());
            CheckDict.Add("Hyrule Field Ampitheater Owl Statue Chest", new Check());
            CheckDict.Add("Lake Hylia Bridge Owl Statue Chest", new Check());
            CheckDict.Add("Faron Woods Owl Statue Chest", new Check());
            CheckDict.Add("Gerudo Desert Owl Statue Chest", new Check());
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
            CheckDict.Add("Kakariko Gorge Double Clawshot Chest", new Check());
            CheckDict.Add("Lanayru Spring East Double Clawshot Chest", new Check());
            CheckDict.Add("Lanayru Spring West Double Clawshot Chest", new Check());
            CheckDict.Add("Outside South Castle Town Double Clawshot Chasm Chest", new Check());
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
            CheckDict.Add("Kakariko Village Bomb Rock Spire Heart Piece", new Check());
            CheckDict.Add("Faron Field Tree Heart Piece", new Check());
            CheckDict.Add("Kakariko Gorge Spire Heart Piece", new Check());
            CheckDict.Add("Zant Heart Container", new Check());
            CheckDict.Add("Fishing Hole Heart Piece", new Check());
            CheckDict.Add("Cats Hide and Seek Minigame", new Check());
        }

        public void deserializeChecks()
        {
            foreach (string file in System.IO.Directory.GetFiles("./Checks/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                Singleton.getInstance().Checks.CheckDict[fileName] = JsonConvert.DeserializeObject<Check>(contents);
                Check currentCheck = Singleton.getInstance().Checks.CheckDict[fileName];
                currentCheck.requirements = Regex.Replace(currentCheck.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                Singleton.getInstance().Checks.CheckDict[fileName] = currentCheck;
                Console.WriteLine("Check File Loaded " + fileName);
            }
        }

        public void placeItemInCheck(Item item, string check)
        {
            Console.WriteLine("Placing item in check.");
            //Create reference to the current check, tell the program that it was placed, set the item id of the check, and then save the changes to the check.
            Check currentCheck = Singleton.getInstance().Checks.CheckDict[check];
            currentCheck.itemWasPlaced = true;
            Singleton.getInstance().Items.heldItems.Remove(item);
            currentCheck.itemId = item;
            Singleton.getInstance().Checks.CheckDict[check] = currentCheck;
            Console.WriteLine("Placed " + currentCheck.itemId + " in check " + currentCheck.checkName);
        }

        public bool checkIfItemNotNeededToReachCheck(Item item, string check, Room startingRoom)
        {
            Console.WriteLine("Trying to place item: " + item + " in check: " + Singleton.getInstance().Checks.CheckDict[check].checkName);
            Singleton.getInstance().Rooms.resetAllRoomsVisited();
            List<Room> roomsToExplore = new List<Room>();
            startingRoom.visited = true;
            roomsToExplore.Add(startingRoom);
            var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("tprandomizer_poc_main");
            while (roomsToExplore.Count() > 0)
            {
                Console.WriteLine("Currently exploring: " + roomsToExplore[0].name);
                foreach (var currentCheck in roomsToExplore[0].checks)
                {
                    if (currentCheck == check)
                    {
                        Check evaluatedCheck = Singleton.getInstance().Checks.CheckDict[currentCheck];
                        var areCheckRequirementsMet = CSharpScript.EvaluateAsync(evaluatedCheck.requirements, options).Result;
                        return ((bool)areCheckRequirementsMet &&
                            evaluatedCheck.itemWasPlaced == false);
                    }
                }
                
                 for (int i = 0; i < roomsToExplore[0].neighbours.Count(); i++)
                {
                    Room currentNeighbour = Singleton.getInstance().Rooms.RoomDict[roomsToExplore[0].neighbours[i]];
                    var areNeighbourRequirementsMet = CSharpScript.EvaluateAsync(roomsToExplore[0].neighbourRequirements[i], options).Result;
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
    } 

}