using System;
using Assets.Items;
using Logic;
using System.Collections.Generic;

namespace Randomizer
{
	class Randomizer
	{
		int forestTempleSmallKeyCount;
		int goronMinesSmallKeyCount;
		int lakebedTempleSmallKeyCount;
		int arbitersGroundsSmallKeyCount;
		int snowpeakRuinsSmallKeyCount;
		int templeofTimeSmallKeyCount;
		int cityinTheSkySmallKeyCount;
		int palaceofTwilightSmallKeyCount;
		int hyruleCastleSmallKeyCount;
		int fusedShadowCount;
		int mirrorShardCount;

		bool mdhComplete;
		bool diababaDefeated;
		bool fyrusDefeated;
		bool morpheelDefeated;
		bool stallordDefeated;
		bool blizzetaDefeated;
		bool armogohmaDefeated;
		bool argorokDefeated;
		bool zantDefeated;
		bool ganondorfDefeated;
		Random rnd = new Random();
		LogicFunctions Logic = new LogicFunctions();
		

		struct Check
		{
			string checkName { get; set;} //the common name for the check this can be used in the randomizer to identify the check."
			bool empty { get; set;} //Identifies if we already placed an item on this check (starts at true)
			bool logicalCondition { get; set;} //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
			ushort hash { get; set;} //the fletcher hash that will be compared to on stage load
			bool isExcluded { get; set;} //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
			List<string> checkCategory { get; set;} //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
			Item itemId { get; set;} //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
		}

		struct Room
		{
			string name { get; set;} //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
			List<Room*> neighbours { get; set;} //Refers to the rooms of the same stage that can be accesed from this room
			List<List<bool>> neighbourRequirments { get; set;} //List of list of requirements to enter each neighbouring room
			bool isStartingRoom { get; set;} //Defines if it is the stage you start the game in
			List<Check*> checks { get; set;} //Checks contained inside the room
			bool visited { get; set;}
			string region { get; set;}
		}

		
		list<uint8_t> HeldImportantItems = {/*all important item ids*/};
		void resetAllRoomsVisited()
		{
			for (int i = 0; i < rooms.count(); i++)
			{
				rooms[i].visited = false;
			}
			if (test == Logic.canUse(Item.Master_Sword))
			{
				test = false;
			}
		}

		Room* setupGraph()
		{
			resetAllRoomsVisited();
			
			
			rooms[145].isStartingRoom = true;
			return &rooms[145];
		}

		bool checkIfItemIsInList(byte item, List<byte> itemList)
		{
			bool isItemPresent = false;
			for (int j = 0; j < itemList.count(); j++)
			{
				if (item == itemList[j])
				{
					isItemPresent = true;
					break;
				}
			}
			
			return isItemPresent;
		}


		bool areItemRequirementsMet(List<Requirement> requirments)
		{    
			bool areRequirementsMet = true;
			
			for (int i = 0; i < requirments.count(); i++)
			{
				areRequirementsMet = false;
				for (int j = 0; j < HeldImportantItems.count(); j++)
				{
					if (isRequirementMet(requirments[i]))
					{
						areRequirementsMet = true;
						break;
					}
				}
				if (areRequirementsMet == false)
				{
					break;
				}
			}
			
			return areRequirementsMet;
		}

		List<*Check> listAllAvailableChecks(*Room startingRoom)
		{
			restAllRoomsVisited();
			List<*Check> checks = {};
			List<*Room> roomsToExplore = {};
			startingRoom->visited = true;
			roomsToExplore.add(startingRoom);
			
			while (roomsToExplore.count() > 0)
			{
				for (int i = 0; i < roomsToExplore[0]->neighbours.count(); i++)
				{
					if (areItemRequirementsMet(roomsToExplore[0]->neighbourRequirments[i]) && roomsToExplore[0]->neighbours[i]->visited == false)
					{
						roomsToExplore[0]->neighbours[i]->visited = true;
						roomsToExplore.add(roomsToExplore[0]->neighbours[i]);
					}
				}
				for (int i = 0; i < roomsToExplore[0]->checks.count(); i++)
				{
					if (areItemRequirementsMet(roomsToExplore[0]->checks[i]->requirments) && roomsToExplore[0]->checks[i]->itemWasPlaced == false)
					{
						checks.add(roomsToExplore[0]->checks[i]);
					}
				}
				roomsToExplore.remove(roomsToExplore[0]);
			}
			
			retrun checks;
			
		}

