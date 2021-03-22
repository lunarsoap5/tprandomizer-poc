using System;
using Assets.Items;
using Logic;

namespace Randomizer
{
	class Randomizer
	{
		Random rnd = new Random();
		LogicFunctions Logic = new LogicFunctions();

		bool test = true;
		
		list<uint8_t> HeldImportantItems = {/*all important item ids*/};

		void restAllRoomsVisited()
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

		struct Check
		{
			string checkName; //the common name for the check this can be used in the randomizer to identify the check."
			bool empty; //Identifies if we already placed an item on this check (starts at true)
			list<Requirement> requirments; //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
			uint16_t hash; //the fletcher hash that will be compared to on stage load
			bool isExcluded; //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
			list<class> checkCategory; //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
			byte itemId; //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
		}

		struct Room
		{
			string name; //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
			list<Room*> neighbours; //Refers to the rooms of the same stage that can be accesed from this room
			list<list<Requirement>> neighbourRequirments; //List of list of requirements to enter each neighbouring room
			bool isStartingRoom; //Defines if it is the stage you start the game in
			list<Check*> checks; //Checks contained inside the room
			bool visited;
			string region;
		}

		Room* setupGraph()
		{
			resetAllRoomsVisited();
			
			
			rooms[145].isStartingRoom = true;
			return &rooms[145];
		}

		bool checkIfItemIsInList(uint8_t item, list<uint8_t> itemList)
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

		/*pseudocode. will need to be edited */

		bool areItemRequirementsMet(list<Requirement> requirments)
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

		list<*Check> listAllAvailableChecks(*Room startingRoom)
		{
			restAllRoomsVisited();
			list<*Check> checks = {};
			list<*Room> roomsToExplore = {};
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

		list<int> PlacedImportantItems = {};

		int nbSkybooksPlaced = 0;

		int verifyItem (int item)
		{
			switch (item) //Make sure you place the items in the right order (from big to small)
			{
				case 0xE9:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0xDB:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0xDC:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0xDD:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0xDE:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0xDF:
					if (nbSkybooksPlaced <= 5)
					{
						item = 0xEA; //Ancient_Sky_Book_partly_filled
					}
					else
					{
						item = 0xE9; //Ancient_Sky_Book_empty
					}
					nbSkybooksPlaced++;
					break;
				case 0x44:
					if (!checkIfItemIsInList(0x47, PlacedImportantItems))
					{
						item = 0x47; //Double_Clawshot
					}
					break;
				case 0x46:
					if (!checkIfItemIsInList(0x4C, PlacedImportantItems))
					{
						item = 0x4C; //Charged_Dominion_Rod
					}
					break;
				case 0x35:
					if (!checkIfItemIsInList(0x36, PlacedImportantItems))
					{
						item = 0x36; //Giant_Wallet
					}
					break;
				case 0x55:
					if (!checkIfItemIsInList(0x56, PlacedImportantItems))
					{
						item = 0x56; //Giant_Quiver
					}
				case 0x43:
					if (!checkIfItemIsInList(0x56, PlacedImportantItems))
					{
						item = 0x56; //Giant_Quiver
					}
					else if (!checkIfItemIsInList(0x55, PlacedImportantItems))
					{
						item = 0x55; //Big_Quiver
					}
					break;
				case 0x29:
					if (!checkIfItemIsInList(0x49, PlacedImportantItems))
					{
						item = 0x49; //Light_Sword
					}
					break;
				case 0x28:
					if (!checkIfItemIsInList(0x49, PlacedImportantItems))
					{
						item = 0x49; //Light_Sword
					}
					else if (!checkIfItemIsInList(0x29, PlacedImportantItems))
					{
						item = 0x29; //Master_Sword
					}
					break;
				case 0x3F:
					if (!checkIfItemIsInList(0x49, PlacedImportantItems))
					{
						item = 0x49; //Light_Sword
					}
					else if (!checkIfItemIsInList(0x29, PlacedImportantItems))
					{
						item = 0x29; //Master_Sword
					}
					else if (!checkIfItemIsInList(0x28, PlacedImportantItems))
					{
						item = 0x28; //Ordon_Sword
					}
					break;
				case 0xE6:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					break;
				case 0xE5:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					else if (!checkIfItemIsInList(0xE6, PlacedImportantItems))
					{
						item = 0xE6; //Jump_Strike
					}
					break;
				case 0xE4:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					else if (!checkIfItemIsInList(0xE6, PlacedImportantItems))
					{
						item = 0xE6; //Jump_Strike
					}
					else if (!checkIfItemIsInList(0xE5, PlacedImportantItems))
					{
						item = 0xE5; //Mortal_Draw
					}
					break;
				case 0xE3:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					else if (!checkIfItemIsInList(0xE6, PlacedImportantItems))
					{
						item = 0xE6; //Jump_Strike
					}
					else if (!checkIfItemIsInList(0xE5, PlacedImportantItems))
					{
						item = 0xE5; //Mortal_Draw
					}
					else if (!checkIfItemIsInList(0xE4, PlacedImportantItems))
					{
						item = 0xE4; //Helm_Splitter
					}
					break;
				case 0xE2:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					else if (!checkIfItemIsInList(0xE6, PlacedImportantItems))
					{
						item = 0xE6; //Jump_Strike
					}
					else if (!checkIfItemIsInList(0xE5, PlacedImportantItems))
					{
						item = 0xE5; //Mortal_Draw
					}
					else if (!checkIfItemIsInList(0xE4, PlacedImportantItems))
					{
						item = 0xE4; //Helm_Splitter
					}
					else if (!checkIfItemIsInList(0xE3, PlacedImportantItems))
					{
						item = 0xE3; //Back_Slice
					}
					break;
				case 0xE1:
					if (!checkIfItemIsInList(0xE7, PlacedImportantItems))
					{
						item = 0xE7; //Great_Spin
					}
					else if (!checkIfItemIsInList(0xE6, PlacedImportantItems))
					{
						item = 0xE6; //Jump_Strike
					}
					else if (!checkIfItemIsInList(0xE5, PlacedImportantItems))
					{
						item = 0xE5; //Mortal_Draw
					}
					else if (!checkIfItemIsInList(0xE4, PlacedImportantItems))
					{
						item = 0xE4; //Helm_Splitter
					}
					else if (!checkIfItemIsInList(0xE3, PlacedImportantItems))
					{
						item = 0xE3; //Back_Slice
					}
					else if (!checkIfItemIsInList(0xE2, PlacedImportantItems))
					{
						item = 0xE2; //Shield_Attack
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