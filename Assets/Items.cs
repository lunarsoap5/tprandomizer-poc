using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;
using tprandomizer_poc_main;

namespace tprandomizer_poc_main
{
	public enum Item : byte
	{
		Recovery_Heart	=	0x00,
		Green_Rupee	=	0x01,
		Blue_Rupee	=	0x02,
		Yellow_Rupee	=	0x03,
		Red_Rupee	=	0x04,
		Purple_Rupee	=	0x05,
		Orange_Rupee	=	0x06,
		Silver_Rupee	=	0x07,
		/*Borrow_Bomb_Bag?	=	0x08,*/
		/*Bomb_Bag_And_Bombs?	=	0x09,*/
		Bombs_5	=	0x0A,
		Bombs_10	=	0x0B,
		Bombs_20	=	0x0C,
		Bombs_30	=	0x0D,
		Arrows_10	=	0x0E,
		Arrows_20	=	0x0F,
		Arrows_30	=	0x10,
		Arrows_1	=	0x11,
		Seeds_50	=	0x12,
		/*?	=	0x13,*/
		/*?	=	0x14,*/
		/*?	=	0x15,*/
		Water_Bombs_5	=	0x16,
		Water_Bombs_10	=	0x17,
		Water_Bombs_15	=	0x18,
		Water_Bombs_3	=	0x19,
		Bomblings_5	=	0x1A,
		Bomblings_10	=	0x1B,
		Bomblings_3	=	0x1C,
		Bombling_1	=	0x1D,
		Fairy	=	0x1E,
		Recovery_Heart_x3	=	0x1F,
		Small_Key	=	0x20,
		Piece_of_Heart	=	0x21,
		Heart_Container	=	0x22,
		Dungeon_Map	=	0x23,
		Compass	=	0x24,
		Ooccoo_FT	=	0x25,
		Big_Key	=	0x26,
		Ooccoo_Jr	=	0x27,
		Ordon_Sword	=	0x28,
		Master_Sword	=	0x29,
		Ordon_Shield	=	0x2A,
		Wooden_Shield	=	0x2B,
		Hylian_Shield	=	0x2C,
		Ooccoos_Note	=	0x2D,
		Ordon_Clothing	=	0x2E,
		Heros_Clothes	=	0x2F,
		Magic_Armor	=	0x30,
		Zora_Armor	=	0x31,
		/*does notting*/Shadow_Crystal	=	0x32,
		Ooccoo_Dungeon	=	0x33,
		/*unused*/Small_Wallet	=	0x34,
		Big_Wallet	=	0x35,
		Giant_Wallet	=	0x36,
		/*Piece_of_Heart_2?	=	0x37,*/
		/*Piece_of_Heart_3?	=	0x38,*/
		/*Piece_of_Heart_4?	=	0x39,*/
		/*Piece_of_Heart_5?	=	0x3A,*/
		/*sword?	=	0x3B,*/
		/*?	=	0x3C,*/
		Coral_Earring	=	0x3D,
		Hawkeye	=	0x3E,
		Wooden_Sword	=	0x3F,
		Boomerang	=	0x40,
		Spinner	=	0x41,
		Ball_and_Chain	=	0x42,
		Heros_Bow	=	0x43,
		Clawshot	=	0x44,
		Iron_Boots	=	0x45,
		Dominion_Rod = 0x46,
		Double_Clawshot	=	0x47,
		Lantern	=	0x48,
		Master_Sword_Light	=	0x49,
		Fishing_Rod	=	0x4A,
		Slingshot	=	0x4B,
		Dominion_Rod_Uncharged = 0x4C,
		/*?	=	0x4D,*/
		/*?	=	0x4E,*/
		Giant_Bomb_Bag	=	0x4F,
		Empty_Bomb_Bag	=	0x50,
		Bomb_Bag_And_Bombs	=	0x51,
		/*Giant_Bomb_Bag?	=	0x52,*/
		/*?	=	0x53,*/
		/*unused*/Small_Quiver	=	0x54,
		Big_Quiver	=	0x55,
		Giant_Quiver	=	0x56,
		/*?	=	0x57,*/
		Fishing_Rod_Lure	=	0x58,
		Bow_Bombs	=	0x59,
		Bow_Hawkeye	=	0x5A,
		Fishing_Rod_Bee_Larva	=	0x5B,
		Fishing_Rod_Coral_Earring	=	0x5C,
		Fishing_Rod_Worm	=	0x5D,
		Fishing_Rod_Earring_Bee_Larva	=	0x5E,
		Fishing_Rod_Earring_Worm	=	0x5F,
		Empty_Bottle	=	0x60,
		Red_Potion_Shop	=	0x61,
		Green_Potion	=	0x62,
		Blue_Potion	=	0x63,
		Milk	=	0x64,
		Sera_Bottle	=	0x65,
		Lantern_Oil_Shop	=	0x66,
		Water	=	0x67,
		Lantern_Oil_Scooped	=	0x68,
		Red_Potion_Scooped	=	0x69,
		Nasty_soup	=	0x6A,
		Hot_spring_water_Scooped	=	0x6B,
		Fairy_Bottle	=	0x6C,
		Hot_Spring_Water_Shop	=	0x6D,
		Lantern_Refill_Scooped	=	0x6E,
		Lantern_Refill_Shop	=	0x6F,
		Bomb_Bag_Regular_Bombs	=	0x70,
		Bomb_Bag_Water_Bombs	=	0x71,
		Bomb_Bag_Bomblings	=	0x72,
		Fairy_Tears	=	0x73,
		Worm	=	0x74,
		Jovani_Bottle	=	0x75,
		Bee_Larva_Scooped	=	0x76,
		Rare_Chu_Jelly	=	0x77,
		Red_Chu_Jelly	=	0x78,
		Blue_Chu_Jelly	=	0x79,
		Green_Chu_Jelly	=	0x7A,
		Yellow_Chu_Jelly	=	0x7B,
		Purple_Chu_Jelly	=	0x7C,
		Simple_Soup	=	0x7D,
		Good_Soup	=	0x7E,
		Superb_Soup	=	0x7F,
		Renardos_Letter	=	0x80,
		Invoice	=	0x81,
		Wooden_Statue	=	0x82,
		Ilias_Charm	=	0x83,
		Horse_Call	=	0x84,
		Forest_Temple_Small_Key	=	0x85,
		Goron_Mines_Small_Key=	0x86,
		Lakebed_Temple_Small_Key	=	0x87,
		Arbiters_Grounds_Small_Key	=	0x88,
		Snowpeak_Ruins_Small_Key	=	0x89,
		Temple_of_Time_Small_Key	=	0x8A,
		City_in_The_Sky_Small_Key	=	0x8B,
		Palace_of_Twilight_Small_Key	=	0x8C,
		Hyrule_Castle_Small_Key	=	0x8D,
		/*?	=	0x8E,*/
		/*?	=	0x8F,*/
		Aurus_Memo	=	0x90,
		Asheis_Sketch	=	0x91,
		Forest_Temple_Big_Key	=	0x92,
		Lakebed_Temple_Big_Key	=	0x93,
		Arbiters_Grounds_Big_Key	=	0x94,
		Temple_of_Time_Big_Key	=	0x95,
		City_in_The_Sky_Big_Key	=	0x96,
		Palace_of_Twilight_Big_Key	=	0x97,
		Hyrule_Castle_Big_Key	=	0x98,
		/*?	=	0x99,*/
		/*?	=	0x9A,*/
		/*?	=	0x9B,*/
		Lantern_Yellow_Chu_Chu	=	0x9C,
		Coro_Bottle	=	0x9D,
		Bee_Larva_Shop	=	0x9E,
		Black_Chu_Jelly	=	0x9F,
		/*unused*/Tear_Of_Light	=	0xA0,
		Vessel_Of_Light_Faron	=	0xA1,
		Vessel_Of_Light_Eldin	=	0xA2,
		Vessel_Of_Light_Lanayru	=	0xA3,
		/*unused*/Vessel_Of_Light_Full	=	0xA4,
		/*?	=	0xA5,*/
		/*?	=	0xA6,*/
		/*?	=	0xA7,*/
		/*?	=	0xA8,*/
		/*?	=	0xA9,*/
		/*?	=	0xAA,*/
		/*?	=	0xAB,*/
		/*?	=	0xAC,*/
		/*?	=	0xAD,*/
		/*?	=	0xAE,*/
		/*?	=	0xAF,*/
		Ilias_Scent	=	0xB0,
		/*Unused_Scent?	=	0xB1,*/
		Poe_Scent	=	0xB2,
		Reekfish_Scent	=	0xB3,
		Youths_Scent	=	0xB4,
		Medicine_Scent	=	0xB5,
		/*?	=	0xB6,*/
		/*?	=	0xB7,*/
		/*?	=	0xB8,*/
		/*?	=	0xB9,*/
		/*?	=	0xBA,*/
		/*?	=	0xBB,*/
		/*?	=	0xBC,*/
		/*?	=	0xBD,*/
		/*?	=	0xBE,*/
		/*Bottle_Insides?	=	0xBF,*/
		Male_Beetle	=	0xC0,
		Female_Beetle	=	0xC1,
		Male_Butterfly	=	0xC2,
		Female_Butterfly	=	0xC3,
		Male_Stag_Beetle	=	0xC4,
		Female_Stag_Beetle	=	0xC5,
		Male_Grasshopper	=	0xC6,
		Female_Grasshopper	=	0xC7,
		Male_Phasmid	=	0xC8,
		Female_Phasmid	=	0xC9,
		Male_Pill_Bug	=	0xCA,
		Female_Pill_Bug	=	0xCB,
		Male_Mantis	=	0xCC,
		Female_Mantis	=	0xCD,
		Male_Ladybug	=	0xCE,
		Female_Ladybug	=	0xCF,
		Male_Snail	=	0xD0,
		Female_Snail	=	0xD1,
		Male_Dragonfly	=	0xD2,
		Female_Dragonfly	=	0xD3,
		Male_Ant	=	0xD4,
		Female_Ant	=	0xD5,
		Male_Dayfly	=	0xD6,
		Female_Dayfly	=	0xD7,
		/*?	=	0xD8,*/
		/*?	=	0xD9,*/
		/*?	=	0xDA,*/
		Ancient_Sky_Book_First_Character	=	0xDB,
		Ancient_Sky_Book_Second_Character	=	0xDC,
		Ancient_Sky_Book_Third_Character	=	0xDD,
		Ancient_Sky_Book_Fourth_Character	=	0xDE,
		Ancient_Sky_Book_Fifth_Character	=	0xDF,
		Poe_Soul	=	0xE0,
		Ending_Blow	=	0xE1,
		Shield_Attack	=	0xE2,
		Back_Slice	=	0xE3,
		Helm_Splitter	=	0xE4,
		Mortal_Draw	=	0xE5,
		Jump_Strike	=	0xE6,
		Great_Spin	=	0xE7,
		/*?	=	0xE8,*/
		Ancient_Sky_Book_Empty	=	0xE9,
		Ancient_Sky_Book_Partly_Filled	=	0xEA,
		Ancient_Sky_Book_Completed	=	0xEB,
		Ooccoo_CitS	=	0xEC,
		Purple_Rupee_Links_House	=	0xED,
		Small_Key_N_Faron_Gate	=	0xEE,
		/*Blue_Fire?	=	0xEF,*/
		/*Blue_Fire?	=	0xF0,*/
		/*Blue_Fire?	=	0xF1,*/
		/*Blue_Fire?	=	0xF2,*/
		Gate_Keys	=	0xF3,
		Ordon_Pumpkin	=	0xF4,
		Ordon_Goat_Cheese	=	0xF5,
		Snowpeak_Ruins_Bedroom_Key	=	0xF6,
		/*Shield?	=	0xF7,*/
		Got_Lantern_Back	=	0xF8,
		Goron_Mines_Key_Shard_1	=	0xF9,
		Goron_Mines_Key_Shard_2	=	0xFA,
		Goron_Mines_Key_Shard_3	=	0xFB,
		/*Key?	=	0xFC,*/
		Goron_Mines_Big_Key	=	0xFD,
		Coro_Key	=	0xFE,
		/*Gives_Vanilla*/NullItem	=	0xFF
	};

