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
    string stageId;
    uint8_t roomId;
}

Check[] checks 
{
    
    
    
    {
        "Forest_Temple_Entrance_Vines_Chest",
        
        "requirements": "Requirement.can_defeat_walltula",
        0E45,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x03
    }
    {
        "Forest_Temple_Central_Chest_Behind_Stairs",
        
        "requirements": "Requirement.can_defeat_bombling, Requirement.Boomerang",
        E30F,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x04
    }
    {
        "Forest_Temple_Central_North_Chest",
        
        "requirements": "Requirement.Lantern",
        7C1C,
        
        "category": ["Chest", "Forest Temple", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Forest_Temple_Windless_Bridge_Chest",
        
        "requirements": "],
        E409,
        
        "category": ["Chest", "Forest Temple", "Small Key"],
        "item_id": "0x85
    }
    {
        "Forest_Temple_Second_Monkey_Under_Bridge_Chest",
        
        "requirements": "],
        F218,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x03
    }
    {
        "Forest_Temple_Totem_Pole_Chest",
        
        "requirements": "],
        F837,
        
        "category": ["Chest", "Forest Temple", "Small Key"],
        "item_id": "0x85
    }

    {
        "Forest_Temple_West_Tile_Worm_Room_Vines_Chest",
        
        "requirements": "],
        4CBC,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x04
    }
    {
        "Forest_Temple_West_Deku_Like_Chest",
        
        "requirements": "Requirement.can_defeat_bombling",
        E3B3,
        
        "category": ["Chest", "Forest Temple"]
        "item_id": "0x21
    }
    {
        "Forest_Temple_West_Tile_Worm_Chest_Behind_Stairs",
        
        "requirements": "Requirement.Boomerang",
        B39E,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x21
    }
    {
        "Forest_Temple_Central_Chest_Hanging_From_Web",
        
        "requirements": "Requirement.can_cut_hanging_web",
        6A07,
        
        "category": ["Chest", "Forest Temple", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Forest_Temple_Big_Key_Chest",
        
        "requirements": " Requirement.can_defeat_bombling_or_burn_webs,  Requirement.Boomerang",
        2C4F,
        
        "category": ["Chest", "Forest Temple", "Big Key"],
        "item_id": "0x92
    }
    {
        "Forest_Temple_East_Water_Cave_Chest",
        
        "requirements": "Requirement.can_defeat_bombling_or_burn_webs",
        FAE5,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x03
    }
    {
        "Forest_Temple_North_Deku_Like_Chest",
        
        "requirements": "Requirement.Boomerang",
        80A2,
        
        "category": ["Chest", "Forest Temple"]
        "item_id": "0x85
    }
    {
        "Forest_Temple_East_Tile_Worm_Chest",
        
        "requirements": "Requirement.can_defeat_tile_worm, Requirement.can_defeat_skulltula, Requirement.can_defeat_walltula",
        0CF3,
        
        "category": ["Chest", "Forest Temple"],
        "item_id": "0x04
    }
    {
        "Kakariko_Inn_Chest",
        
        "requirements": "],
        12B4,
        
        "category": ["Chest", "Kakariko Village"],
        "item_id": "0x04
    }
    {
        "Goron_Mines_Entrance_Chest",
        
        "requirements": "Requirement.can_press_mines_switch",
        5FE5,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x04
    }
    {
        "Goron_Mines_Main_Magnet_Room_Bottom_Chest",
        
        "requirements": "],
        A994,
        
        "category": ["Chest", "Goron Mines", "Small Key"],
        "item_id": "0x86
    }
    {
        "Goron_Mines_Gor_Amato_Chest",
        
        "requirements": "],
        A0D4,
        
        "category": ["Chest", "Goron Mines", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Goron_Mines_Gor_Amato_Small_Chest",
        
        "requirements": "],
        0942,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x04
    }
    {
        "Goron_Mines_Magnet_Maze_Chest",
        
        "requirements": "Requirement.Iron_Boots",
        CD65,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x21
    }
    {
        "Goron_Mines_Crystal_Switch_Room_Underwater_Chest",
        
        "requirements": "Requirement.Iron_Boots",
        AC33,
        
        "category": ["Chest", "Goron Mines", "Small Key"],
        "item_id": "0x86
    }
    {
        "Goron_Mines_Crystal_Switch_Room_Small_Chest",
        
        "requirements": "Requirement.Iron_Boots",
        F354,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x04
    }
    {
        "Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest",
        
        "requirements": "Requirement.Iron_Boots",
        3CD3,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x21
    }
    {
        "Goron_Mines_Outstide_Beamos_Chest",
        
        "requirements": "],
        78DC,
        
        "category": ["Chest", "Goron Mines", "Small Key"],
        "item_id": "0x86
    }
    {
        "Goron_Mines_Gor_Ebizo_Chest",
        
        "requirements": "],
        2954,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x03
    }
    {
        "Goron_Mines_Chest_Before_Dangoro",
        
        "requirements": "Requirement.Iron_Boots",
        8B94,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x03
    }
    {
        "Goron_Mines_Dangoro_Chest",
        
        "requirements": "],
        F6E5,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x43
    }
    {
        "Goron_Mines_Beamos_Room_Chest",
        
        "requirements": "Requirement.Bow",
        49BD,
        
        "category": ["Chest", "Goron Mines", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Goron_Mines_Gor_Liggs_Chest",
        
        "requirements": "],
        1A80,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x05
    }
    {
        "Goron_Mines_Main_Magnet_Room_Top_Chest",
        
        "requirements": "Requirement.Bow, Requirement.Iron_Boots, Requirement.goron_mines_3_small_keys, Requirement.can_defeat_dangoro",
        4262,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x05
    }
    {
        "Goron_Mines_Outside_Underwater_Chest",
        
        "requirements": "Requirement.has_sword, Requirement.Iron_Boots",
        05BF,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x05
    }
    {
        "Eldin_Spring_Underwater_Chest",
        
        "requirements": "Requirement.can_smash, Requirement.Iron_Boots",
        6C58,
        
        "category": ["Chest", "Eldin Province"],
        "item_id": "0x21
    }
    {
        "Eldin_Field_Bomb_Rock_Chest",
        
        "requirements": "Requirement.can_smash",
        BBAC,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x21
    }
    {
        "Zoras_Domain_Chest_By_Mother_and_Child_Isles",
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        0819,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x03
    }
    {
        "Zoras_Domain_Chest_Behind_Waterfall",
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal",
        827A,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x04
    }
    
    {
        "Lakebed_Temple_Lobby_Left_Chest",
        
        "requirements": "Requirement.Zora_Armor",
        F526,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x0F
    }
    {
        "Lakebed_Temple_Lobby_Rear_Chest",
        
        "requirements": "Requirement.Zora_Armor",
        92AC,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x17
    }
    {
        "Lakebed_Temple_Stalactite_Room_Chest",
        
        "requirements": "Requirement.can_launch_bombs",
        FC76,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x17
    }
    {
        "Lakebed_Temple_Central_Room_Small_Chest",
        
        "requirements": "],
        4BCE,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x0F
    }
    {
        "Lakebed_Temple_Central_Room_Chest",
        
        "requirements": "],
        D363,
        
        "category": ["Chest", "Lakebed Temple", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest",
        
        "requirements": "Requirement.can_launch_bombs",
        2AF4,
        
        "category": ["Chest", "Lakebed Temple", "Small Key"],
        "item_id": "0x87
    }
    {
        "Lakebed_Temple_East_Second_Floor_Southwest_Chest",
        
        "requirements": "],
        07A8,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x16
    }
    {
        "Lakebed_Temple_East_Second_Floor_Southeast_Chest",
        
        "requirements": "Requirement.can_launch_bombs",
        E6CB,
        
        "category": ["Chest", "Lakebed Temple", "Small Key"],
        "item_id": "0x87
    }
    {
        "Lakebed_Temple_East_Water_Supply_Small_Chest",
        
        "requirements": "Requirement.lakebed_temple_3_small_keys",
        81F9,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x17
    }
    {
        "Lakebed_Temple_Before_Deku_Toad_Alcove_Chest",
        
        "requirements": "],
        6D58,
        
        "category": ["Chest", "Lakebed Temple", "Small Key"],
        "item_id": "0x87
    }
    {
        "Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest",
        
        "requirements": "Requirement.Iron_Boots, Requirement.Zora_Armor, Requirement.lakebed_temple_3_small_keys",
        6189,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x04
    }
    {
        "Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest",
        
        "requirements": "Requirement.Iron_Boots, Requirement.Zora_Armor Requirement.lakebed_temple_3_small_keys",
        618E,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x16
    }
    {
        "Lakebed_Temple_Deku_Toad_Chest",
        
        "requirements": "Requirement.can_defeat_deku_toad",
        B9C7,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x44
    }
    {
        "Lakebed_Temple_Chandelier_Chest",
        
        "requirements": "Requirement.Clawshot",
        01A0,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x21
    }
    {
        "Lakebed_Temple_East_Water_Supply_Clawshot_Chest",
        
        "requirements": "Requirement.Clawshot, Requirement.lakebed_temple_3_small_keys",
        3CC9,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x05
    }
    {
        "Lakebed_Temple_Central_Room_Center_Spire_Chest",
        
        "requirements": "Requirement.can_launch_bombs, Requirement.lakebed_temple_3_small_keys, Requirement.Iron_Boots",
        7F1C,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x04
    }
    {
        "Lakebed_Temple_West_Lower_Small_Chest",
        
        "requirements": "Requirement.Clawshot",
        B93A,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x17
    }
    {
        "Lakebed_Temple_West_Water_Supply_Small_Chest",
        
        "requirements": "Requirement.Clawshot",
        BAF9,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x17
    }
    {
        "Lakebed_Temple_West_Water_Supply_Chest",
        
        "requirements": "Requirement.Clawshot",
        EE15,
        
        "category": ["Chest", "Lakebed Temple", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest",
        
        "requirements": "Requirement.Iron_Boots, Requirement.Clawshot",
        E582,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x04
    }
    {
        "Lakebed_Temple_West_Second_Floor_Central_Small_Chest",
        
        "requirements": "Requirement.Clawshot",
        1077,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x04
    }
    {
        "Lakebed_Temple_West_Second_Floor_Northeast_Chest",
        
        "requirements": "Requirement.Clawshot",
        3BC1,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x04
    }
    {
        "Lakebed_Temple_West_Second_Floor_Southeast_Chest",
        
        "requirements": "Requirement.Clawshot",
        AD57,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x18
    }
    {
        "Lakebed_Temple_Big_Key_Chest",
        
        "requirements": "Requirement.Clawshot, Requirement.Water_Bombs",
        4429,
        
        "category": ["Chest", "Lakebed Temple", "Boss Key"],
        "item_id": "0x93
    }
    {
        "Lakebed_Temple_Underwater_Maze_Small_Chest",
        
        "requirements": "Zora_Armor",
        F508,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x16
    }
    {
        "Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest",
        
        "requirements": "Requirement.can_launch_bombs. Requirement.Clawshot, Requirement.lakebed_temple_3_small_keys",
        CF36,
        
        "category": ["Chest", "Lakebed Temple"],
        "item_id": "0x21
    }
    {
        "Sacred_Grove_Deku_Baba_Grotto_Chest"
        
        "requirements": "Requirement.can_defeat_baba_serpent, Requirement.can_knock_down_hanging_baba",
        F29C,
        
        "category": ["Chest", "Sacred Grove"],
        "item_id": "0x21
    }
    {
        "West_Hyrule_Field_Helmasaur_Grotto_Chest"
        
        "requirements": "Requirement.can_defeat_helmasaur",
        4904,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Lake_Lantern_Cave_First_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        9E56,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x1A
    }
    {
        "Lake_Lantern_Cave_Second_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        4D30,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x03
    }
    {
        "Lake_Lantern_Cave_Third_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        F9D2,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x04
    }
    {
        "Lake_Lantern_Cave_Fourth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        6E51,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x0E
    }
    {
        "Lake_Lantern_Cave_Fifth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        BA10,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x04
    }
    {
        "Lake_Lantern_Cave_Sixth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        B395,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x06
    }
    {
        "Lake_Lantern_Cave_Seventh_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        04DD,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x04
    }
    {
        "Lake_Lantern_Cave_Eighth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        3B1C,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x1A
    }
    {
        "Lake_Lantern_Cave_Ninth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        DBF7,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x0E
    }
    {
        "Lake_Lantern_Cave_Tenth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        254F,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x05
    }
    {
        "Lake_Lantern_Cave_Eleventh_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        917E,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x1B
    }
    {
        "Lake_Lantern_Cave_Twelfth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        F086,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x05
    }
    {
        "Lake_Lantern_Cave_Thirteenth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        D490,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x12
    }
    {
        "Lake_Lantern_Cave_Fourteenth_Chest"
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        39C1,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x06
    }
    {
        "Lake_Lantern_Cave_End_Lantern_Chest",
        
        "requirements": "Requirement.can_smash, Requirement.Lantern",
        34C1,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x21
    }
    {
        "Lanayru_Spring_Underwater_Right_Chest"
        
        "requirements": "Requirement.Iron_Boots",
        9C47,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x03
    }
    {
        "Lanayru_Spring_Back_Room_Left_Chest"
        
        "requirements": "Requirement.Clawshot",
        2253,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x02
    }
    {
        "Lanayru_Spring_Back_Room_Right_Chest"
        
        "requirements": "Requirement.Clawshot",
        8036,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x0A
    }
    {
        "Lanayru_Spring_Back_Room_Lantern_Chest"
        
        "requirements": "Requirement.Clawshot, Requirement.Lantern",
        4240,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x21
    }
    {
        "Flight_By_Fowl_Top_Platform_Chest"
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        F3CC,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x06
    }
    {
        "Flight_By_Fowl_Second_Platform_Chest"
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        4003,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x21
    }
    {
        "Flight_By_Fowl_Third_Platform_Chest"
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        FAEB,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x05
    }
    {
        "Flight_By_Fowl_Fourth_Platform_Chest"
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        DD8C,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x04
    }
    {
        "Flight_By_Fowl_Fifth_Platform_Chest"
        
        "requirements": "Requirement.Lanayru_Vessel_of_Light",
        6633,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x03
    }
    {
        "Lake_Hylia_Shell_Blade_Grotto_Chest"
        
        "requirements": "Requirement.can_defeat_shell_blade",
        A6A6,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x06
    }
    {
        "Zoras_Domain_Light_All_Torches_Chest"
        
        "requirements": "Requirement.Lantern",
        CB68,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x05
    }
    {
        "Zora_Domain_Extinguish_All_Torches_Chest"
        
        "requirements": "Requirement.Boomerang",
        827F,
        
        "category": ["Chest", "Lanayru Province"],
        "item_id": "0x05
    }
    {
        "Lanayru_Field_Skulltula_Grotto_Chest"
        
        "requirements": "Requirement.can_defeat_skulltula, Requirement.Lantern",
        A444,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Lanayru_Field_Behind_Gate_Underwater_Chest"
        
        "requirements": "Requirement.Iron_Boots",
        FC21,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Lake_Hylia_Bridge_Vines_Chest"
        
        "requirements": "Requirement.Clawshot",
        0D81,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Lake_Hylia_Bridge_Bubble_Grotto_Chest"
        
        "requirements": "Requirement.can_defeat_bubble, Requirement.can_defeat_fire_bubble, Requirement.can_defeat_ice_bubble",
        6D05,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Lake_Hylia_Bridge_Cliff_Chest"
        
        "requirements": "Requirement.can_launch_bombs, Requirement.Clawshot",
        7216,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Faron_Field_Bridge_Chest"
        
        "requirements": "Requirement.Clawshot",
        D552,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Faron_Field_Corner_Grotto_Right_Chest"
        
        "requirements": "],
        D1D5,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x04
    }
    {
        "Faron_Field_Corner_Grotto_Rear_Chest"
        
        "requirements": "],
        121E,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x03
    }
    {
        "Faron_Field_Corner_Grotto_Left_Chest"
        
        "requirements": "],
        74C4,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x04
    }
    {
        "Death_Mountain_Alcove_Chest"
        
        "requirements": "Requirement.can_beat_mines_or_clawshot",
        6c2e,
        
        "category": ["Chest", "Eldin Province"],
        "item_id": "0x21
    }
    {
        "Goron_Mines_Outside_Clawshot_Chest"
        
        "requirements": "Requirement.Clawshot",
        9377,
        
        "category": ["Chest", "Goron Mines"],
        "item_id": "0x05
    }
    {
        "Eldin_Lantern_Cave_First_Chest"
        
        "requirements": "Requirement.can_burn_webs",
        6168,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x04
    }
    {
        "Eldin_Lantern_Cave_Second_Chest"
        
        "requirements": "Requirement.can_burn_webs",
        BAF6,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Eldin_Lantern_Cave_Lantern_Chest"
        
        "requirements": "Requirement.Lantern",
        C037,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x21
    }
    {
        "Outside_South_Castle_Town_Field_Tightrope_Chest",
        
        "requirements": "Requirement.Clawshot, Requirement.Shadow_Crystal",
        79AC,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Outside_South_Castle_Town_Tetike_Grotto_Chest",
        
        "requirements": "Requirement.can_defeat_tetike",
        0245,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Eldin_Field_Bomskit_Grotto_Left_Chest",
        
        "requirements": "Requirement.can_defeat_bomskit",
        96E8,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Eldin_Field_Bomskit_Grotto_Lantern_Chest",
        
        "requirements": "Requirement.can_defeat_bomskit, Requirement.Lantern",
        D3C9,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Eldin_Field_Water_Bomb_Fish_Grotto_Chest",
        
        "requirements": "],
        3E7D,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x05
    }
    {
        "Eldin_Stockcave_Upper_Chest",
        
        "requirements": "Requirement.Iron_Boots",
        B84B,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x04
    }
    {
        "Eldin_Stockcave_Lantern_Chest",
        
        "requirements": "Requirement.Lantern, Requirement.Iron_Boots",
        64DC,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x06
    }
    {
        "Eldin_Stockcave_Lowest_Chest",
        
        "requirements": "],
        9C80,
        
        "category": ["Chest", "Hyrule Field"],
        "item_id": "0x21
    }
    {
        "Arbiters_Grounds_Lobby_Chest",
        
        "requirements": "Requirement.can_break_wooden_door",
        FC38,
        
        "category": ["Chest", "Arbiter's Grounds", "Small Key"],
        "item_id": "0x88
    }
    {
        "Arbiters_Grounds_East_Lower_Turnable_Redead_Chest",
        
        "requirements": "Requirement.Shadow_Crystal, Requirement.Poe_Scent, Requirement.can_defeat_redead_knight",
        BF75,
        
        "category": ["Chest", "Arbiter's Grounds", "Small Key"],
        "item_id": "0x88
    }
    {
        "Arbiters_Grounds_Torch_Room_East_Chest",
        
        "requirements": "],
        1F95,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x21
    }
    {
        "Arbiters_Grounds_Torch_Room_West_Chest",
        
        "requirements": "],
        FAA5,
        
        "category": ["Chest", "Arbiter's Grounds", "Dungeon Items", "Dungeon Map"],
        "item_id": "0x23
    }
    {
        "Arbiters_Grounds_East_Upper_Turnable_Chest",
        
        "requirements": "],
        73DB,
        
        "category": ["Chest", "Arbiter's Grounds", "Dungeon Items", "Compass"],
        "item_id": "0x24
    }
    {
        "Arbiters_Grounds_East_Upper_Turnable_Redead_Chest",
        
        "requirements": "Requirement.can_defeat_redead_knight",
        F20F,
        
        "category": ["Chest", "Arbiter's Grounds", "Small Key"],
        "item_id": "0x88
    }
    {
        "Arbiters_Grounds_Ghoul_Rat_Room_Chest",
        
        "requirements": "],
        05A6,
        
        "category": ["Chest", "Arbiter's Grounds", "Small Key"],
        "item_id": "0x88
    }
    {
        "Arbiters_Grounds_West_Small_Chest_Behind_Block",
        
        "requirements": "],
        B294,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x04
    }
    {
        "Arbiters_Grounds_West_Chandelier_Chest",
        
        "requirements": "Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_ghoul_rat, Requirement.arbiters_grounds_4_small_keys",
        B288,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x04
    }
    {
        "Arbiters_Grounds_West_Stalfos_North_Chest",
        
        "requirements": "Requirement.can_break_wooden_door",
        E296,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x0A
    }
    {
        "Arbiters_Grounds_West_Stalfos_Southeast_Chest",
        
        "requirements": "Requirement.can_break_wooden_door",
        36DB,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x0A
    }
    {
        "Arbiters_Grounds_North_Turning_Room_Chest",
        
        "requirements": "],
        4B87,
        
        "category": ["Chest", "Arbiter's Grounds", "Small Key"],
        "item_id": "0x88
    }
    {
        "Arbiters_Grounds_Death_Sword_Chest",
        
        "requirements": "Requirement.can_defeat_death_sword",
        8318,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x41
    }
    {
        "Arbiters_Grounds_Spinner_Room_First_Small_Chest",
        
        "requirements": "],
        477D,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x0B
    }
    {
        "Arbiters_Grounds_Spinner_Room_Second_Small_Chest",
        
        "requirements": "],
        BB1E,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x04
    }
    {
        "Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest",
        
        "requirements": "Requirement.Spinner",
        8F23,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x03
    }
    {
        "Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest",
        
        "requirements": "Requirement.Spinner",
        0EF4,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x21
    }
    {
        "Arbiters_Grounds_Spinner_Room_Lower_North_Chest",
        
        "requirements": "Requirement.Spinner",
        8080,
        
        "category": ["Chest", "Arbiter's Grounds"],
        "item_id": "0x03
    }
    {
        "Arbiters_Grounds_Big_Key_Chest",
        
        "requirements": "Requirement.Clawshot, Requirement.arbiters_grounds_5_small_keys, Requirement.Spinner",
        47CF,
        
        "category": ["Chest", "Arbiter's Grounds", "Boss Key"],
        "item_id": "0x94
    }
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
    {
        "Cats_Hide_and_Seek_Minigame",
        
        "requirements": "Requirement.Ilias_Charm",
        9E3C,
        
        "category": ["Chest", "Hidden Village"],
        "item_id": "0x21
    }
}