		bool checkIfItemNotNeededToReachCheck(int item, *Check check, *Room startingRoom)
		{
			restAllRoomsVisited();
			list<*Room> roomsToExplore = {};
			startingRoom->visited = true;
			roomsToExplore.add(startingRoom);
			
			while (roomsToExplore.count() > 0)
			{
				for (int i = 0; i < roomsToExplore[0]->checks.count(); i++)
				{
					if (roomsToExplore[0]->checks[i] == check)
					{
						return areItemRequirementsMet(roomsToExplore[0]->checks[i]->requirments) &&
							!checkIfItemIsInList(item, getRequirementItems(roomsToExplore[0]->checks[i]->requirments)) &&
							roomsToExplore[0]->checks[i]->itemWasPlaced == false;
					}
				}
				for (int i = 0; i < roomsToExplore[0]->neighbours.count(); i++)
				{
					if (areItemRequirementsMet(roomsToExplore[0]->neighbourRequirments[i]) && !checkIfItemIsInList(item, getRequirementItems(roomsToExplore[0]->neighbourRequirments[i]))
						&& roomsToExplore[0]->neighbours[i]->visited == false)
					{
						roomsToExplore[0]->neighbours[i]->visited = true;
						roomsToExplore.add(roomsToExplore[0]->neighbours[i]);
					}
				}
				roomsToExplore.remove(roomsToExplore[0]);
			}
			return false;
		}

		List<int> PlacedImportantItems = {};

		int nbSkybooksPlaced = 0;

