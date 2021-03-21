using System;
using includes.Items;
using Requirements;
using Rooms;


Random rnd = new Random();


list<uint8_t> HeldImportantItems = {/*all important item ids*/};

void restAllRoomsVisited()
{
    for (int i = 0; i < rooms.count(); i++)
    {
        rooms[i].visited = false;
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
    uint8_t itemId; //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
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
    
    //Lakebed Temple
    lakebed_temple_00_01.neighbours.add(rooms[158]); 
    lakebed_temple_00_01.neighbours.add(rooms[1]);  

    rooms[1].neighbours.add(rooms[0]);
    rooms[1].neighbours.add(rooms[4]);
    rooms[1].neighbours.add(rooms[5]);
    rooms[1].neighbours.add(rooms[9]);
    rooms[1].neighbours.add(rooms[12]);

    rooms[2].neighbours.add(rooms[9]);
	rooms[2].neighbours.add(rooms[3]);
	
    rooms[3].neighbours.add(rooms[2]);
	
    rooms[4].neighbours.add(rooms[1]);
	rooms[4].neighbours.add(rooms[7]);
	rooms[4].neighbours.add(rooms[5]);
	
    rooms[5].neighbours.add(rooms[1]);
	rooms[5].neighbours.add(rooms[6]);
	
    rooms[6].neighbours.add(rooms[5]);
	rooms[6].neighbours.add(rooms[11]);
	
    rooms[7].neighbours.add(rooms[4]);
	
    rooms[8].neighbours.add(rooms[1]);
	rooms[8].neighbours.add(rooms[9]);
	rooms[8].neighbours.add(rooms[10]);
	
    rooms[9].neighbours.add(rooms[8]);
	rooms[9].neighbours.add(rooms[1]);
	rooms[9].neighbours.add(rooms[2]);
	
    rooms[10].neighbours.add(rooms[8]);
	
    rooms[11].neighbours.add(rooms[6]);
	
    rooms[12].neighbours.add(rooms[158]);
    
    //Goron Mines
    rooms[13].neighbours.add(rooms[175]);
	rooms[13].neighbours.add(rooms[14]);
	
    rooms[14].neighbours.add(rooms[13]);
	rooms[14].neighbours.add(rooms[15]);
	rooms[14].neighbours.add(rooms[16]);
	
    rooms[15].neighbours.add(rooms[14]);
	rooms[15].neighbours.add(rooms[22]);
	
    rooms[16].neighbours.add(rooms[14]);
	rooms[16].neighbours.add(rooms[17]);
	
    rooms[17].neighbours.add(rooms[16]);
	rooms[17].neighbours.add(rooms[18]);
	rooms[17].neighbours.add(rooms[20]);
	
    rooms[18].neighbours.add(rooms[17]);
	rooms[18].neighbours.add(rooms[25]);
	
    rooms[19].neighbours.add(rooms[25]);
	rooms[19].neighbours.add(rooms[21]);
	rooms[19].neighbours.add(rooms[23]);
	
    rooms[20].neighbours.add(rooms[17]);
	rooms[20].neighbours.add(rooms[24]);
	
    rooms[21].neighbours.add(rooms[19]);
	rooms[21].neighbours.add(rooms[14]);
	
    rooms[22].neighbours.add(rooms[15]);
	
    rooms[23].neighbours.add(rooms[19]);
	
    rooms[24].neighbours.add(rooms[152]);
	
	rooms[25].neighbours.add(rooms[18]);
	
    rooms[25].neighbours.add(rooms[19]);

    //Forest Temple
    rooms[26].neighbours.add(rooms[36]);
	rooms[26].neighbours.add(rooms[27]);
	rooms[26].neighbours.add(rooms[28]);
	rooms[26].neighbours.add(rooms[31]);
	rooms[26].neighbours.add(rooms[37]);
	
    rooms[27].neighbours.add(rooms[26]);
	
    rooms[28].neighbours.add(rooms[26]);
	rooms[28].neighbours.add(rooms[29]);
	rooms[28].neighbours.add(rooms[30]);
	rooms[28].neighbours.add(rooms[37]);
	
    rooms[29].neighbours.add(rooms[28]);
	
    rooms[30].neighbours.add(rooms[28]);
	
    rooms[31].neighbours.add(rooms[26]);
	rooms[31].neighbours.add(rooms[32]);
	rooms[31].neighbours.add(rooms[33]);
	rooms[31].neighbours.add(rooms[34]);
	
    rooms[32].neighbours.add(rooms[31]);
	
    rooms[33].neighbours.add(rooms[31]);
	
    rooms[34].neighbours.add(rooms[31]);
	rooms[34].neighbours.add(rooms[35]);
	rooms[34].neighbours.add(rooms[38]);
	
    rooms[35].neighbours.add(rooms[34]);
	
    rooms[36].neighbours.add(rooms[151]);
	rooms[36].neighbours.add(rooms[26]);
	
    rooms[37].neighbours.add(rooms[28]);
	
    rooms[38].neighbours.add(rooms[148]);
    
	//Temple of Time
	rooms[39].neighbours.add(rooms[162]);
	rooms[39].neighbours.add(rooms[40]);
	rooms[39].neighbours.add(rooms[47]);
	
    rooms[40].neighbours.add(rooms[39]);
	rooms[40].neighbours.add(rooms[41]);
	
    rooms[41].neighbours.add(rooms[40]);
	rooms[41].neighbours.add(rooms[42]);
	rooms[41].neighbours.add(rooms[43]);
	
    rooms[42].neighbours.add(rooms[41]);
	
    rooms[43].neighbours.add(rooms[41]);
	rooms[43].neighbours.add(rooms[44]);
	
    rooms[44].neighbours.add(rooms[43]);
	rooms[44].neighbours.add(rooms[45]);
	rooms[44].neighbours.add(rooms[46]);
	
    rooms[45].neighbours.add(rooms[44]);
	
    rooms[46].neighbours.add(rooms[44]);
	rooms[46].neighbours.add(rooms[48]);
	
    rooms[47].neighbours.add(rooms[39]);
	rooms[47].neighbours.add(rooms[49]);
	
    rooms[48].neighbours.add(rooms[46]);
	
    rooms[49].neighbours.add(rooms[162]);
	
	//City in The Sky
    rooms[50].neighbours.add(rooms[158]);
	rooms[50].neighbours.add(rooms[51]);
	
    rooms[51].neighbours.add(rooms[50]);
	rooms[51].neighbours.add(rooms[52]);
	
    rooms[52].neighbours.add(rooms[51]);
	rooms[52].neighbours.add(rooms[53]);
	rooms[52].neighbours.add(rooms[55]);
	rooms[52].neighbours.add(rooms[63]);
	
    rooms[53].neighbours.add(rooms[52]);
	rooms[53].neighbours.add(rooms[56]);
	
    rooms[54].neighbours.add(rooms[53]);
	rooms[54].neighbours.add(rooms[57]);
	rooms[54].neighbours.add(rooms[65]);
	
    rooms[55].neighbours.add(rooms[52]);
	rooms[55].neighbours.add(rooms[59]);
	
    rooms[56].neighbours.add(rooms[53]);
	rooms[56].neighbours.add(rooms[58]);
	
    rooms[57].neighbours.add(rooms[58]);
	rooms[57].neighbours.add(rooms[54]);
	
    rooms[58].neighbours.add(rooms[56]);
	rooms[58].neighbours.add(rooms[57]);
	
    rooms[59].neighbours.add(rooms[55]);
	rooms[59].neighbours.add(rooms[60]);
	
    rooms[60].neighbours.add(rooms[59]);
	rooms[60].neighbours.add(rooms[61]);
	
    rooms[61].neighbours.add(rooms[60]);
	rooms[61].neighbours.add(rooms[62]);
	
    rooms[62].neighbours.add(rooms[61]);
	rooms[62].neighbours.add(rooms[52]);
	
    rooms[63].neighbours.add(rooms[52]);
	rooms[63].neighbours.add(rooms[64]);
	
    rooms[64].neighbours.add(rooms[50]);
	
    rooms[65].neighbours.add(rooms[54]);

    //Palace of Twilight
    rooms[66].neighbours.add(rooms[173]);
	rooms[66].neighbours.add(rooms[67]);
	rooms[66].neighbours.add(rooms[68]);
	rooms[66].neighbours.add(rooms[70]);
	
    rooms[67].neighbours.add(rooms[66]);
	rooms[67].neighbours.add(rooms[74]);
	
    rooms[68].neighbours.add(rooms[66]);
	rooms[68].neighbours.add(rooms[69]);
	
    rooms[69].neighbours.add(rooms[68]);
	rooms[69].neighbours.add(rooms[75]);
	
    rooms[70].neighbours.add(rooms[66]);
	rooms[70].neighbours.add(rooms[73]);
	
    rooms[71].neighbours.add(rooms[73]);
	rooms[71].neighbours.add(rooms[72]);
	
    rooms[72].neighbours.add(rooms[71]);
	rooms[72].neighbours.add(rooms[76]);
	
    rooms[73].neighbours.add(rooms[70]);
	rooms[73].neighbours.add(rooms[73]);
	
    rooms[74].neighbours.add(rooms[67]);
	
    rooms[75].neighbours.add(rooms[69]);
	
    rooms[76].neighbours.add(rooms[66]);
	
	
	//Hyrule Castle
    rooms[77].neighbours.add(rooms[85]);
	rooms[77].neighbours.add(rooms[78]);
	
    rooms[78].neighbours.add(rooms[77]);
	rooms[78].neighbours.add(rooms[79]);
	rooms[78].neighbours.add(rooms[81]);
	
    rooms[79].neighbours.add(rooms[78]);
	rooms[79].neighbours.add(rooms[80]);
	
    rooms[80].neighbours.add(rooms[79]);
	rooms[80].neighbours.add(rooms[77]);
	rooms[80].neighbours.add(rooms[89]);
	
    rooms[81].neighbours.add(rooms[78]);
	rooms[81].neighbours.add(rooms[82]);
	
    rooms[82].neighbours.add(rooms[81]);
	rooms[82].neighbours.add(rooms[77]);
	rooms[82].neighbours.add(rooms[89]);
	
    rooms[83].neighbours.add(rooms[86]);
	
    rooms[84].neighbours.add(rooms[88]);
	
    rooms[85].neighbours.add(rooms[159]);
	rooms[85].neighbours.add(rooms[77]);
	rooms[85].neighbours.add(rooms[87]);
	rooms[85].neighbours.add(rooms[88]);
	
    rooms[86].neighbours.add(rooms[89]);
	rooms[86].neighbours.add(rooms[83]);
	rooms[86].neighbours.add(rooms[90]);
	
    rooms[87].neighbours.add(rooms[85]);
	
    rooms[88].neighbours.add(rooms[85]);
	rooms[88].neighbours.add(rooms[84]);
	
    rooms[89].neighbours.add(rooms[80]);
	rooms[89].neighbours.add(rooms[82]);
	rooms[89].neighbours.add(rooms[86]);
	
    rooms[90].neighbours.add(rooms[86]);
	
	//Arbiter's Grounds
    rooms[91].neighbours.add(rooms[164]);
	rooms[91].neighbours.add(rooms[92]);
	
    rooms[92].neighbours.add(rooms[91]);
	rooms[92].neighbours.add(rooms[93]);
	
    rooms[93].neighbours.add(rooms[92]);
	rooms[93].neighbours.add(rooms[97]);
	rooms[93].neighbours.add(rooms[94]);
	rooms[93].neighbours.add(rooms[95]);
	rooms[93].neighbours.add(rooms[99]);
	
    rooms[94].neighbours.add(rooms[93]);
	
    rooms[95].neighbours.add(rooms[93]);
	rooms[95].neighbours.add(rooms[96]);
	
    rooms[96].neighbours.add(rooms[95]);
	rooms[96].neighbours.add(rooms[104]);
	
    rooms[97].neighbours.add(rooms[93]);
	rooms[97].neighbours.add(rooms[102]);
	
    rooms[98].neighbours.add(rooms[102]);
	rooms[98].neighbours.add(rooms[97]);
	
    rooms[99].neighbours.add(rooms[93]);
	rooms[99].neighbours.add(rooms[105]);
	rooms[99].neighbours.add(rooms[106]);
	
    rooms[100].neighbours.add(rooms[105]);
	rooms[100].neighbours.add(rooms[101]);
	
    rooms[101].neighbours.add(rooms[100]);
	rooms[101].neighbours.add(rooms[107]);
	rooms[101].neighbours.add(rooms[103]);
	
    rooms[102].neighbours.add(rooms[97]);
	rooms[102].neighbours.add(rooms[98]);
	
    rooms[103].neighbours.add(rooms[101]);
	rooms[103].neighbours.add(rooms[99]);
	
    rooms[104].neighbours.add(rooms[96]);
	rooms[104].neighbours.add(rooms[93]);
	
    rooms[105].neighbours.add(rooms[99]);
	rooms[105].neighbours.add(rooms[100]);
	
    rooms[106].neighbours.add(rooms[173]);
	
    rooms[107].neighbours.add(rooms[101]);

    //Snowpeak Ruins
    rooms[108].neighbours.add(rooms[157]);
	rooms[108].neighbours.add(rooms[114]);
	rooms[108].neighbours.add(rooms[110]);
	rooms[108].neighbours.add(rooms[109]);
	
    rooms[109].neighbours.add(rooms[108]);
	rooms[109].neighbours.add(rooms[110]);
	rooms[109].neighbours.add(rooms[118]);
	
    rooms[110].neighbours.add(rooms[108]);
	rooms[110].neighbours.add(rooms[109]);
	rooms[110].neighbours.add(rooms[116]);
	rooms[110].neighbours.add(rooms[117]);
	rooms[110].neighbours.add(rooms[120]);
	rooms[110].neighbours.add(rooms[119]);
	
    rooms[111].neighbours.add(rooms[118]);
	rooms[111].neighbours.add(rooms[108]);
	
    rooms[112].neighbours.add(rooms[111]);
	rooms[112].neighbours.add(rooms[108]);
	
    rooms[113].neighbours.add(rooms[108]);
	rooms[113].neighbours.add(rooms[109]);
	rooms[113].neighbours.add(rooms[112]);
	rooms[113].neighbours.add(rooms[114]);
	
    rooms[114].neighbours.add(rooms[108]);
	rooms[114].neighbours.add(rooms[113]);
	rooms[114].neighbours.add(rooms[115]);
	
    rooms[115].neighbours.add(rooms[116]);
	
    rooms[116].neighbours.add(rooms[110]);
	rooms[116].neighbours.add(rooms[115]);
	
    rooms[117].neighbours.add(rooms[110]);
	
    rooms[118].neighbours.add(rooms[109]);
	rooms[118].neighbours.add(rooms[111]);
	
    rooms[119].neighbours.add(rooms[157]);
	
    rooms[120].neighbours.add(rooms[110]);

	//Lanayru Ice Puzzle Cave
    rooms[121].neighbours.add(rooms[168]);
	
	//Cave of Ordeals
    rooms[122].neighbours.add(rooms[172]);
	rooms[122].neighbours.add(rooms[123]);
	
    rooms[123].neighbours.add(rooms[147]);
	rooms[123].neighbours.add(rooms[124]);
	
    rooms[124].neighbours.add(rooms[148]);
	rooms[124].neighbours.add(rooms[125]);
	
	rooms[125].neighbours.add(rooms[152]);
	rooms[125].neighbours.add(rooms[126]);

	rooms[126].neighbours.add(rooms[158]);
    //Eldin Long Cave
    rooms[127].neighbours.add(rooms[166]);
    //Lake Hylia Long Cave
    rooms[128].neighbours.add(rooms[158]);
    //Goron Stockcave
    rooms[129].neighbours.add(rooms[165]);
    //West Castle Town Helmasaur Grotto
    rooms[130].neighbours.add(rooms[170]);
    //Eldin Bomskit Grotto
    rooms[131].neighbours.add(rooms[165]);
    //Ordon Ranch Grotto
    rooms[132].neighbours.add(rooms[147]);
    //Lanayru Double Poe Grotto
    rooms[133].neighbours.add(rooms[168]);
    //Lanayru Stalfos Grotto
    rooms[134].neighbours.add(rooms[168]);
    //Faron Field Rat,Chu, Keese Grotto
    rooms[135].neighbours.add(rooms[167]);
    //Sacred Grove Baba Serpent Grotto
    rooms[136].neighbours.add(rooms[161]);
    //Gerudo Desert Double Poe Grotto
    rooms[137].neighbours.add(rooms[172]);
    //Lake Hylia Bridge Bubble Grotto
    rooms[138].neighbours.add(rooms[169]);
    //Gerudo Desert Skulltula Grotto
    rooms[139].neighbours.add(rooms[172]);
    //Snowpeak Frezard Grotto
    rooms[140].neighbours.add(rooms[156]);
    //Lanayru Skulltula Grotto
    rooms[141].neighbours.add(rooms[168]);
    //South Castle Town Tetike Grotto
    rooms[142].neighbours.add(rooms[171]);
    //Lake Hylia Toadpoli Grotto
    rooms[143].neighbours.add(rooms[158]);
    //Eldin Field Bombfish Grotto
    rooms[144].neighbours.add(rooms[165]);
    //Lake Hylia Shell Blade Grotto
    rooms[145].neighbours.add(rooms[158]);
    //South Faron Woods Cave
    rooms[146].neighbours.add(rooms[148]);
	rooms[146].neighbours.add(rooms[149]);
    //Ordon Province
    rooms[147].neighbours.add(rooms[148]);
    //South Faron Woods
    rooms[148].neighbours.add(rooms[147]);
	rooms[148].neighbours.add(rooms[167]);
	rooms[148].neighbours.add(rooms[146]);
	rooms[148].neighbours.add(rooms[149]);
    //Faron Mist Area
    rooms[149].neighbours.add(rooms[146]);
	rooms[149].neighbours.add(rooms[150]);
	rooms[149].neighbours.add(rooms[151]);
    //Faron Mist Cave
    rooms[150].neighbours.add(rooms[149]);
    //North Faron Woods
    rooms[151].neighbours.add(rooms[149]);
	rooms[151].neighbours.add(rooms[36]);
	rooms[151].neighbours.add(rooms[160]);
    //Kakariko Village
    rooms[152].neighbours.add(rooms[166]);
	rooms[152].neighbours.add(rooms[165]);
	rooms[152].neighbours.add(rooms[153]);
	rooms[152].neighbours.add(rooms[158]);
    //Death Mountain Trail
    rooms[153].neighbours.add(rooms[152]);
	rooms[153].neighbours.add(rooms[154]);
    //Death Mountain Volcano
    rooms[154].neighbours.add(rooms[153]);
	rooms[154].neighbours.add(rooms[175]);
    //Zora's Domain
    rooms[155].neighbours.add(rooms[168]);
	rooms[155].neighbours.add(rooms[156]);
    //Snowpeak Climb
    rooms[156].neighbours.add(rooms[155]);
	rooms[156].neighbours.add(rooms[157]);
	rooms[156].neighbours.add(rooms[140]);
    //Snowpeak Summit
    rooms[157].neighbours.add(rooms[156]);
	rooms[157].neighbours.add(rooms[108]);
    //Lake Hylia
    rooms[158].neighbours.add(rooms[172]);
	rooms[158].neighbours.add(rooms[128]);
	rooms[158].neighbours.add(rooms[143]);
	rooms[158].neighbours.add(rooms[145]);
	rooms[158].neighbours.add(rooms[0]);
	rooms[158].neighbours.add(rooms[50]);
	rooms[158].neighbours.add(rooms[169]);
	rooms[158].neighbours.add(rooms[155]);
    //Castle Town
    rooms[159].neighbours.add(rooms[170]);
	rooms[159].neighbours.add(rooms[165]);
	rooms[159].neighbours.add(rooms[171]);
	rooms[159].neighbours.add(rooms[85]);
    //Lost Woods
    rooms[160].neighbours.add(rooms[151]);
	rooms[160].neighbours.add(rooms[161]);
    //Sacred Grove - Master Sword
    rooms[161].neighbours.add(rooms[160]);
	rooms[161].neighbours.add(rooms[162]);
	rooms[161].neighbours.add(rooms[136]);
    //Sacred Grove - Temple of Time
    rooms[162].neighbours.add(rooms[161]);
	rooms[162].neighbours.add(rooms[39]);
    //Bublin Camp
    rooms[163].neighbours.add(rooms[172]);
	rooms[163].neighbours.add(rooms[164]);
    //Outside Arbiter's Grounds
    rooms[164].neighbours.add(rooms[163]);
	rooms[164].neighbours.add(rooms[91]);
    //Eldin Field
    rooms[165].neighbours.add(rooms[166]);
	rooms[165].neighbours.add(rooms[152]);
	rooms[165].neighbours.add(rooms[129]);
	rooms[165].neighbours.add(rooms[159]);
	rooms[165].neighbours.add(rooms[168]);
	rooms[165].neighbours.add(rooms[144]);
	rooms[165].neighbours.add(rooms[131]);
    //Kakariko Gorge
    rooms[166].neighbours.add(rooms[165]);
	rooms[166].neighbours.add(rooms[167]);
	rooms[166].neighbours.add(rooms[152]);
	rooms[166].neighbours.add(rooms[127]);
    //Faron Field
    rooms[167].neighbours.add(rooms[148]);
	rooms[167].neighbours.add(rooms[171]);
	rooms[167].neighbours.add(rooms[166]);
	rooms[167].neighbours.add(rooms[169]);
	rooms[167].neighbours.add(rooms[135]);
    //Lanayru Field
    rooms[168].neighbours.add(rooms[165]);
	rooms[168].neighbours.add(rooms[155]);
	rooms[168].neighbours.add(rooms[170]);
	rooms[168].neighbours.add(rooms[121]);
	rooms[168].neighbours.add(rooms[169]);
	rooms[168].neighbours.add(rooms[174]);
	rooms[168].neighbours.add(rooms[134]);
	rooms[168].neighbours.add(rooms[141]);
	rooms[168].neighbours.add(rooms[133]);
    //Lake Hylia Bridge
    rooms[169].neighbours.add(rooms[167]);
	rooms[169].neighbours.add(rooms[158]);
	rooms[169].neighbours.add(rooms[168]);
	rooms[169].neighbours.add(rooms[170]);
	rooms[169].neighbours.add(rooms[138]);
    //Outside Castle Town West
    rooms[170].neighbours.add(rooms[169]);
	rooms[170].neighbours.add(rooms[168]);
	rooms[170].neighbours.add(rooms[159]);
	rooms[170].neighbours.add(rooms[130]);
    //Outside Castle Town South
    rooms[171].neighbours.add(rooms[159]);
	rooms[171].neighbours.add(rooms[167]);
	rooms[171].neighbours.add(rooms[142]);
	rooms[171].neighbours.add(rooms[158]);
    //Gerudo Desert
    rooms[172].neighbours.add(rooms[122]);
	rooms[172].neighbours.add(rooms[163]);
	rooms[172].neighbours.add(rooms[137]);
	rooms[172].neighbours.add(rooms[139]);
    //Mirror Chamber
    rooms[173].neighbours.add(rooms[106]);
	rooms[173].neighbours.add(rooms[66]);
    //Hidden Village
    rooms[174].neighbours.add(rooms[168]);
    //Death Mountain Interiors
    rooms[175].neighbours.add(rooms[154]);
	rooms[175].neighbours.add(rooms[13]);
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
bool canUse(uint8_t item)
{
	bool canUseItem = false;
	foreach (var heldItem in heldItemList)
	{
		if (item == heldItem)
		{
			canUseItem = true;
		}
	}
	return canUseItem;
}

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