	public class ItemFunctions
	{
		
		public List<Item> heldItems = new List<Item>();

		public List<Item> regionItems = new List<Item>();

		public static int nbSkybooksPlaced = 0;

		public List<Item> ImportantItems = new List<Item>()
        {
			Item.Wooden_Sword,
			Item.Boomerang,
			Item.Lantern,
			Item.Slingshot,
            Item.Fishing_Rod,
            Item.Ordon_Sword,
            Item.Iron_Boots,
            Item.Heros_Bow,
            Item.Empty_Bomb_Bag,
            Item.Zora_Armor,
            Item.Clawshot,
            Item.Master_Sword,
            Item.Shadow_Crystal,
            Item.Aurus_Memo,
            Item.Spinner,
            Item.Coral_Earring,
            Item.Ball_and_Chain,
            Item.Dominion_Rod_Uncharged,
            Item.Dominion_Rod,
            Item.Ancient_Sky_Book_Empty,
            Item.Ancient_Sky_Book_First_Character,
            Item.Ancient_Sky_Book_Second_Character,
            Item.Ancient_Sky_Book_Third_Character,
            Item.Ancient_Sky_Book_Fourth_Character,
            Item.Ancient_Sky_Book_Fifth_Character,
            Item.Ancient_Sky_Book_Completed,
            Item.Double_Clawshot,
            Item.Master_Sword_Light
        };