		Item verifyItem (Item item)
		{
			switch (item) //Make sure you place the items in the right order (from big to small)
			{
				case Item.Ancient_Sky_Book_Empty:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_First_Character:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Second_Character:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Third_Character:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Fourth_Character:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Ancient_Sky_Book_Fifth_Character:
					if (nbSkybooksPlaced <= 5)
					{
						item = Item.Ancient_Sky_Book_Partly_Filled; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = Item.Ancient_Sky_Book_Empty; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case Item.Clawshot:
					if (Logic.canUse(Item.Double_Clawshot))
					{
						item = Item.Double_Clawshot; //Double_Clawshot
					}
					break;
				case Item.Dominion_Rod_Uncharged:
					if (Logic.canUse(Item.Dominion_Rod))
					{
						item = Item.Dominion_Rod; //Charged_Dominion_Rod
					}
					break;
				case Item.Big_Wallet:
					if (Logic.canUse(Item.Giant_Wallet))
					{
						item = Item.Giant_Wallet; //Giant_Wallet
					}
					break;
				case Item.Big_Quiver:
					if (Logic.canUse(Item.Giant_Quiver))
					{
						item = Item.Giant_Quiver; //Giant_Quiver
					}
					break;
				case Item.Heros_Bow:
					if (Logic.canUse(Item.Giant_Quiver))
					{
						item = Item.Giant_Quiver; //Giant_Quiver
					}
					else if (Logic.canUse(Item.Big_Quiver))
					{
						item = Item.Big_Quiver; //Big_Quiver
					}
					break;
				case Item.Master_Sword:
					if (Logic.canUse(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					break;
				case Item.Ordon_Sword:
					if (Logic.canUse(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					else if (Logic.canUse(Item.Master_Sword))
					{
						item = Item.Master_Sword; //Master_Sword
					}
					break;
				case Item.Wooden_Sword:
					if (Logic.canUse(Item.Master_Sword_Light))
					{
						item = Item.Master_Sword_Light; //Light_Sword
					}
					else if (Logic.canUse(Item.Master_Sword))
					{
						item = Item.Master_Sword; //Master_Sword
					}
					else if (Logic.canUse(Item.Ordon_Sword))
					{
						item = Item.Ordon_Sword; //Ordon_Sword
					}
					break;
				case Item.Jump_Strike:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					break;
				case Item.Mortal_Draw:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (Logic.canUse(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					break;
				case Item.Helm_Splitter:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (Logic.canUse(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (Logic.canUse(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					break;
				case Item.Back_Slice:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (Logic.canUse(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (Logic.canUse(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (Logic.canUse(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					break;
				case Item.Shield_Attack:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (Logic.canUse(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (Logic.canUse(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (Logic.canUse(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					else if (Logic.canUse(Item.Back_Slice))
					{
						item = Item.Back_Slice; //Back_Slice
					}
					break;
				case Item.Ending_Blow:
					if (Logic.canUse(Item.Great_Spin))
					{
						item = Item.Great_Spin; //Great_Spin
					}
					else if (Logic.canUse(Item.Jump_Strike))
					{
						item = Item.Jump_Strike; //Jump_Strike
					}
					else if (Logic.canUse(Item.Mortal_Draw))
					{
						item = Item.Mortal_Draw; //Mortal_Draw
					}
					else if (Logic.canUse(Item.Helm_Splitter))
					{
						item = Item.Helm_Splitter; //Helm_Splitter
					}
					else if (Logic.canUse(Item.Back_Slice))
					{
						item = Item.Back_Slice; //Back_Slice
					}
					else if (Logic.canUse(Item.Shield_Attack))
					{
						item = Item.Shield_Attack; //Shield_Attack
					}
					break;
			}
			return item;
		}


		void placeItemInCheck(int item, *Check check)
		{
			check->itemWasPlaced = true;
			int itemToPlaceInCheck = item;
			HeldImportantItems.remove(item);
			PlacedImportantItems.add(item);
			... //Perform whatever is needed to insert the item in the check
		}

		void startOver(*Room startingRoom)
		{
			nbSkybooksPlaced = 0;
			for (int i = 0; i< PlacedImportantItems.count(); i++)
			{
				HeldImportantItems.add(PlacedImportantItems[i]);
			}
			PlacedImportantItems = {};
			//empty all checks of their items  
			placeRequiredItems(startingRoom);
		}

		void placeRequiredItems(*Room startingRoom)
		{
			list<*Check> availableChecks = listAllAvailableChecks(startingRoom);
			int itemToPlace = verifyItem(HeldImportantItems[rnd.next(HeldImportantItems.count()-1)]);
			*Check checkToReciveItem = availableChecks[rnd.next(availableChecks.count()-1)];
			
			while (HeldImportantItems.count() > 0 && availableChecks > 0)
			{
				while (!checkIfItemNotNeededToReachCheck(itemToPlace, checkToReciveItem, startingRoom))
				{
					checkToReciveItem = availableChecks[rnd.next(availableChecks.count()-1)];
				}
				
				placeItemInCheck(itemToPlace,checkToReciveItem);
				
				availableChecks = listAllAvailableChecks(startingRoom);
				itemToPlace = verifyItem(HeldImportantItems[rnd.next(HeldImportantItems.count()-1)]);
				checkToReciveItem = availableChecks[rnd.next(availableChecks.count()-1)];
			}
			if (HeldImportantItems.count() > 0)
			{//no more available checks and still items to place, starting over
				//failsafe: assumed fill can fail, but rarely, so it is best to start over if it happens
				startOver(startingRoom);
			}
		}

		void Main()
		{
			*Room startingRoom = setupGraph();    
			placeShopItems(startingRoom);
			placeDungeonItems(startingRoom);
			placeProgressiveItems(startingRoom);
			placeRequiredItems(startingRoom);
			placeOtherItems(startingRoom);
		}
	}
}