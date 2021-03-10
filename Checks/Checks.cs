using Requirements;
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

Check[] checks 
{
    {
        "Palace_of_Twilight_West_Wing_First_Room_Central_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head",
        283D,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Central_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head",
        32E9,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head",
        8277,
        
        "category": ["Chest", "Palace of Twilight", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest",
        
        "requirements": "Requirement.Double_Clawshot",
        2E9D,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x06
    }
    {
        "Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness",
        
        "requirements": "Requirement.Light_Sword, Requirement.Clawshot",
        893A,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x21
    }
    {
        "Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest",
        
        "requirements": "Requirement.Clawshot",
        0F31,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x05
    }
    {
        "Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head, Requirement.Clawshot",
        F92E,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot",
        B204,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x05
    }
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot",
        8702,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x05
    }
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot",
        E301,
        
        "category": ["Chest", "Palace of Twilight", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot",
        1697,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_East_Wing_First_Room_East_Alcove",
        
        "requirements": "Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot, Requirement.can_defeat_phantom_zant",
        A2E3,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x21
    }
    {
        "Palace_of_Twilight_East_Wing_First_Room_West_Alcove",
        
        "requirements": "Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot, Requirement.can_defeat_phantom_zant",
        FA68,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x05
    }
    {
        "Palace_of_Twilight_Central_First_Room_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head",
        8F8C,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_Big_Key_Chest",
        
        "requirements": "Requirement.LightSword, Requirement.Double_Clawshot",
        1BCC,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x97
    }
    {
        "Palace_of_Twilight_Central_Outdoor_Chest",
        
        "requirements": "Requirement.can_defeat_zant_head",
        1F63,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Palace_of_Twilight_Central_Tower_Chest",
        
        "requirements": "Requirement.Light_Sword, Requirement.Clawshot, Requirement.can_defeat_zant_head",
        3506,
        
        "category": ["Chest", "Palace of Twilight", "Small Key"],
        "item_id": "0x8C
    }
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest",
        
        "requirements": "Requirement.can_smash",
        E956,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x06
    }
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest",
        
        "requirements": "Requirement.can_smash",
        BF0D,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x01
    }
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Back_Left_Chest",
        
        "requirements": "Requirement.can_smash",
        1F6C,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x04
    }
    {
        "Hyrule_Castle_Graveyard_Owl_Statue_Chest",
        
        "requirements": "Requirement.can_smash, Requirement.Lantern, Requirement.Powered_Dominion_Rod",
        87FB,
        
        "category": ["Chest", "Hyrule Castle", "Small Key"],
        "item_id": "0x8D
    }
    {
        "Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest",
        
        "requirements": "Requirement.Boomerang",
        1533,
        
        "category": ["Chest", "Hyrule Castle", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Hyrule_Castle_East_Wing_Balcony_Chest",
        
        "requirements": "Requirement.Boomerang",
        592C,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x03
    }
    {
        "Hyrule_Castle_West_Courtyard_North_Small_Chest",
        
        "requirements": "Requirement.can_defeat_bokoblin",
        5Eb3,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x04
    }
    {
        "Hyrule_Castle_West_Courtyard_Central_Small_Chest",
        
        "requirements": "Requirement.can_defeat_bokoblin",
        22F4,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x04
    }
    {
        "Hyrule_Castle_Main_Hall_Northeast_Chest",
        
        "requirements": "Requirement.can_defeat_bokoblin, Requirement.can_defeat_lizalfos, Requirement.Clawshot",
        3107,
        
        "category": ["Chest", "Hyrule Castle", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Hyrule_Castle_Lantern_Staircase_Chest",
        
        "requirements": "Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang",
        09D2,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x05
    }
    {
        "Hyrule_Castle_Main_Hall_Southwest_Chest",
        
        "requirements": "Requirement.can_knock_down_hc_painting, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Boomerang, Requirement.Lantern, Requirement.Double_Clawshot",
        F83F,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x05
    }
    {
        "Hyrule_Castle_Main_Hall_Northwest_Chest",
        
        "requirements": "RRequirement.can_knock_down_hc_painting, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Boomerang, Requirement.Lantern, Requirement.Double_Clawshot",
        A782,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x07
    }
    {
        "Hyrule_Castle_Southeast_Balcony_Tower_Chest",
        
        "requirements": "Requirement.can_defeat_aeralfos",
        8C2C,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x8D
    }
    {
        "Hyrule_Castle_Big_Key_Chest",
        
        "requirements": "],
        9553,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x98
    }
    {
        "Hyrule_Castle_Treasure_Room_Eighth_Small_Chest",
        
        "requirements": "],
        D762,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x02
    }
    {
        "Hyrule_Castle_Treasure_Room_Seventh_Small_Chest",
        
        "requirements": "],
        5423,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x03
    }
    {
        "Hyrule_Castle_Treasure_Room_Sixth_Small_Chest",
        
        "requirements": "],
        D2E3,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x04
    }
    {
        "Hyrule_Castle_Treasure_Room_Fifth_Small_Chest",
        
        "requirements": "],
        EB62,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x18
    }
    {
        "Hyrule_Castle_Treasure_Room_Fourth_Small_Chest",
        
        "requirements": "],
        349E,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x0F
    }
    {
        "Hyrule_Castle_Treasure_Room_Third_Small_Chest",
        
        "requirements": "],
        9CB6,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x0C
    }
    {
        "Hyrule_Castle_Treasure_Room_Second_Small_Chest",
        
        "requirements": "],
        618F,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x01
    }
    {
        "Hyrule_Castle_Treasure_Room_First_Small_Chest",
        
        "requirements": "],
        0302,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x10
    }
    {
        "Hyrule_Castle_Treasure_Room_Fifth_Chest",
        
        "requirements": "],
        4B86,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x05
    }
    {
        "Hyrule_Castle_Treasure_Room_Fourth_Chest",
        
        "requirements": "],
        2D5C,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x1B
    }
    {
        "Hyrule_Castle_Treasure_Room_Third_Chest",
        
        "requirements": "],
        6508,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x07
    }
    {
        "Hyrule_Castle_Treasure_Room_Second_Chest",
        
        "requirements": "],
        19D2,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x12
    }
    {
        "Hyrule_Castle_Treasure_Room_First_Chest",
        
        "requirements": "],
        7086,
        
        "category": ["Chest", "Hyrule Castle"],
        "item_id": "0x06
    }
    {
        "Zant_Heart_Container",
        
        "requirements": "Requirement.can_defeat_zant",
        93FC,
        
        "category": ["Chest", "Palace of Twilight"],
        "item_id": "0x22
    }
}