		public List<Item> RegionKeys = new List<Item>();

		public Item verifyItem (Item item, List<Item> itemList)
		{
			switch (item) //Make sure you place the items in the right order (from big to small)
			{
				case Item.Ancient_Sky_Book_Empty:
					if (itemList.Contains(Item.Ancient_Sky_Book_Completed))
					{
						item = Item.Ancient_Sky_Book_Completed; //Ancient_Sky_Book_empty
					}
					else if (itemList.Contains(Item.Ancient_Sky_Book_Fifth_Character))
					{
						item = Item.Ancient_Sky_Book_Fifth_Character; //Ancient_Sky_Book_empty
					}
					else if (itemList.Contains(Item.Ancient_Sky_Book_Fourth_Character))
					{
						item = Item.Ancient_Sky_Book_Fourth_Character; //Ancient_Sky_Book_empty
					}
					else if (itemList.Contains(Item.Ancient_Sky_Book_Third_Character))
					{
						item = Item.Ancient_Sky_Book_Third_Character; //Ancient_Sky_Book_empty
					}
					else if (itemList.Contains(Item.Ancient_Sky_Book_Second_Character))
					{
						item = Item.Ancient_Sky_Book_Second_Character; //Ancient_Sky_Book_empty
					}
					else if (itemList.Contains(Item.Ancient_Sky_Book_First_Character))
					{
						item = Item.Ancient_Sky_Book_First_Character; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_First_Character:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Second_Character:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Third_Character:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Fourth_Character:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Fifth_Character:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Completed:
					if (nbSkybooksPlaced > 5)
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Clawshot:
					if (itemList.Contains(Item.Double_Clawshot))
					{
						item = Item.Double_Clawshot; //Double_Clawshot
					}
					break;
				case Item.Dominion_Rod_Uncharged:
					if (itemList.Contains(Item.Dominion_Rod))
					{
						item = Item.Dominion_Rod; //Charged_Dominion_Rod
					}
					break;
				case Item.Big_Wallet:
					if (itemList.Contains(Item.Giant_Wallet))
					{
						item = Item.Giant_Wallet; //Giant_Wallet
					}
					break;
				case Item.Big_Quiver:
					if (itemList.Contains(Item.Giant_Quiver))
					{
						item = Item.Giant_Quiver; //Giant_Quiver
					}
					break;
				case Item.Heros_Bow:
					if (itemList.Contains(Item.Giant_Quiver))
					{
						item = Item.Giant_Quiver; //Giant_Quiver
					}
					else if (itemList.Contains(Item.Big_Quiver))
					{
						item = Item.Big_Quiver; //Big_Quiver
					}
					break;
				case Item.Master_Sword:
					if (itemList.Contains(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					break;
				case Item.Ordon_Sword:
					if (itemList.Contains(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					else if (itemList.Contains(Item.Master_Sword))
					{
						item = Item.Master_Sword; //Master_Sword
					}
					break;
				case Item.Wooden_Sword:
					if (itemList.Contains(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					else if (itemList.Contains(Item.Master_Sword))
					{
						item = Item.Master_Sword; //Master_Sword
					}
					else if (itemList.Contains(Item.Ordon_Sword))
					{
						item = Item.Ordon_Sword; //Ordon_Sword
					}
					break;
				case Item.Jump_Strike:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					break;
				case Item.Mortal_Draw:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (itemList.Contains(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					break;
				case Item.Helm_Splitter:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (itemList.Contains(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (itemList.Contains(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					break;
				case Item.Back_Slice:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (itemList.Contains(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (itemList.Contains(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (itemList.Contains(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					break;
				case Item.Shield_Attack:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (itemList.Contains(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (itemList.Contains(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (itemList.Contains(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					else if (itemList.Contains(Item.Back_Slice))
					{
						item = Item.Back_Slice; //Back_Slice
					}
					break;
				case Item.Ending_Blow:
					if (itemList.Contains(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (itemList.Contains(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (itemList.Contains(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (itemList.Contains(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					else if (itemList.Contains(Item.Back_Slice))
					{
						item = Item.Back_Slice; //Back_Slice
					}
					else if (itemList.Contains(Item.Shield_Attack))
					{
						item = Item.Shield_Attack; //Shield_Attack
					}
					break;
			}
			return item;
		}
		bool checkIfItemIsInList(Item item, List<Item> itemList)
		{
			bool isItemPresent = true;
			for (int j = 0; j < itemList.Count(); j++)
			{
				if (item == itemList[j])
				{
					isItemPresent = true;
					break;
				}
			}
			return isItemPresent;
		}

		public void generateItemPool()
		{
			nbSkybooksPlaced = 0;
			heldItems.AddRange(Enumerable.Repeat(Item.Piece_of_Heart, 45));
			heldItems.AddRange(Enumerable.Repeat(Item.Heart_Container, 8));
			heldItems.AddRange(Enumerable.Repeat(Item.Green_Rupee, 2));
			heldItems.AddRange(Enumerable.Repeat(Item.Blue_Rupee, 3));
			heldItems.AddRange(Enumerable.Repeat(Item.Yellow_Rupee, 20));
			heldItems.AddRange(Enumerable.Repeat(Item.Red_Rupee, 49));
			heldItems.AddRange(Enumerable.Repeat(Item.Purple_Rupee, 49));
			heldItems.AddRange(Enumerable.Repeat(Item.Orange_Rupee, 44));
			heldItems.AddRange(Enumerable.Repeat(Item.Silver_Rupee, 3));

			RegionKeys.AddRange(Enumerable.Repeat(Item.Forest_Temple_Small_Key, 4));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Goron_Mines_Small_Key, 3));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Lakebed_Temple_Small_Key, 3));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Arbiters_Grounds_Small_Key, 5));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Snowpeak_Ruins_Small_Key, 4));
			RegionKeys.Add(Item.Ordon_Pumpkin);
			RegionKeys.Add(Item.Ordon_Goat_Cheese);
			RegionKeys.AddRange(Enumerable.Repeat(Item.Temple_of_Time_Small_Key, 3));
			RegionKeys.AddRange(Enumerable.Repeat(Item.City_in_The_Sky_Small_Key, 1));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Palace_of_Twilight_Small_Key, 7));
			RegionKeys.AddRange(Enumerable.Repeat(Item.Hyrule_Castle_Small_Key, 3));
			RegionKeys.Add(Item.Forest_Temple_Big_Key);
			RegionKeys.Add(Item.Goron_Mines_Key_Shard_1);
			RegionKeys.Add(Item.Goron_Mines_Key_Shard_2);
			RegionKeys.Add(Item.Goron_Mines_Big_Key);
			RegionKeys.Add(Item.Lakebed_Temple_Big_Key);
			RegionKeys.Add(Item.Arbiters_Grounds_Big_Key);
			RegionKeys.Add(Item.Temple_of_Time_Big_Key);
			RegionKeys.Add(Item.Snowpeak_Ruins_Bedroom_Key);
			RegionKeys.Add(Item.City_in_The_Sky_Big_Key);
			RegionKeys.Add(Item.Palace_of_Twilight_Big_Key);
			RegionKeys.Add(Item.Hyrule_Castle_Big_Key);
			regionItems.AddRange(RegionKeys);
			heldItems.Add(Item.Gate_Keys);
			heldItems.Add(Item.Small_Key_N_Faron_Gate);
			heldItems.AddRange(ImportantItems);
			heldItems.AddRange(RegionKeys);

			Singleton.getInstance().Items.heldItems = heldItems;
			Singleton.getInstance().Items.regionItems = regionItems;
			return;
		}
	}

}

