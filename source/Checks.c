#include "Requirements.h"
struct Check
{
    string checkName; //the common name for the check this can be used in the randomizer to identify the check."
    bool empty; //Identifies if we already placed an item on this check (starts at true)
    list<Requirement> requirments; //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
    uint16_t hash; //the fletcher hash that will be compared to on stage load
    bool isExcluded; //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
    list<string> checkCategory; //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
    uint8_t itemId; //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
}

Check Checks [] 
{
    {
        "Gift_From_Rusl",
        true,
        new list<Requirement> {Requirement.Fishing_Rod},
        8BA3,
        false,
        new list<String> {"Chest", "Ordonia Province"},
        0x3F
    },
    {
        "South_Faron_Cave_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        542E,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x03
    },
    {
        "Faron_Mist_Cave_Open_Chest",
        true,
        new list<Requirement> {},
        23EB,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0xEE
    },
    {
        "Faron_Mist_Cave_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        2247,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x21
    },
    {
        "North_Faron_Woods_Deku_Baba_Chest",
        true,
        new list<Requirement> {},
        1862,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x03
    },
    {
        "Links_Basement_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        E723,
        false,
        new list<String> {"Chest", "Ordonia Province"},
        0xED
    },
    {
        "Forest_Temple_Entrance_Vines_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_walltula},
        0E45,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x03
    },
    {
        "Forest_Temple_Central_Chest_Behind_Stairs",
        true,
        new list<Requirement> {Requirement.can_defeat_bombling, Requirement.Boomerang},
        E30F,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x04
    },
    {
        "Forest_Temple_Central_North_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        7C1C,
        false,
        new list<String> {"Chest", "Forest Temple", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Forest_Temple_Windless_Bridge_Chest",
        true,
        new list<Requirement> {},
        E409,
        false,
        new list<String> {"Chest", "Forest Temple", "Small Key"},
        0x85
    },
    {
        "Forest_Temple_Second_Monkey_Under_Bridge_Chest",
        true,
        new list<Requirement> {},
        F218,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x03
    },
    {
        "Forest_Temple_Totem_Pole_Chest",
        true,
        new list<Requirement> {},
        F837,
        false,
        new list<String> {"Chest", "Forest Temple", "Small Key"},
        0x85
    },

    {
        "Forest_Temple_West_Tile_Worm_Room_Vines_Chest",
        true,
        new list<Requirement> {},
        4CBC,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x04
    },
    {
        "Forest_Temple_West_Deku_Like_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bombling},
        E3B3,
        false,
        new list<String> {"Chest", "Forest Temple"}
        0x21
    },
    {
        "Forest_Temple_West_Tile_Worm_Chest_Behind_Stairs",
        true,
        new list<Requirement> {Requirement.Boomerang},
        B39E,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x21
    },
    {
        "Forest_Temple_Central_Chest_Hanging_From_Web",
        true,
        new list<Requirement> {Requirement.can_cut_hanging_web},
        6A07,
        false,
        new list<String> {"Chest", "Forest Temple", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Forest_Temple_Big_Key_Chest",
        true,
        new list<Requirement> { Requirement.can_defeat_bombling_or_burn_webs,  Requirement.Boomerang},
        2C4F,
        false,
        new list<String> {"Chest", "Forest Temple", "Big Key"},
        0x92
    },
    {
        "Forest_Temple_East_Water_Cave_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bombling_or_burn_webs},
        FAE5,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x03
    },
    {
        "Forest_Temple_North_Deku_Like_Chest",
        true,
        new list<Requirement> {Requirement.Boomerang},
        80A2,
        false,
        new list<String> {"Chest", "Forest Temple"}
        0x85
    },
    {
        "Forest_Temple_East_Tile_Worm_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_tile_worm, Requirement.can_defeat_skulltula, Requirement.can_defeat_walltula},
        0CF3,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x04
    },
    {
        "Kakariko_Inn_Chest",
        true,
        new list<Requirement> {},
        12B4,
        false,
        new list<String> {"Chest", "Kakariko Village"},
        0x04
    },
    {
        "Wrestling_With_Bo",
        true,
        new list<Requirement> {Requirement.Faron_Vessel_of_Light, Requirement.Eldin_Vessel_of_Light},
        CA8A,
        false,
        new list<String> {"Chest", "Ordonia Province"},
        0x45
    },
    {
        "Goron_Mines_Entrance_Chest",
        true,
        new list<Requirement> {Requirement.can_press_mines_switch},
        5FE5,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x04
    },
    {
        "Goron_Mines_Main_Magnet_Room_Bottom_Chest",
        true,
        new list<Requirement> {},
        A994,
        false,
        new list<String> {"Chest", "Goron Mines", "Small Key"},
        0x86
    },
    {
        "Goron_Mines_Gor_Amato_Chest",
        true,
        new list<Requirement> {},
        A0D4,
        false,
        new list<String> {"Chest", "Goron Mines", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Goron_Mines_Gor_Amato_Small_Chest",
        true,
        new list<Requirement> {},
        0942,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x04
    },
    {
        "Goron_Mines_Magnet_Maze_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        CD65,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x21
    },
    {
        "Goron_Mines_Crystal_Switch_Room_Underwater_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        AC33,
        false,
        new list<String> {"Chest", "Goron Mines", "Small Key"},
        0x86
    },
    {
        "Goron_Mines_Crystal_Switch_Room_Small_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        F354,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x04
    },
    {
        "Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        3CD3,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x21
    },
    {
        "Goron_Mines_Outstide_Beamos_Chest",
        true,
        new list<Requirement> {},
        78DC,
        false,
        new list<String> {"Chest", "Goron Mines", "Small Key"},
        0x86
    },
    {
        "Goron_Mines_Gor_Ebizo_Chest",
        true,
        new list<Requirement> {},
        2954,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x03
    },
    {
        "Goron_Mines_Chest_Before_Dangoro",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        8B94,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x03
    },
    {
        "Goron_Mines_Dangoro_Chest",
        true,
        new list<Requirement> {},
        F6E5,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x43
    },
    {
        "Goron_Mines_Beamos_Room_Chest",
        true,
        new list<Requirement> {Requirement.Bow},
        49BD,
        false,
        new list<String> {"Chest", "Goron Mines", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Goron_Mines_Gor_Liggs_Chest",
        true,
        new list<Requirement> {},
        1A80,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x05
    },
    {
        "Goron_Mines_Main_Magnet_Room_Top_Chest",
        true,
        new list<Requirement> {Requirement.Bow, Requirement.Iron_Boots, Requirement.goron_mines_3_small_keys, Requirement.can_defeat_dangoro},
        4262,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x05
    },
    {
        "Goron_Mines_Outside_Underwater_Chest",
        true,
        new list<Requirement> {Requirement.has_sword, Requirement.Iron_Boots},
        05BF,
        false,
        new list<String> {"Chest", "Goron Mines"},
        0x05
    },
    {
        "Eldin_Spring_Underwater_Chest",
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Iron_Boots},
        6C58,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x21
    },
    {
        "Kakariko_Graveyard_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        7D3A,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x05
    },
    {
        "Kakariko_Watchtower_Chest",
        true,
        new list<Requirement> {},
        64BD,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x05
    },
    {
        "Kakariko_Watchtower_Alcove_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        0C13,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x06
    },
    {
        "Eldin_Field_Bomb_Rock_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        BBAC,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Zoras_Domain_Chest_By_Mother_and_Child_Isles",
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        0819,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x03
    },
    {
        "Zoras_Domain_Chest_Behind_Waterfall",
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal},
        827A,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x04
    },
    {
        "Lake_Hylia_Underwater_Chest",
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Iron_Boots},
        9D4D,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Lakebed_Temple_Lobby_Left_Chest",
        true,
        new list<Requirement> {Requirement.Zora_Armor},
        F526,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x0F
    },
    {
        "Lakebed_Temple_Lobby_Rear_Chest",
        true,
        new list<Requirement> {Requirement.Zora_Armor},
        92AC,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x17
    },
    {
        "Lakebed_Temple_Stalactite_Room_Chest",
        true,
        new list<Requirement> {Requirement.can_launch_bombs},
        FC76,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x17
    },
    {
        "Lakebed_Temple_Central_Room_Small_Chest",
        true,
        new list<Requirement> {},
        4BCE,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x0F
    },
    {
        "Lakebed_Temple_Central_Room_Chest",
        true,
        new list<Requirement> {},
        D363,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest",
        true,
        new list<Requirement> {Requirement.can_launch_bombs},
        2AF4,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Small Key"},
        0x87
    },
    {
        "Lakebed_Temple_East_Second_Floor_Southwest_Chest",
        true,
        new list<Requirement> {},
        07A8,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x16
    },
    {
        "Lakebed_Temple_East_Second_Floor_Southeast_Chest",
        true,
        new list<Requirement> {Requirement.can_launch_bombs},
        E6CB,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Small Key"},
        0x87
    },
    {
        "Lakebed_Temple_East_Water_Supply_Small_Chest",
        true,
        new list<Requirement> {Requirement.lakebed_temple_3_small_keys},
        81F9,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x17
    },
    {
        "Lakebed_Temple_Before_Deku_Toad_Alcove_Chest",
        true,
        new list<Requirement> {},
        6D58,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Small Key"},
        0x87
    },
    {
        "Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots, Requirement.Zora_Armor, Requirement.lakebed_temple_3_small_keys},
        6189,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x04
    },
    {
        "Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots, Requirement.Zora_Armor Requirement.lakebed_temple_3_small_keys},
        618E,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x16
    },
    {
        "Lakebed_Temple_Deku_Toad_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_deku_toad},
        B9C7,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x44
    },
    {
        "Lakebed_Temple_Chandelier_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        01A0,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x21
    },
    {
        "Lakebed_Temple_East_Water_Supply_Clawshot_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.lakebed_temple_3_small_keys},
        3CC9,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x05
    },
    {
        "Lakebed_Temple_Central_Room_Center_Spire_Chest",
        true,
        new list<Requirement> {Requirement.can_launch_bombs, Requirement.lakebed_temple_3_small_keys, Requirement.Iron_Boots},
        7F1C,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x04
    },
    {
        "Lakebed_Temple_West_Lower_Small_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        B93A,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x17
    },
    {
        "Lakebed_Temple_West_Water_Supply_Small_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        BAF9,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x17
    },
    {
        "Lakebed_Temple_West_Water_Supply_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        EE15,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots, Requirement.Clawshot},
        E582,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x04
    },
    {
        "Lakebed_Temple_West_Second_Floor_Central_Small_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        1077,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x04
    },
    {
        "Lakebed_Temple_West_Second_Floor_Northeast_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        3BC1,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x04
    },
    {
        "Lakebed_Temple_West_Second_Floor_Southeast_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        AD57,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x18
    },
    {
        "Lakebed_Temple_Big_Key_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Water_Bombs},
        4429,
        false,
        new list<String> {"Chest", "Lakebed Temple", "Boss Key"},
        0x93
    },
    {
        "Lakebed_Temple_Underwater_Maze_Small_Chest",
        true,
        new list<Requirement> {Zora_Armor},
        F508,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x16
    },
    {
        "Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest",
        true,
        new list<Requirement> {Requirement.can_launch_bombs. Requirement.Clawshot, Requirement.lakebed_temple_3_small_keys},
        CF36,
        false,
        new list<String> {"Chest", "Lakebed Temple"},
        0x21
    },
    {
        "Sacred_Grove_Deku_Baba_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_baba_serpent, Requirement.can_knock_down_hanging_baba},
        F29C,
        false,
        new list<String> {"Chest", "Sacred Grove"},
        0x21
    },
    {
        "West_Hyrule_Field_Helmasaur_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_helmasaur},
        4904,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Lake_Lantern_Cave_First_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        9E56,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x1A
    },
    {
        "Lake_Lantern_Cave_Second_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        4D30,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x03
    },
    {
        "Lake_Lantern_Cave_Third_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        F9D2,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x04
    },
    {
        "Lake_Lantern_Cave_Fourth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        6E51,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x0E
    },
    {
        "Lake_Lantern_Cave_Fifth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        BA10,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x04
    },
    {
        "Lake_Lantern_Cave_Sixth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        B395,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Lake_Lantern_Cave_Seventh_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        04DD,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x04
    },
    {
        "Lake_Lantern_Cave_Eighth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        3B1C,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x1A
    },
    {
        "Lake_Lantern_Cave_Ninth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        DBF7,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x0E
    },
    {
        "Lake_Lantern_Cave_Tenth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        254F,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },
    {
        "Lake_Lantern_Cave_Eleventh_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        917E,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x1B
    },
    {
        "Lake_Lantern_Cave_Twelfth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        F086,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },
    {
        "Lake_Lantern_Cave_Thirteenth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        D490,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x12
    },
    {
        "Lake_Lantern_Cave_Fourteenth_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        39C1,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Lake_Lantern_Cave_End_Lantern_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern},
        34C1,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x21
    },
    {
        "Lake_Hylia_Water_Toadpoli_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_water_toadpoli},
        4F3E,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Outside_Lanayru_Spring_Left_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        326F,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },
    {
        "Outside_Lanayru_Spring_Right_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        6662,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Lanayru_Spring_Underwater_Left_Chest"
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        008C,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x02
    },
    {
        "Lanayru_Spring_Underwater_Right_Chest"
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        9C47,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x03
    },
    {
        "Lanayru_Spring_Back_Room_Left_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot},
        2253,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x02
    },
    {
        "Lanayru_Spring_Back_Room_Right_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot},
        8036,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x0A
    },
    {
        "Lanayru_Spring_Back_Room_Lantern_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Lantern},
        4240,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x21
    },
    {
        "Flight_By_Fowl_Top_Platform"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        F3CC,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Flight_By_Fowl_Second_Platform"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        4003,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x21
    },
    {
        "Flight_By_Fowl_Third_Platform"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        FAEB,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },
    {
        "Flight_By_Fowl_Fourth_Platform"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        DD8C,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x04
    },
    {
        "Flight_By_Fowl_Fifth_Platform"
        true,
        new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
        6633,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x03
    },
    {
        "Lake_Hylia_Shell_Blade_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_shell_blade},
        A6A6,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Zoras_Domain_Light_All_Torches_Chest"
        true,
        new list<Requirement> {Requirement.Lantern},
        CB68,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },
    {
        "Zora_Domain_Extinguish_All_Torches_Chest"
        true,
        new list<Requirement> {Requirement.Boomerang},
        827F,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x05
    },

    {
        "Lanayru_Field_Skulltula_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_skulltula, Requirement.Lantern},
        A444,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Lanayru_Field_Behind_Gate_Underwater_Chest"
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        FC21,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Lake_Hylia_Bridge_Vines_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot},
        0D81,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Lake_Hylia_Bridge_Bubble_Grotto_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_bubble, Requirement.can_defeat_fire_bubble, Requirement.can_defeat_ice_bubble},
        6D05,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Lake_Hylia_Bridge_Cliff_Chest"
        true,
        new list<Requirement> {Requirement.can_launch_bombs, Requirement.Clawshot},
        7216,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Faron_Field_Bridge_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot},
        D552,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Faron_Field_Corner_Grotto_Right_Chest"
        true,
        new list<Requirement> {},
        D1D5,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x04
    },
    {
        "Faron_Field_Corner_Grotto_Rear_Chest"
        true,
        new list<Requirement> {},
        121E,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x03
    },
    {
        "Faron_Field_Corner_Grotto_Left_Chest"
        true,
        new list<Requirement> {},
        74C4,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x04
    },
    {
        "Death_Mountain_Alcove_Chest"
        true,
        new list<Requirement> {Requirement.can_beat_mines_or_clawshot},
        6c2e,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x21
    },
    {
        "Eldin_Lantern_Cave_First_Chest"
        true,
        new list<Requirement> {Requirement.can_burn_webs},
        6168,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x04
    },
    {
        "Eldin_Lantern_Cave_Second_Chest"
        true,
        new list<Requirement> {Requirement.can_burn_webs},
        BAF6,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Eldin_Lantern_Cave_Lantern_Chest"
        true,
        new list<Requirement> {Requirement.Lantern},
        C037,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "South_Castle_Field_Tightrope_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Shadow_Crystal},
        79AC,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Outside_South_Castle_Town_Tetike_Grotto_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_tetike},
        0245,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Eldin_Field_Bomskit_Grotto_Left_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bomskit},
        96E8,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Eldin_Field_Bomskit_Grotto_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bomskit, Requirement.Lantern},
        D3C9,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Eldin_Field_Water_Bomb_Fish_Grotto_Chest",
        true,
        new list<Requirement> {},
        3E7D,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x05
    },
    {
        "Gerudo_Desert_Skulltula_Grotto_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_skulltula},
        421A,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x06
    },
    {
        "Gerudo_Desert_Peahat_Ledge_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        CA80,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x04
    },
    {
        "Gerudo_Desert_East_Canyon_Chest",
        true,
        new list<Requirement> {},
        1157,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x04
    },
    {
        "Gerudo_Desert_Lone_Small_Chest",
        true,
        new list<Requirement> {},
        5605,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x0E
    },
    {
        "Eldin_Stockcave_Upper_Chest",
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        B84B,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x04
    },
    {
        "Eldin_Stockcave_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern, Requirement.Iron_Boots},
        64DC,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Eldin_Stockcave_Lowest_Chest",
        true,
        new list<Requirement> {},
        9C80,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Gerudo_Desert_West_Canyon_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        0177,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x05
    },
    {
        "Gerudo_Desert_Poe_Grotto_Lantern_Chest",
        true,
        new list<Requirement> {},
        D3D9,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x06
    },
    {
        "Gerudo_Desert_Northeast_Chest_Behind_Gates",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        9753,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x04
    },
    {
        "Gerudo_Desert_South_Chest_Behind_Wooden_Gates",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        577F,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x06
    },
    {
        "Gerudo_Desert_Campfire_North_Chest",
        true,
        new list<Requirement> {},
        583B,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x04
    },
    {
        "Gerudo_Desert_Campfire_East_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        1190,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x05
    },
    {
        "Gerudo_Desert_Campfire_West_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        3A41,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x0E
    },
    {
        "Gerudo_Desert_Northwest_Chest_Behind_Gates",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        9F29,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x04
    },
    {
        "Gerudo_Desert_North_Small_Chest_Before_Bublin_Camp",
        true,
        new list<Requirement> {Requirement.can_defeat_bublin},
        F2F6,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x0E
    },
    {
        "Bublin_Camp_First_Chest_Under_Tower_at_Entrance",
        true,
        new list<Requirement> {},
        C193,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x0F
    },
    {
        "Bublin_Camp_Small_Chest_in_Back_of_Camp",
        true,
        new list<Requirement> {},
        309E,
        false,
        new list<String> {"Chest", "Gerudo Desert"}
        0x05
    },
    {
        "Outside_Arbiters_Grounds_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        27B1,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x05
    },
    {
        "Arbiters_Grounds_Lobby_Chest",
        true,
        new list<Requirement> {Requirement.can_break_wooden_door},
        FC38,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Small Key"},
        0x88
    },
    {
        "Arbiters_Grounds_East_Lower_Turnable_Redead_Chest",
        true,
        new list<Requirement> {Requirement.Shadow_Crystal, Requirement.Poe_Scent, Requirement.can_defeat_redead_knight},
        BF75,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Small Key"},
        0x88
    },
    {
        "Arbiters_Grounds_Torch_Room_East_Chest",
        true,
        new list<Requirement> {},
        1F95,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x21
    },
    {
        "Arbiters_Grounds_Torch_Room_West_Chest",
        true,
        new list<Requirement> {},
        FAA5,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Arbiters_Grounds_East_Upper_Turnable_Chest",
        true,
        new list<Requirement> {},
        73DB,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Arbiters_Grounds_East_Upper_Turnable_Redead_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_redead_knight},
        F20F,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Small Key"},
        0x88
    },
    {
        "Arbiters_Grounds_Ghoul_Rat_Room_Chest",
        true,
        new list<Requirement> {},
        05A6,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Small Key"},
        0x88
    },
    {
        "Arbiters_Grounds_West_Small_Chest_Behind_Block",
        true,
        new list<Requirement> {},
        B294,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x04
    },
    {
        "Arbiters_Grounds_West_Chandelier_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_ghoul_rat, Requirement.arbiters_grounds_4_small_keys},
        B288,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x04
    },
    {
        "Arbiters_Grounds_West_Stalfos_North_Chest",
        true,
        new list<Requirement> {Requirement.can_break_wooden_door},
        E296,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x0A
    },
    {
        "Arbiters_Grounds_West_Stalfos_Southeast_Chest",
        true,
        new list<Requirement> {Requirement.can_break_wooden_door},
        36DB,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x0A
    },
    {
        "Arbiters_Grounds_North_Turning_Room_Chest",
        true,
        new list<Requirement> {},
        4B87,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Small Key"},
        0x88
    },
    {
        "Death_Sword_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_death_sword},
        8318,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x41
    },
    {
        "Arbiters_Grounds_Spinner_Room_First_Small_Chest",
        true,
        new list<Requirement> {},
        477D,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x0B
    },
    {
        "Arbiters_Grounds_Spinner_Room_Second_Small_Chest",
        true,
        new list<Requirement> {},
        BB1E,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x04
    },
    {
        "Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest",
        true,
        new list<Requirement> {Requirement.Spinner},
        8F23,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x03
    },
    {
        "Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest",
        true,
        new list<Requirement> {Requirement.Spinner},
        0EF4,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x21
    },
    {
        "Arbiters_Grounds_Spinner_Room_Lower_North_Chest",
        true,
        new list<Requirement> {Requirement.Spinner},
        8080,
        false,
        new list<String> {"Chest", "Arbiter's Grounds"},
        0x03
    },
    {
        "Arbiters_Grounds_Big_Key_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.arbiters_grounds_5_small_keys, Requirement.Spinner},
        47CF,
        false,
        new list<String> {"Chest", "Arbiter's Grounds", "Boss Key"},
        0x94
    },
    {
        "Lanayru_Field_Spinner_Track_Chest",
        true,
        new list<Requirement> {Requirement.Spinner, Requirement.can_smash},
        2385,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Lanayru_Field_Stalfos_Grotto_Right_Small_Chest",
        true,
        new list<Requirement> {},
        D6A8,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x0A
    },
    {
        "Lanayru_Field_Stalfos_Grotto_Left_Small_Chest",
        true,
        new list<Requirement> {},
        E854,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x0A
    },
    {
        "Lanayru_Field_Stalfos_Grotto_Stalfos_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_stalfos},
        6D8E,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Outside_South_Castle_Town_Fountain_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Spinner},
        25C6,
        false,
        new list<String> {"Chest", "Forest Temple"},
        0x06
    },
    {
        "Ordon_Ranch_Grotto_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        0BE9,
        false,
        new list<String> {"Chest", "Ordonia Province"},
        0x05
    },
    {
        "Faron_Mist_Stump_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        411C,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x04
    },
    {
        "Faron_Mist_North_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        BF66,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x03
    },
    {
        "Faron_Mist_South_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        300D,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x05
    },
    {
        "Snowpeak_Ruins_West_Courtyard_Buried_Chest",
        true,
        new list<Requirement> {Requirement.Shadow_Crystal},
        FD69,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Small Key"},
        0x89
    },
    {
        "Snowpeak_Ruins_East_Courtyard_Buried_Chest",
        true,
        new list<Requirement> {Requirement.Shadow_Crystal},
        2725,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x04
    },
    {
        "Snowpeak_Ruins_Ordon_Pumpkin_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_chilfos},
        F5CA,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Dungeon Items", "Ordon Pumpkin"},
        0xF4
    },
    {
        "Snowpeak_Ruins_East_Courtyard_Chest",
        true,
        new list<Requirement> {Requirement.Shadow_Crystal},
        F35C,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Small Key"},
        0x89
    },
    {
        "Snowpeak_Ruins_Wooden_Beam_Central_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_ice_keese},
        A3A7,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x04
    },
    {
        "Snowpeak_Ruins_Wooden_Beam_Northwest_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_ice_keese},
        A356,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Snowpeak_Ruins_Courtyard_Central_Chest",
        true,
        new list<Requirement> {Requirement.can_break_snowpeak_ruins_central_ice},
        E51D,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x0A
    },
    {
        "Snowpeak_Ruins_Chest_After_Darkhammer",
        true,
        new list<Requirement> {Requirement.can_defeat_darkhammer, Requirement.Ball_And_Chain},
        5786,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0xF5
    },
    {
        "Snowpeak_Ruins_Broken_Floor_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        569D,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x21
    },
    {
        "Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest",
        true,
        new list<Requirement> {Requirement.Ordon_Goat_Cheese, Requirement.can_defeat_chilfos, Requirement.Ball_And_Chain},
        F06A,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Small Key"},
        0x89
    },
    {
        "Snowpeak_Ruins_Lobby_Chandelier_Chest",
        true,
        new list<Requirement> {Requirement.Ordon_Goat_Cheese, Requirement.Ball_And_Chain, Requirement.snowpeak_ruins_3_small_keys},
        2D6A,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x21
    },
    {
        "Snowpeak_Ruins_Lobby_West_Armor_Chest",
        true,
        new list<Requirement> {Ball_And_Chain},
        E95B,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x04
    },
    {
        "Snowpeak_Ruins_Lobby_East_Armor_Chest",
        true,
        new list<Requirement> {Ball_And_Chain},
        D9CE,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x03
    },
    {
        "Snowpeak_Ruins_Northeast_Chandelier_Chest",
        true,
        new list<Requirement> {Requirement.Ordon_Goat_Cheese, Requirement.Ball_And_Chain, Requirement.Clawshot, Requirement.snowpeak_ruins_3_small_keys},
        A485,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Small Key"},
        0x89
    },
    {
        "Snowpeak_Ruins_West_Cannon_Room_Central_Chest",
        true,
        new list<Requirement> {Requirement.Ball_And_Chain},
        CB52,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x04
    },
    {
        "Snowpeak_Ruins_West_Cannon_Room_Corner_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        98E8,
        false,
        new list<String> {"Chest", "Snowpeak Ruins"},
        0x0A
    },
    {
        "Snowpeak_Ruins_Chapel_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_chilfos},
        9C1C,
        false,
        new list<String> {"Chest", "Snowpeak Ruins", "Boss Key"},
        0xF6
    },
    {
        "Snowpeak_Cave_Ice_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Ball_And_Chain, Requirement.Lantern},
        7A70,
        false,
        new list<String> {"Chest", "Snowpeak Province"},
        0x06
    },
    {
        "Snowpeak_Freezard_Grotto_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_freezard, Requirement.can_defeat_ice_keese, Requirement.Ball_And_Chain},
        4584,
        false,
        new list<String> {"Chest", "Snowpeak Province"},
        0x06
    },
    {
        "Lanayru_Ice_Block_Puzzle_Cave_Chest",
        true,
        new list<Requirement> {Requirement.Ball_And_Chain},
        3100,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Lost_Woods_Lantern_Chest",
        true,
        new list<Requirement> {Requirement.Lantern},
        A7D3,
        false,
        new list<String> {"Chest", "Sacred Grove"},
        0x0D
    },
    {
        "Sacred_Grove_Spinner_Chest",
        true,
        new list<Requirement> {Requirement.Spinner},
        4A9B,
        false,
        new list<String> {"Chest", "Sacred grove"},
        0x06
    },
    {
        "Temple_of_Time_Lobby_Lantern_Chest"
        true,
        new list<Requirement> {Requirement.Lantern},
        BC22,
        false,
        new list<String> {"Chest", "Temple of Time", "Small Key"},
        0x8A
    },
    {
        "Temple_of_Time_First_Staircase_Gohma_Gate_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_young_gohma},
        298C,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x10
    },
    {
        "Temple_of_Time_First_Staircase_Window_Chest"
        true,
        new list<Requirement> {Requirement.has_ranged_item},
        C45E,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x04
    },
    {
        "Temple_of_Time_First_Staircase_Armos_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_armos},
        C637,
        false,
        new list<String> {"Chest", "Temple of Time", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Temple_of_Time_Statue_Throws_Room_East_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_armos}
        BB75,
        false,
        new list<String> {"Chest", "Temple of Time", "Small Key"},
        0x8A
    },
    {
        "Temple_of_Time_Moving_Wall_Beamos_Room_Chest"
        true,
        new list<Requirement> {Requirement.Bow},
        E368,
        false,
        new list<String> {"Chest", "Temple of Time", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Temple_of_Time_Scales_Gohma_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_young_gohma, Requirement.can_defeat_baby_gohma},
        E586,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x05
    },
    {
        "Temple_of_Time_Gilloutine_Chest"
        true,
        new list<Requirement> {},
        35F9,
        false,
        new list<String> {"Chest", "Temple of Time", "Small Key"},
        0x8A
    },
    {
        "Temple_of_Time_Chest_Before_Midboss"
        true,
        new list<Requirement> {Requirement.can_defeat_armos, Requirement.can_defeat_baby_gohma, Requirement.can_defeat_young_gohma},
        1A52,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x05
    },
    {
        "Temple_of_Time_Darknut_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_darknut},
        DAD6,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x46
    },
    {
        "Temple_of_Time_Scales_Upper_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Spinner},
        BD60,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x04
    },
    {
        "Temple_of_Time_Big_Key_Chest_Room_Upper_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot},
        BCFE,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x04
    },
    {
        "Temple_of_Time_Big_Key_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_helmasaur, Requirement.Clawshot},
        B704,
        false,
        new list<String> {"Chest", "Temple of Time", "Boss Key"},
        0x95
    },
    {
        "Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_dinalfos, Requirement.Dominion_Rod }
        D3B5,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x21
    },
    {
        "Temple_of_Time_Statue_Throws_Room_North_Chest"
        true,
        new list<Requirement> {},
        9BC3,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x04
    },
    {
        "Temple_of_Time_Statue_Throws_Room_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Dominion_Rod},
        1F68,
        false,
        new list<String> {"Chest", "Temple of Time"},
        0x21
    },
    {
        "Sacred_Grove_Past_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Dominion_Rod},
        7968,
        false,
        new list<String> {"Chest", "Sacred Grove"},
        0x21
    },
    {
        "Doctors_Office_Balcony_Chest"
        true,
        new list<Requirement> {Requirement.Invoice, Requirement.Shadow_Crystal},
        0E38,
        false,
        new list<String> {"Chest", "Castle Town"},
        0x04
    },
    {
        "Bridge_of_Eldin_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Powered_Dominion_Rod},
        04B8,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Kakariko_Gorge_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Powered_Dominion_Rod},
        773C,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Hyrule_Field_Ampitheater_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Powered_Dominion_Rod},
        DE51,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Lake_Hylia_Bridge_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Powered_Dominion_Rod, Requirement.Clawshot},
        0ADD,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Faron_Woods_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Powered_Dominion_Rod, Requirement.Shadow_Crystal},
        558A,
        false,
        new list<String> {"Chest", "Faron Woods"},
        0x21
    },
    {
        "Gerudo_Desert_Owl_Statue_Chest"
        true,
        new list<Requirement> {Requirement.Powered_Dominion_Rod},
        8F1F,
        false,
        new list<String> {"Chest", "Gerudo Desert"},
        0x06
    },
    {
        "City_in_The_Sky_Underwater_West_Chest"
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        CF09,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x18
    },
    {
        "City_in_The_Sky_Underwater_East_Chest"
        true,
        new list<Requirement> {Requirement.Iron_Boots},
        DF0C,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_West_Wing_First_Chest"
        true,
        new list<Requirement> {},
        18B6,
        false,
        new list<String> {"Chest", "City in The Sky", "Small Key"},
        0x8B
    },
    {
        "City_in_The_Sky_East_First_Wing_Chest_After_Fans"
        true,
        new list<Requirement> {Requirement.Clawshot},
        37C7,
        false,
        new list<String> {"Chest", "City in The Sky", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "City_in_The_Sky_East_Tile_Worm_Small_Chest"
        true,
        new list<Requirement> {},
        5940,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x03
    },
    {
        "City_in_The_Sky_East_Wing_After_Dinalfos_Alcove_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_tile_worm},
        5C4D,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_East_Wing_After_Dinalfos_Ledge_Chest"
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_tile_worm},
        8705,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x05
    },
    {
        "City_in_The_Sky_Aeralfos_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_aeralfos, Requirement.Clawshot, Requirement.Iron_Boots},
        26B5,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x47
    },
    {
        "City_in_The_Sky_East_Wing_Lower_Level_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        A2C1,
        false,
        new list<String> {"Chest", "City in The Sky", "Dungeon Items", "Compass"},
        0x24
    },

    {
        "City_in_The_Sky_West_Wing_Baba_Balcony_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        63B4,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x0F
    },
    {
        "City_in_The_Sky_West_Wing_Narrow_Ledge_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        C5A9,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_West_Wing_Tile_Worm_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        F48A,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x0B
    },
    {
        "City_in_The_Sky_Baba_Tower_Top_Small_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot},
        2DD1,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x03
    },
    {
        "City_in_The_Sky_Baba_Tower_Narrow_Ledge_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot},
        781F,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_Baba_Tower_Alcove_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_big_baba, Requirement.can_defeat_baba_serpent, Requirement.Double_Clawshot},
        4E34,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x21
    },
    {
        "City_in_The_Sky_West_Garden_Corner_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        13EF,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_West_Garden_Lone_Island_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        C036,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x05
    },
    {
        "City_in_The_Sky_West_Garden_Lower_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        3EB9,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x0A
    },
    {
        "City_in_The_Sky_West_Garden_Ledge_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        EAD5,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x21
    },
    {
        "City_in_The_Sky_Central_Outside_Ledge_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal},
        6441,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_Central_Outside_Poe_Island_Chest"
        true,
        new list<Requirement> {Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal},
        5722,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x05
    },
    {
        "City_in_The_Sky_Big_Key_Chest_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow Crystal, Requirement.Iron_Boots},
        AAD2,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x96
    },
    {
        "City_in_The_Sky_Chest_Below_Big_Key_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_helmasaur},
        F965,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x04
    },
    {
        "City_in_The_Sky_Chest_Behind_North_Fan"
        true,
        new list<Requirement> {Requirement.can_defeat_helmasaurus, Requirement.can_defeat_dinalfos, Requirement.can_defeat_kargorok, Requirement.can_defeat_walltula, Requirement.Shadow_Crystal, Requirement.Iron_Boots, Requirement.Double_Clawshot},
        7B61,
        false,
        new list<String> {"Chest", "City in The Sky"},
        0x05
    },
    {
        "Kakariko_Gorge_Double_Clawshot_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        BF8B,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Lanayru_Spring_East_Double_Clawshot_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        A2E9,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "Lanayru_Spring_West_Double_Clawshot_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        04BF,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x06
    },
    {
        "South_of_Castle_Town_Double_Clawshot_Chasm_Chest"
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        293A,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x06
    },
    {
        "Palace_of_Twilight_West_Wing_First_Room_Central_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head},
        283D,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Central_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head},
        32E9,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head},
        8277,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest",
        true,
        new list<Requirement> {Requirement.Double_Clawshot},
        2E9D,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x06
    },
    {
        "Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness",
        true,
        new list<Requirement> {Requirement.Light_Sword, Requirement.Clawshot},
        893A,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x21
    },
    {
        "Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest",
        true,
        new list<Requirement> {Requirement.Clawshot},
        0F31,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x05
    },
    {
        "Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head, Requirement.Clawshot},
        F92E,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot},
        B204,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x05
    },
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot},
        8702,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x05
    },
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot},
        E301,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head, Requirement.can_defeat_shadow_beast, Requirement.Double_Clawshot},
        1697,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_East_Wing_First_Room_East_Alcove",
        true,
        new list<Requirement> {Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot, Requirement.can_defeat_phantom_zant},
        A2E3,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x21
    },
    {
        "Palace_of_Twilight_East_Wing_First_Room_West_Alcove",
        true,
        new list<Requirement> {Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot, Requirement.can_defeat_phantom_zant},
        FA68,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x05
    },
    {
        "Palace_of_Twilight_Central_First_Room_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head},
        8F8C,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_Big_Key_Chest",
        true,
        new list<Requirement> {Requirement.LightSword, Requirement.Double_Clawshot},
        1BCC,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x97
    },
    {
        "Palace_of_Twilight_Central_Outdoor_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_zant_head},
        1F63,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Palace_of_Twilight_Central_Tower_Chest",
        true,
        new list<Requirement> {Requirement.Light_Sword, Requirement.Clawshot, Requirement.can_defeat_zant_head},
        3506,
        false,
        new list<String> {"Chest", "Palace of Twilight", "Small Key"},
        0x8C
    },
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        E956,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x06
    },
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        BF0D,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x01
    },
    {
        "Hyrule_Castle_Graveyard_Grave_Switch_Room_Back_Left_Chest",
        true,
        new list<Requirement> {Requirement.can_smash},
        1F6C,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x04
    },
    {
        "Hyrule_Castle_Graveyard_Owl_Statue_Chest",
        true,
        new list<Requirement> {Requirement.can_smash, Requirement.Lantern, Requirement.Powered_Dominion_Rod},
        87FB,
        false,
        new list<String> {"Chest", "Hyrule Castle", "Small Key"},
        0x8D
    },
    {
        "Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest",
        true,
        new list<Requirement> {Requirement.Boomerang},
        1533,
        false,
        new list<String> {"Chest", "Hyrule Castle", "Dungeon Items", "Dungeon Map"},
        0x23
    },
    {
        "Hyrule_Castle_East_Wing_Balcony_Chest",
        true,
        new list<Requirement> {Requirement.Boomerang},
        592C,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x03
    },
    {
        "Hyrule_Castle_West_Courtyard_North_Small_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bokoblin},
        5Eb3,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x04
    },
    {
        "Hyrule_Castle_West_Courtyard_Central_Small_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bokoblin},
        22F4,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x04
    },
    {
        "Hyrule_Castle_Main_Hall_Northeast_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_lizalfos, Requirement.Clawshot},
        3107,
        false,
        new list<String> {"Chest", "Hyrule Castle", "Dungeon Items", "Compass"},
        0x24
    },
    {
        "Hyrule_Castle_Lantern_Staircase_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang},
        09D2,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x05
    },
    {
        "Hyrule_Castle_Main_Hall_Southwest_Chest",
        true,
        new list<Requirement> {Requirement.can_knock_down_hc_painting, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Boomerang, Requirement.Lantern, Requirement.Double_Clawshot},
        F83F,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x05
    },
    {
        "Hyrule_Castle_Main_Hall_Northwest_Chest",
        true,
        new list<Requirement> {RRequirement.can_knock_down_hc_painting, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Boomerang, Requirement.Lantern, Requirement.Double_Clawshot},
        A782,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x07
    },
    {
        "Hyrule_Castle_Southeast_Balcony_Tower_Chest",
        true,
        new list<Requirement> {Requirement.can_defeat_aeralfos},
        8C2C,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x8D
    },
    {
        "Hyrule_Castle_Big_Key_Chest",
        true,
        new list<Requirement> {},
        9553,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x98
    },
    {
        "Hyrule_Castle_Treasure_Room_Eighth_Small_Chest",
        true,
        new list<Requirement> {},
        D762,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x02
    },
    {
        "Hyrule_Castle_Treasure_Room_Seventh_Small_Chest",
        true,
        new list<Requirement> {},
        5423,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x03
    },
    {
        "Hyrule_Castle_Treasure_Room_Sixth_Small_Chest",
        true,
        new list<Requirement> {},
        D2E3,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x04
    },
    {
        "Hyrule_Castle_Treasure_Room_Fifth_Small_Chest",
        true,
        new list<Requirement> {},
        EB62,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x18
    },
    {
        "Hyrule_Castle_Treasure_Room_Fourth_Small_Chest",
        true,
        new list<Requirement> {},
        349E,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x0F
    },
    {
        "Hyrule_Castle_Treasure_Room_Third_Small_Chest",
        true,
        new list<Requirement> {},
        9CB6,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x0C
    },
    {
        "Hyrule_Castle_Treasure_Room_Second_Small_Chest",
        true,
        new list<Requirement> {},
        618F,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x01
    },
    {
        "Hyrule_Castle_Treasure_Room_First_Small_Chest",
        true,
        new list<Requirement> {},
        0302,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x10
    },
    {
        "Hyrule_Castle_Treasure_Room_Fifth_Chest",
        true,
        new list<Requirement> {},
        4B86,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x05
    },
    {
        "Hyrule_Castle_Treasure_Room_Fourth_Chest",
        true,
        new list<Requirement> {},
        2D5C,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x1B
    },
    {
        "Hyrule_Castle_Treasure_Room_Third_Chest",
        true,
        new list<Requirement> {},
        6508,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x07
    },
    {
        "Hyrule_Castle_Treasure_Room_Second_Chest",
        true,
        new list<Requirement> {},
        19D2,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x12
    },
    {
        "Hyrule_Castle_Treasure_Room_First_Chest",
        true,
        new list<Requirement> {},
        7086,
        false,
        new list<String> {"Chest", "Hyrule Castle"},
        0x06
    },
    {
        "Kakariko_Bomb_Rock_Spire_Heart_Piece",
        true,
        new list<Requirement> {Requirement.Bombs, Requirement.can_launch_bombs},
        A573,
        false,
        new list<String> {"Chest", "Eldin Province"},
        0x21
    },
    {
        "Faron_Field_Tree_Heart_Piece",
        true,
        new list<Requirement> {CRequirement.clawshot_or_boomerang},
        7E86,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Kakariko_Gorge_Spire_Heart_Piece",
        true,
        new list<Requirement> {Requirement.clawshot_or_boomerang},
        B035,
        false,
        new list<String> {"Chest", "Hyrule Field"},
        0x21
    },
    {
        "Zant_Heart_Container",
        true,
        new list<Requirement> {Requirement.can_defeat_zant},
        93FC,
        false,
        new list<String> {"Chest", "Palace of Twilight"},
        0x22
    },
    {
        "Fishing_Hole_Heart_Piece",
        true,
        new list<Requirement> {Requirement.Clawshot, Requirement.Lanayru_Vessel_of_Light},
        0FAA,
        false,
        new list<String> {"Chest", "Lanayru Province"},
        0x21
    },
    {
        "Cats_Hide_and_Seek_Minigame",
        true,
        new list<Requirement> {Requirement.Ilias_Charm},
        9E3C,
        false,
        new list<String> {"Chest", "Hidden Village"},
        0x21
    },
}