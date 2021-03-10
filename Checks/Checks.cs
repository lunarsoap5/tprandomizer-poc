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
        "Snowpeak_Ruins_West_Courtyard_Buried_Chest",
        
        "requirements": "Requirement.Shadow_Crystal",
        FD69,
        
        "category": ["Chest", "Snowpeak Ruins", "Small Key"],
        "item_id": "0x89
    }
    {
        "Snowpeak_Ruins_East_Courtyard_Buried_Chest",
        
        "requirements": "Requirement.Shadow_Crystal",
        2725,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x04
    }
    {
        "Snowpeak_Ruins_Ordon_Pumpkin_Chest",
        
        "requirements": "Requirement.can_defeat_chilfos",
        F5CA,
        
        "category": ["Chest", "Snowpeak Ruins", "Dungeon Items", "Ordon Pumpkin"],
        "item_id": "0xF4
    }
    {
        "Snowpeak_Ruins_East_Courtyard_Chest",
        
        "requirements": "Requirement.Shadow_Crystal",
        F35C,
        
        "category": ["Chest", "Snowpeak Ruins", "Small Key"],
        "item_id": "0x89
    }
    {
        "Snowpeak_Ruins_Wooden_Beam_Central_Chest",
        
        "requirements": "Requirement.can_defeat_ice_keese",
        A3A7,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x04
    }
    {
        "Snowpeak_Ruins_Wooden_Beam_Northwest_Chest",
        
        "requirements": "Requirement.can_defeat_ice_keese",
        A356,
        
        "category": ["Chest", "Snowpeak Ruins", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Snowpeak_Ruins_Courtyard_Central_Chest",
        
        "requirements": "Requirement.can_break_snowpeak_ruins_central_ice",
        E51D,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x0A
    }
    {
        "Snowpeak_Ruins_Chest_After_Darkhammer",
        
        "requirements": "Requirement.can_defeat_darkhammer, Requirement.Ball_And_Chain",
        5786,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0xF5
    }
    {
        "Snowpeak_Ruins_Broken_Floor_Chest",
        
        "requirements": "Requirement.can_smash",
        569D,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x21
    }
    {
        "Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest",
        
        "requirements": "Requirement.Ordon_Goat_Cheese, Requirement.can_defeat_chilfos, Requirement.Ball_And_Chain",
        F06A,
        
        "category": ["Chest", "Snowpeak Ruins", "Small Key"],
        "item_id": "0x89
    }
    {
        "Snowpeak_Ruins_Lobby_Chandelier_Chest",
        
        "requirements": "Requirement.Ordon_Goat_Cheese, Requirement.Ball_And_Chain, Requirement.snowpeak_ruins_3_small_keys",
        2D6A,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x21
    }
    {
        "Snowpeak_Ruins_Lobby_West_Armor_Chest",
        
        "requirements": "Ball_And_Chain",
        E95B,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x04
    }
    {
        "Snowpeak_Ruins_Lobby_East_Armor_Chest",
        
        "requirements": "Ball_And_Chain",
        D9CE,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x03
    }
    {
        "Snowpeak_Ruins_Northeast_Chandelier_Chest",
        
        "requirements": "Requirement.Ordon_Goat_Cheese, Requirement.Ball_And_Chain, Requirement.Clawshot, Requirement.snowpeak_ruins_3_small_keys",
        A485,
        
        "category": ["Chest", "Snowpeak Ruins", "Small Key"],
        "item_id": "0x89
    }
    {
        "Snowpeak_Ruins_West_Cannon_Room_Central_Chest",
        
        "requirements": "Requirement.Ball_And_Chain",
        CB52,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x04
    }
    {
        "Snowpeak_Ruins_West_Cannon_Room_Corner_Chest",
        
        "requirements": "Requirement.can_smash",
        98E8,
        
        "category": ["Chest", "Snowpeak Ruins"],
        "item_id": "0x0A
    }
    {
        "Snowpeak_Ruins_Chapel_Chest",
        
        "requirements": "Requirement.can_defeat_chilfos",
        9C1C,
        
        "category": ["Chest", "Snowpeak Ruins", "Boss Key"],
        "item_id": "0xF6
    }
    {
        "Temple_of_Time_Lobby_Lantern_Chest"
        
        "requirements": "Requirement.Lantern",
        BC22,
        
        "category": ["Chest", "Temple of Time", "Small Key"],
        "item_id": "0x8A
    }
    {
        "Temple_of_Time_First_Staircase_Gohma_Gate_Chest"
        
        "requirements": "Requirement.can_defeat_young_gohma",
        298C,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x10
    }
    {
        "Temple_of_Time_First_Staircase_Window_Chest"
        
        "requirements": "Requirement.has_ranged_item",
        C45E,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x04
    }
    {
        "Temple_of_Time_First_Staircase_Armos_Chest"
        
        "requirements": "Requirement.can_defeat_armos",
        C637,
        
        "category": ["Chest", "Temple of Time", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Temple_of_Time_Statue_Throws_Room_East_Chest"
        
        "requirements": "Requirement.can_defeat_armos}
        BB75,
        
        "category": ["Chest", "Temple of Time", "Small Key"],
        "item_id": "0x8A
    }
    {
        "Temple_of_Time_Moving_Wall_Beamos_Room_Chest"
        
        "requirements": "Requirement.Bow",
        E368,
        
        "category": ["Chest", "Temple of Time", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Temple_of_Time_Scales_Gohma_Chest"
        
        "requirements": "Requirement.can_defeat_young_gohma, Requirement.can_defeat_baby_gohma",
        E586,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x05
    }
    {
        "Temple_of_Time_Gilloutine_Chest"
        
        "requirements": "],
        35F9,
        
        "category": ["Chest", "Temple of Time", "Small Key"],
        "item_id": "0x8A
    }
    {
        "Temple_of_Time_Chest_Before_Midboss"
        
        "requirements": "Requirement.can_defeat_armos, Requirement.can_defeat_baby_gohma, Requirement.can_defeat_young_gohma",
        1A52,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x05
    }
    {
        "Temple_of_Time_Darknut_Chest"
        
        "requirements": "Requirement.can_defeat_darknut",
        DAD6,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x46
    }
    {
        "Temple_of_Time_Scales_Upper_Chest"
        
        "requirements": "Requirement.Clawshot, Requirement.Spinner",
        BD60,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x04
    }
    {
        "Temple_of_Time_Big_Key_Chest_Room_Upper_Chest"
        
        "requirements": "Requirement.Clawshot",
        BCFE,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x04
    }
    {
        "Temple_of_Time_Big_Key_Chest"
        
        "requirements": "Requirement.can_defeat_helmasaur, Requirement.Clawshot",
        B704,
        
        "category": ["Chest", "Temple of Time", "Boss Key"],
        "item_id": "0x95
    }
    {
        "Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest"
        
        "requirements": "Requirement.can_defeat_dinalfos, Requirement.Dominion_Rod }
        D3B5,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x21
    }
    {
        "Temple_of_Time_Statue_Throws_Room_North_Chest"
        
        "requirements": "],
        9BC3,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x04
    }
    {
        "Temple_of_Time_Statue_Throws_Room_Statue_Chest"
        
        "requirements": "Requirement.Dominion_Rod",
        1F68,
        
        "category": ["Chest", "Temple of Time"],
        "item_id": "0x21
    }
    {
        "City_in_The_Sky_Underwater_West_Chest"
        
        "requirements": "Requirement.Iron_Boots",
        CF09,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x18
    }
    {
        "City_in_The_Sky_Underwater_East_Chest"
        
        "requirements": "Requirement.Iron_Boots",
        DF0C,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_West_Wing_First_Chest"
        
        "requirements": "],
        18B6,
        
        "category": ["Chest", "City in The Sky", "Small Key"],
        "item_id": "0x8B
    }
    {
        "City_in_The_Sky_East_First_Wing_Chest_After_Fans"
        
        "requirements": "Requirement.Clawshot",
        37C7,
        
        "category": ["Chest", "City in The Sky", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "City_in_The_Sky_East_Tile_Worm_Small_Chest"
        
        "requirements": "],
        5940,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x03
    }
    {
        "City_in_The_Sky_East_Wing_After_Dinalfos_Alcove_Chest"
        
        "requirements": "Requirement.Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_tile_worm",
        5C4D,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_East_Wing_After_Dinalfos_Ledge_Chest"
        
        "requirements": "Requirement.Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_tile_worm",
        8705,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x05
    }
    {
        "City_in_The_Sky_Aeralfos_Chest"
        
        "requirements": "Requirement.can_defeat_aeralfos, Requirement.Clawshot, Requirement.Iron_Boots",
        26B5,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x47
    }
    {
        "City_in_The_Sky_East_Wing_Lower_Level_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        A2C1,
        
        "category": ["Chest", "City in The Sky", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }

    {
        "City_in_The_Sky_West_Wing_Baba_Balcony_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        63B4,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x0F
    }
    {
        "City_in_The_Sky_West_Wing_Narrow_Ledge_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        C5A9,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_West_Wing_Tile_Worm_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        F48A,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x0B
    }
    {
        "City_in_The_Sky_Baba_Tower_Top_Small_Chest"
        
        "requirements": "Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot",
        2DD1,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x03
    }
    {
        "City_in_The_Sky_Baba_Tower_Narrow_Ledge_Chest"
        
        "requirements": "Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot",
        781F,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_Baba_Tower_Alcove_Chest"
        
        "requirements": "Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot",
        4E34,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x21
    }
    {
        "City_in_The_Sky_West_Garden_Corner_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        13EF,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_West_Garden_Lone_Island_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        C036,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x05
    }
    {
        "City_in_The_Sky_West_Garden_Lower_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        3EB9,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x0A
    }
    {
        "City_in_The_Sky_West_Garden_Ledge_Chest"
        
        "requirements": "Requirement.Double_Clawshot",
        EAD5,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x21
    }
    {
        "City_in_The_Sky_Central_Outside_Ledge_Chest"
        
        "requirements": "Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal",
        6441,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_Central_Outside_Poe_Island_Chest"
        
        "requirements": "Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal",
        5722,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x05
    }
    {
        "City_in_The_Sky_Big_Key_Chest"
        
        "requirements": "Requirement.Double_Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal, Requirement.Iron_Boots",
        AAD2,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x96
    }
    {
        "City_in_The_Sky_Chest_Below_Big_Key_Chest"
        
        "requirements": "Requirement.Double_Clawshot, Requirement.can_defeat_helmasaur",
        F965,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x04
    }
    {
        "City_in_The_Sky_Chest_Behind_North_Fan"
        
        "requirements": "Requirement.can_defeat_helmasaurus, Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal, Requirement.Iron_Boots, Requirement.Double_Clawshot",
        7B61,
        
        "category": ["Chest", "City in The Sky"],
        "item_id": "0x05
    }
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