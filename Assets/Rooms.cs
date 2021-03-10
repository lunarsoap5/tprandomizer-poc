using Checks;
using Requirements;

/* This is the sandard that will be used on checks from now on*/

/*Room names*/


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


Room[] rooms
{
    { //4
        "lakebed_temple_07",
        "neighbours": ["lakebed_temple_02_03, lakebed_temple_10, lakebed_temple_08"],
        
            "true"
            "Requirement.can_lauch_bombs}
            "Requirement.can_lauch_bombs}
        }
        false,
        "checks": ["Lakebed_Temple_East_Second_Floor_Southwest_Chest,
            "Lakebed_Temple_East_Second_Floor_Southeast_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //5
        "lakebed_temple_08",
        "neighbours": ["lakebed_temple_02_03, lakebed_temple_09"],
        
            "true"
            "Requirement.lakebed_temple_3_small_keys, Requirement.can_launch_bombs}
        }
        false,
        "checks": ["Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest,
            "Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //6
        "lakebed_temple_09",
        "neighbours": ["lakebed_temple_08, deku_toad"],
        
            "true"
            "Requirement.lakebed_temple_3_small_keys, Requirement.Zora_Armor, Requirement.Water_Bombs}
        }
        false,
        "checks": ["Lakebed_Temple_Before_Deku_Toad_Alcove_Chest,
            "Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest,
            "Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //7
        "lakebed_temple_10",
        "neighbours": ["lakebed_temple_07"],
        
            "true"
        }
        false,
        "checks": ["Lakebed_Temple_East_Water_Supply_Small_Chest,
            "Lakebed_Temple_East_Water_Supply_Clawshot_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //8
        "lakebed_temple_11",
        "neighbours": ["lakebed_temple_02_03, lakebed_temple_12, lakebed_temple_13"],
        
            "Requirement.Clawshot, Requirement.can_lauch_bombs}
            "true"
            "Requirement.Clawshot, Requirement.can_lauch_bombs}
        }
        false,
        "checks": ["Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest,
            "Lakebed_Temple_West_Second_Floor_Northeast_Chest,
            "Lakebed_Temple_West_Second_Floor_Southeast_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //9
        "lakebed_temple_12",
        "neighbours": ["lakebed_temple_11, lakebed_temple_02_03, lakebed_temple_05"],
        
            "Requirement.Clawshot}
            "true"
			"Requirement.Clawshot}
        }
        false,
        "checks": ["Lakebed_Temple_West_Lower_Small_Chest,
            "Lakebed_Temple_West_Second_Floor_Central_Small_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //10
        "lakebed_temple_13",
        "neighbours": ["lakebed_temple_11"],
        
            "true"
        }
        false,
        "checks": ["Lakebed_Temple_West_Water_Supply_Small_Chest,
            "Lakebed_Temple_West_Water_Supply_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //11
        "deku_toad",
        "neighbours": ["lakebed_temple_09"],
        
            "Requirement.Can_Defeat_Deku_Toad, Requirement.Clawshot}
        }
        false,
        "checks": ["Lakebed_Temple_Deku_Toad_Chest
        } 
        
        false,
        "Lakebed Temple"
    }
    { //12
        "morpheel",
        "neighbours": ["lake_hylia"],
        
            "Requirement.Can_Defeat_Morpheel}
        }
        false,
        "checks": "", 
        
        false,
        "Lakebed Temple"
    }
    { //13
        "goron_mines_01",
        "neighbours": ["death_mountain_interiors, goron_mines_03"],
        
            "true"
            "Requirement.Iron_Boots}
        }
        false,
        "checks": ["Goron_Mines_Entrance_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //14
        "goron_mines_03",
        "neighbours": ["goron_mines_01, goron_mines_04_05, goron_mines_06"],
        
            "true"
            "Requirement.goron_mines_1_small_key}
            "Requirement.goron_mines_1_small_key, Requirement.Iron_Boots}
        }
        false,
        "checks": ["Goron_Mines_Main_Magnet_Room_Bottom_Chest,
            "Goron_Mines_Main_Magnet_Room_Top_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //15
        "goron_mines_04_05",
        "neighbours": ["goron_mines_03, goron_mines_14"],
        
            "true"
            "Requirement.Iron_Boots}
        }
        false,
        "checks": ["Goron_Mines_Magnet_Maze_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //16
        "goron_mines_06",
        "neighbours": ["goron_mines_03, goron_mines_07"],
        
            "true"
            "Requirement.has_sword_and_irons_or_bow, Requirement.goron_mines_2_small_keys}
        }
        false,
        "checks": ["Goron_Mines_Crystal_Switch_Room_Underwater_Chest,
            "Goron_Mines_Crystal_Switch_Room_Small_Chest,
            "Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //17
        "goron_mines_07",
        "neighbours": ["goron_mines_06, goron_mines_09, goron_mines_12"],
        
            "true"
            "Requirement.goron_mines_3_small_keys}
            "Requirement.Bow, Requirement.Iron_Boots}
        }
        false,
        "checks": ["Goron_Mines_Outside_Beamos_Chest,
            "Goron_Mines_Outside_Underwater_Chest,
            "Goron_Mines_Outside_Clawshot_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //18
        "goron_mines_09_17",
        "neighbours": ["goron_mines_07, dangoro"],
        
            "true"
            "Requirement.Iron_Boots}
        }
        false,
        "checks": ["Goron_Mines_Gor_Ebizo_Chest,
            "Goron_Mines_Chest_Before_Dangoro
        } 
        
        false,
        "Goron Mines"
    }
    { //19
        "goron_mines_11",
        "neighbours": ["dangoro, goron_mines_13, goron_mines_16"],
        
            "true"
            "Requirement.Bow}
            "Requirement.Bow}
        }
        false,
        "checks": ["Goron_Mines_Dangoro_Chest,
            "Goron_Mines_Beamos_Room_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //20
        "goron_mines_12",
        "neighbours": ["goron_mines_07, fyrus"],
        
            "true"
            "Requirement.Bow, Requirement.can_defeat_bublin, Requirement.Goron_Mines_Big_Key}
        }
        false,
        "checks": "", 
        
        false,
        "Goron Mines"
    }
    { //21
        "goron_mines_13",
        "neighbours": ["goron_mines_11, goron_mines_03"],
        
            "true"
            "Requirement.Iron_Boots, Requirement.Bow}
        }
        false,
        "checks": "", 
        
        false,
        "Goron Mines"
    }
    { //22
        "goron_mines_14",
        "neighbours": ["goron_mines_05"],
        
            "true"
        }
        false,
        "checks": ["Goron_Mines_Gor_Amato_Chest,
            "Goron_Mines_Gor_Amato_Small_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //23
        "goron_mines_16",
        "neighbours": ["goron_mines_11"],
        
            "true"
        }
        false,
        "checks": ["Goron_Mines_Gor_Liggs_Chest
        } 
        
        false,
        "Goron Mines"
    }
    { //24
        "fyrus",
        "neighbours": ["kakariko_village"],
        
            "Requirement.Can_Defeat_Fyrus}
        }
        false,
        "checks": "", 
        
        false,
        "Goron Mines"
    }
    { //25
        "dangoro",
        "neighbours": ["goron_mines_09, goron_mines_11"],
        
            "Requirement.Can_Defeat_Dangoro}
            "Requirement.Can_Defeat_Dangoro}
        }
        false,
        "checks": "", 
        
        false,
        "Goron Mines"
    }

    //Forest Temple
    { //26
        "forest_temple_00_01",
        "neighbours": ["forest_temple_22, forest_temple_02, forest_temple_03, forest_temple_09, ook"],
        
            "true"
            "Requirement.can_defeat_bombling_or_burn_webs, Requirement.forest_temple_4_small_keys}
            "Requirement.can_burn_webs, Requirement.can_free_second_monkey_or_clawshot}
            "Requirement.can_defeat_bombling_or_burn_webs}
            "Requirement.can_burn_webs, Requirement.can_defeat_bombling, Requirement.can_defeat_walltula, Requirement.can_defeat_big_baba, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage, Requirement.forest_temple_4_small_keys}
        }
        false,
        "checks": ["Forest_Temple_Central_Chest_Behind_Stairs,
            "Forest_Temple_Central_North_Chest,
            "Forest_Temple_Central_Chest_Hanging_From_Web,
            "Forest_Temple_Big_Key_Chest,
            "Forest_Temple_East_Water_Cave_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //27
        "forest_temple_02",
        "neighbours": ["forest_temple_00_01"],
        
            "Requirement.can_defeat_bokoblin}
        }
        false,
        "checks": ["Forest_Temple_Second_Monkey_Under_Bridge_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //28
        "forest_temple_03",
        "neighbours": ["forest_temple_00_01, forest_temple_05, forest_temple_07, ook"],
        
            "true"
            "Requirement.can_defeat_bombling}
            "Requirement.can_defeat_bombling, Requirement.can_defeat_walltula}
            "Requirement.Boomerang}
        }
        false,
        "checks": ["Forest_Temple_West_Deku_Like_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //29
        "forest_temple_05",
        "neighbours": ["forest_temple_03"],
        
            "true"
        }
        false,
        "checks": ["Forest_Temple_Totem_Pole_Chest,
            "Forest_Temple_West_Tile_Worm_Room_Vines_Chest,
            "Forest_Temple_West_Tile_Worm_Room_Chest_Behind_Stairs
        } 
        
        false,
        "Forest Temple"
    }
    { //30
        "forest_temple_07",
        "neighbours": ["forest_temple_03"],
        
            "true"
        }
        false,
        "checks": "", 
        
        false,
        "Forest Temple"
    }
    { //31
        "forest_temple_09",
        "neighbours": ["forest_temple_00_01, forest_temple_10, forest_temple_11, forest_temple_12"],
        
            "true"
            "Requirement.Boomerang, Requirement.forest_temple_4_small_keys}
            "Requirement.Boomerang}
            "Requirement.Boomerang}
        }
        false,
        "checks": ["Forest_Temple_Windless_Bridge_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //32
        "forest_temple_10",
        "neighbours": ["forest_temple_09"],
        
            "true"
        }
        false,
        "checks": ["Forest_Temple_North_Deku_Like_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //33
        "forest_temple_11",
        "neighbours": ["forest_temple_09"],
        
            "true"
        }
        false,
        "checks": ["Forest_Temple_East_Tile_Worm_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //34
        "forest_temple_12",
        "neighbours": ["forest_temple_09, forest_temple_19, diababa"],
        
            "true"
            "Requirement.Boomerang, Requirement.can_defeat_bokoblin, Requirement.can_defeat_walltula}
            "Requirement.can_burn_webs, Requirement.can_defeat_bombling, Requirement.can_defeat_big_baba, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage, Requirement.forest_temple_4_small_keys, Requirement.Boomerang, Requirement.can_defeat_skulltula, Requirement.can_defeat_walltula}
        }
        false,
        "checks": "", 
        
        false,
        "Forest Temple"
    }
    { //35
        "forest_temple_19",
        "neighbours": ["forest_temple_12"],
        
            "true"
        }
        false,
        "checks": "", 
        
        false,
        "Forest Temple"
    }
    { //36
        "forest_temple_22",
        "neighbours": ["north_faron_woods, forest_temple_00"],
        
            "true"
            "Requirement.can_defeat_walltula, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage}
        }
        false,
        "checks": ["Forest_Temple_Entrance_Vines_Chest
        } 
        
        false,
        "Forest Temple"
    }
    { //37
        "ook",
        "neighbours": ["forest_temple_03"],
        
            "Requirement.Can_Defeat_Ook, Requirement.Boomerang}
        }
        false,
        "checks": "", 
        
        false,
        "Forest Temple"
    }
    { //38
        "diababa",
        "neighbours": ["south_faron_woods"],
        
            "Requirement.Can_Defeat_Diababa}
        }
        false,
        "checks": "", 
        
        false,
        "Forest Temple"
    }
    { //39
        "temple_of_time_00",
        "neighbours": ["sacred_grove_temple_of_time, temple_of_time_01, temple_of_time_08"],
        
            "true"
            "Requirement.temple_of_time_1_small_key}
            "Requirement.Dominion_Rod, Requirement.Bow, Requirement.Spinner, Requirement.can_defeat_lizalfos, Requirement.can_defeat_dinalfos, Requirement.can_defeat_darknut, Requirement.temple_of_time_3_small_keys}
        }
        false,
        "checks": ["Temple_of_Time_Lantern_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //40
        "temple_of_time_01",
        "neighbours": ["temple_of_time_00, temple_of_time_02"],
        
            "true"
            "Requirement.has_ranged_item, Requirement.can_defeat_young_gohma, Requirement.can_defeat_lizalfos}
        }
        false,
        "checks": ["Temple_of_Time_First_Staircase_Gohma_Gate_Chest
            "Temple_of_Time_First_Staircase_Window_Chest,
            "Temple_of_Time_First_Staircase_Armos_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //41
        "temple_of_time_02",
        "neighbours": ["temple_of_time_01, temple_of_time_03, temple_of_time_04"],
        
            "true"
            "Requirement.Spinner}
            "Requirement.Spinner, Requirement.temple_of_time_2_small_keys}
        }
        false,
        "checks": "", 
        
        false,
        "Temple of Time"
    }
    { //42
        "temple_of_time_03",
        "neighbours": ["temple_of_time_02"],
        
            "true"
        }
        false,
        "checks": ["Temple_of_Time_Statue_Throws_Room_East_Chest,
            "Temple_of_Time_Statue_Throws_Room_North_Chest,
            "Temple_of_Time_Statue_Throws_Room_Statue_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //43
        "temple_of_time_04",
        "neighbours": ["temple_of_time_02, temple_of_time_05"],
        
            "true"
            "Requirement.Bow, Requirement.can_defeat_lizalfos, Requirement.can_defeat_dinalfos}
        }
        false,
        "checks": ["Temple_of_Time_Moving_Wall_Beamos_Room_Chest,
            "Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //44
        "temple_of_time_05",
        "neighbours": ["temple_of_time_04, temple_of_time_06, temple_of_time_07"],
        
            "true"
            "Requirement.Clawshot, Requirement.Spinner}
            "true"
        }
        false,
        "checks": ["Temple_of_Time_Scales_Gohma_Chest,
            "Temple_of_Time_Scales_Upper_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //45
        "temple_of_time_06",
        "neighbours": ["temple_of_time_05"],
        
            "true"
        }
        false,
        "checks": ["Temple_of_Time_Big_Key_Chest,
            "Temple_of_Time_Big_Key_Chest_Room_Upper_Chest
        } 
        
        false,
        "Temple of Time"
    }
    { //46
        temple_of_time_07,
        "neighbours": ["temple_of_time_05, darknut"],
        
            "true"
            "Requirement.can_defeat_lizalfos, Requirement.can_defeat_baby_gohma, Requirement.can_defeat_young_gohma, Requirement.can_defeat_armos, Requirement.temple_of_time_3_small_keys}
        }
        false,
        "checks": ["Temple_of_Time_Gilloutine_Chest,
            "Temple_of_Time_Chest_Before_Midboss
        } 
        
        false,
        "Temple of Time"
    }
    { //47
        "temple_of_time_08",
        "neighbours": ["temple_of_time_00, armogohma"],
        new list<list<Requirement>>
        {
            "true"
            "Requirement.Dominion_rod, Requirement.Temple_of_Time_Big_Key}
        }
        false,
        "checks": "", 
        
        false,
        "Temple of Time"
    }
    { //48
        "darknut",
        "neighbours": ["temple_of_time_07"],
        
            "Requirement.Can_Defeat_Darknut, Requirement.Dominion_Rod}
        }
        false,
        "checks": ["Temple_of_Time_Darknut_Chest    
        } 
        
        false,
        "Temple of Time"
    }
    { //49
        "armogohma",
        "neighbours": ["sacred_grove_temple_of_time"],
        
            "Requirement.Can_Defeat_Armogohma}
        }
        false,
        "checks": "", 
        
        false,
        "Temple of Time"
    }

    { //50
        "city_in_the_sky_00_16",
        "neighbours": ["lake_hylia, city_in_the_sky_01"],
        
            "Requirement.Clawshot}
            "Requirement.Clawshot_or_Bow}
        }
        false,
        "checks": ["City_in_The_Sky_Underwater_West_Chest,
            "City_in_The_Sky_Underwater_East_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //51
        "city_in_the_sky_01",
        "neighbours": ["city_in_the_sky_00, city_in_the_sky_02_03_14"],
        
            "true"
            "Requirement.Clawshot}
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //52
        "city_in_the_sky_02_03_14",
        "neighbours": ["city_in_the_sky_01, city_in_the_sky_04, city_in_the_sky_06, city_in_the_sky_15"],
        
            "true"
            "Requirement.Spinner, Requirement.city_in_the_sky_1_small_key}
            "Requirement.Clawshot}
            "Requirement.Double_Clawshot, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_kargarok, Requirement.Shadow_Crystal, Requirement.Iron_Boots}
        }
        false,
        "checks": ["City_in_The_Sky_Big_Key_Chest,
            "City_in_The_Sky_Chest_Below_Big_Key_Chest,
            "City_in_The_Sky_Chest_Behind_North_Fan
        } 
        
        false,
        "City in the Sky"
    }
    { //53
        "city_in_the_sky_04",
        "neighbours": ["city_in_the_sky_02_03_14, city_in_the_sky_07_lower"],
        
            "true"
            "Requirement.Clawshot}
        }
        false,
        "checks": ["City_in_The_Sky_East_First_Wing_Chest_After_Fans,
            "City_in_The_Sky_East_Wing_Lower_Level_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //54
        "city_in_the_sky_05",
        "neighbours": ["city_in_the_sky_04, city_in_the_sky_07_upper, aeralfos"],
        
            "Requirement.Double_Clawshot}
            "true"
            "true"
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //55
        "city_in_the_sky_06",
        "neighbours": ["city_in_the_sky_02_03_14, city_in_the_sky_10"],
        
            "true"
            "Requirement.Double_Clawshot}
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //56
        "city_in_the_sky_07_lower",
        "neighbours": ["city_in_the_sky_04, city_in_the_sky_08"],
        
            "true"
            "Requirement.can_defeat_tile_worm}
        }
        false,
        "checks": ["City_in_The_Sky_East_Tile_Worm_Small_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //57
        "city_in_the_sky_07_upper",
        "neighbours": ["city_in_the_sky_08, city_in_the_sky_05"],
        
            "true"
            "Requirement.Clawshot}
        }
        false,
        "checks": ["City_in_The_Sky_East_Wing_After_Dinalfos_Alcove_Chest,
            "City_in_The_Sky_East_Wing_After_Dinalfos_Ledge_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //58
        "city_in_the_sky_08",
        "neighbours": ["city_in_the_sky_07_lower, city_in_the_sky_07_upper"],
        
            "true"
            "Requirement.Clawshot, Requirement.can_defeat_dinalfos}
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //59
        "city_in_the_sky_10",
        "neighbours": ["city_in_the_sky_06, city_in_the_sky_11"],
        
            "true"
            "Requirement.Double_Clawshot}
        }
        false,
        "checks": ["City_in_The_Sky_West_Wing_First_Chest,
            "City_in_The_Sky_West_Wing_Baba_Balcony_Chest,
            "City_in_The_Sky_West_Wing_Narrow_Ledge_Chest,
            "City_in_The_Sky_West_Wing_Tile_Worm_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //60
        "city_in_the_sky_11",
        "neighbours": ["city_in_the_sky_10, city_in_the_sky_12"],
        
            "true"
            "Requirement.Double_Clawshot, Requirement.can_defeat_baba_serpent}
        }
        false,
        "checks": ["City_in_The_Sky_Baba_Tower_Top_Small_Chest,
            "City_in_The_Sky_Baba_Tower_Narrow_Ledge_Chest,
            "City_in_The_Sky_Baba_Tower_Alcove_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //61
        "city_in_the_sky_12",
        "neighbours": ["city_in_the_sky_11, city_in_the_sky_13"],
        
            "true"
            "Requirement.Double_Clawshot}
        }
        false,
        "checks": ["City_in_The_Sky_West_Garden_Corner_Chest,
            "City_in_The_Sky_West_Garden_Lone_Island_Chest,
            "City_in_The_Sky_West_Garden_Lower_Chest,
            "City_in_The_Sky_West_Garden_Ledge_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //62
        "city_in_the_sky_13",
        "neighbours": ["city_in_the_sky_12, city_in_the_sky_02"],
        
            "Requirement.Double_Clawshot}
            "true"
        }
        false,
        "checks": ["City_in_The_Sky_Central_Outside_Chest,
            "City_in_The_Sky_Central_Outside_Poe_Island_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //63
        "city_in_the_sky_15",
        "neighbours": ["city_in_the_sky_01_02_03_14, argorok"],
        
            "true"
            "Requirement.Double_Clawshot, Requirement.can_defeat_aeralfos, Requirement.City_in_The_Sky_Big_Key}
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //64
        "argorok",
        "neighbours": ["city_in_the_sky_00_16"],
        
            "Requirement.Can_Defeat_Argorok}
        }
        false,
        "checks": "", 
        
        false,
        "City in the Sky"
    }
    { //65
        "aeralfos",
        "neighbours": ["city_in_the_sky_05"],
        
            "Requirement.Double_Clawshot, Requirement.can_defeat_aeralfos}
        }
        false,
        "checks": ["City_in_The_Sky_Aeralfos_Chest
        } 
        
        false,
        "City in the Sky"
    }
    { //66
        "palace_of_twilight_00_01",
        "neighbours": ["mirror_chamber, palace_of_twilight_02, palace_of_twilight_04, palace_of_twilight_07"],
         
            "true"
            "Requirement.palace_of_twilight_1_small_key, Requirement.can_defeat_zant_head, Requirement.Clawshot}
            "Requirement.can_defeat_phantom_zant, Requirement.Clawshot, Requirement.can_defeat_zant_head, Requirement.palace_of_twilight_2_small_keys}
            "Requirement.can_defeat_phantom_zant, Requirement.Clawshot, Requirement.can_defeat_zant_head, Requirement.Shadow_Crystal, Requirement.palace_of_twilight_4_small_keys, Requirement.Light_Sword}
        }
        false,
        "checks": ["Palace_of_Twilight_West_Wing_First_Room_Central_Chest,
            "Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness
        } 
        
        false,
        "Palace of Twilight"
    }
    { //67
        "palace_of_twilight_02",
        "neighbours": ["palace_of_twilight_00_01, phantom_zant_1"],
        
            "true"
            "Requirement.palace_of_twilight_2_small_keys, Requirement.can_defeat_zant_head, Requirement.Clawshot}
        }
        false,
        "checks": ["Palace_of_Twilight_West_Wing_Second_Room_Central_Chest,
            "Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest,
            "Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest
        } 
        
        false,
        "Palace of Twilight"
    }
    { //68
        "palace_of_twilight_04",
        "neighbours": ["palace_of_twilight_00_01, palace_of_twilight_05"],
        
            "true"
            "Requirement.palace_of_twilight_3_small_keys, Requirement.can_defeat_zant_head, Requirement.Clawshot}
        }
        false,
        "checks": ["Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest,
            "Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest,
            "Palace_of_Twilight_East_Wing_First_Room_East_Alcove,
            "Palace_of_Twilight_East_Wing_First_Room_West_Alcove
        } 
        
        false,
        "Palace of Twilight"
    }
    { //69
        "palace_of_twilight_05",
        "neighbours": ["palace_of_twilight_04, phantom_zant_2"],
        
            "true"
            "Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot}
        }
        false,
        "checks": ["Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest,
            "Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest,
            "Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest,
            "Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest
        }
        , 
        false,
        "Palace of Twilight"
    }
    { //70
        "palace_of_twilight_07",
        "neighbours": ["palace_of_twilight_00_01, palace_of_twilight_11"],
        
            "true"
            "Requirement.palace_of_twilight_5_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        }
        false,
        "checks": ["Palace_of_Twilight_Central_First_Room_Chest
        } 
        
        false,
        "Palace of Twilight"
    }
    { //71
        "palace_of_twilight_08",
        "neighbours": ["palace_of_twilight_11, palace_of_twilight_09"],
        
            "true"
            "Requirement.palace_of_twilight_7_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        }
        false,
        "checks": ["Palace_of_Twilight_Central_Tower_Chest
        } 
        
        false,
        "Palace of Twilight"
    }
    { //72
        "palace_of_twilight_09",
        "neighbours": ["palace_of_twilight_08, zant"],
        
            "true"
            "Requirement.Palace_of_Twilight_Big_Key, Requirement.can_defeat_shadow_beast}
        }
        false,
        "checks": "", 
        
        false,
        "Palace of Twilight"
    }
    { //73
        "palace_of_twilight_11",
        "neighbours": ["palace_of_twilight_07, palace_of_twilight_08"],
        
            "true"
            "Requirement.palace_of_twilight_6_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        }
        false,
        "checks": ["Palace_of_Twilight_Big_Key_Chest,
            "Palace_of_Twilight_Central_Outdoor_Chest
        } 
        
        false,
        "Palace of Twilight"
    }
    { //74
        "phantom_zant_1",
        "neighbours": ["palace_of_twilight_02"],
        
            "Requirement.can_defeat_phantom_zant}
        }
        false,
        "checks": "", 
        
        false,
        "Palace of Twilight"
    }
    { //75
        "phantom_zant_2",
        "neighbours": ["palace_of_twilight_05"],
        
            "Requirement.can_defeat_phantom_zant}
        }
        false,
        "checks": "", 
        
        false,
        "Palace of Twilight"
    }
    { //76
        "zant",
        "neighbours": ["palace_of_twilight_00_01"],
        
            "Requirement.can_defeat_zant}
        }
        false,
        "checks": ["Zant_Heart_Container
        } 
        
        false,
        "Palace of Twilight"
    }
    { //77
	    "hyrule_castle_01",
	    "neighbours": ["hyrule_castle_11, hyrule_castle_02"]
        
            "true"
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_lizalfos, Requirement.Double_Clawshot}
        }
	    false,
	    "checks": ["Hyrule_Castle_Main_Hall_Northeast_Chest,
            "Hyrule_Castle_Main_Hall_Southwest_Chest,
            "Hyrule_Castle_Main_Hall_Northwest_Chest
        } 
        
	    false,
	    "Hyrule Castle"
    }
    { //78
	    "hyrule_castle_02",
	    "neighbours": ["hyrule_castle_01, hyrule_castle_03, hyrule_castle_05"]
        
            "true"
            "Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang}
            "Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang}
        }
	    false,
	    "checks": ["Hyrule_Castle_Lantern_Staircase_Chest
        } 
        
	    false,
	    "Hyrule Castle"
    }
    { //79
	    "hyrule_castle_03",
	    "neighbours": ["hyrule_castle_02, hyrule_castle_04"]
        
            "true"
            "Requirement.can_knock_down_hc_painting, Requirement.can_defeat_lizalfos}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Hyrule Castle"
    }
    { //80
    	"hyrule_castle_04",
    	"neighbours": ["hyrule_castle_03, hyrule_castle_01, hyrule_castle_15"]
        
            "true"
            "Requirement.can_defeat_darknut}
            "Requirement.can_defeat_darknut}
        }
    	false,
    	new list<Check> 
        {} 
    	false,
    	"Hyrule Castle"
    }
    { //81
    	"hyrule_castle_05",
	    "neighbours": ["hyrule_castle_02, hyrule_castle_06"]
        
            "true"
            "Requirement.Lantern}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Hyrule Castle"
    }
    { //82
    	"hyrule_castle_06",
    	"neighbours": ["hyrule_castle_05, hyrule_castle_01, hyrule_castle_15"]
        
            "true"
            "Requirement.can_defeat_dinalfos}
            "Requirement.can_defeat_dinalfos}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Hyrule Castle"
    }
    { //83
    	"hyrule_castle_08",
    	"neighbours": ["hyrule_castle_12"]
        
            "true"
        }
    	false,
    	"checks": ["Hyrule_Castle_Treasure_Room_Eighth_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Seventh_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Sixth_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Fifth_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Fourth_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Third_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Second_Small_Chest,
            "Hyrule_Castle_Treasure_Room_First_Small_Chest,
            "Hyrule_Castle_Treasure_Room_Fifth_Chest,
            "Hyrule_Castle_Treasure_Room_Fourth_Chest,
            "Hyrule_Castle_Treasure_Room_Third_Chest,
            "Hyrule_Castle_Treasure_Room_Second_Chest,
            "Hyrule_Castle_Treasure_Room_First_Chest
        } 
        
    	false,
    	"Hyrule Castle"
    }
    { //84
    	"hyrule_castle_09",
    	"neighbours": ["hyrule_castle_14"]
        
            "Requirement.Shadow_Crystal}
        }
    	false,
    	"checks": ["Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest,
            "Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest,
            "Hyrule_Castle_Graveyard_Grave_Switch_Room_Rear_Left_Chest,
            "Hyrule_Castle_Graveyard_Owl_Statue_Chest
        } 
        
    	false,
    	"Hyrule Castle"
    }
    { //85
    	"hyrule_castle_11",
    	"neighbours": ["castle_town, hyrule_castle_01, hyrule_castle_13, hyrule_castle_14"]
        
            "true"
            "Requirement.hyrule_castle_1_small_key}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_kargarok}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_kargarok}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Hyrule Castle"
    }
    { //86
    	"hyrule_castle_12",
    	"neighbours": ["hyrule_castle_15, hyrule_castle_08, ganondorf_castle("]"]
        
            "true"
            "Requirement.hyrule_castle_3_small_keys, Requirement.Spinner, Requirement.Double_Clawshot, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos}
            "Requirement.Spinner, Requirement.Double_Clawshot, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Hyrule_Castle_Big_Key}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Hyrule Castle"
    }
    { //87
    	"hyrule_castle_13",
    	"neighbours": ["hyrule_castle_11"]
        
            "true"
        }
    	false,
    	"checks": ["Hyrule_Castle_West_Courtyard_North_Small_Chest,
            "Hyrule_Castle_West_Courtyard_Central_Small_Chest
        } 
        
    	false,
    	"Hyrule Castle"
    }
    { //88
    	"hyrule_castle_14",
	    "neighbours": ["hyrule_castle_11, hyrule_castle_09"]
        
            "true"
            "Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest,
            "Hyrule_Castle_East_Wing_Balcony_Chest
        } 
        
	    false,
	    "Hyrule Castle"
    }
    { //89
    	"hyrule_castle_15",
    	"neighbours": ["hyrule_castle_04, hyrule_castle_06, hyrule_castle_12"]
        
            "Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.can_knock_down_hc_painting}
            "Requirement.Lantern, Requirement.can_defeat_dinalfos}
            "Requirement.hyrule_castle_2_small_keys}
        }
    	false,
    	"checks": ["Hyrule_Castle_Southeast_Balcony_Tower_Chest,
            "Hyrule_Castle_Big_Key_Chest
        } 
        
    	false,
    	"Hyrule Castle"
    }
    { //90
    	"ganondorf_castle",
    	"neighbours": ["hyrule_castle_12"]
        
            "true"
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Ganondorf"
    }
    { //91
    	"arbiters_grounds_00",
    	"neighbours": ["outside_arbiters_grounds, arbiters_grounds_01"]
        
            "true"
            "Requirement.arbiters_grounds_1_small_key}
        }
    	false,
    	"checks": ["Arbiters_Grounds_Lobby_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //92
    	"arbiters_grounds_01",
    	"neighbours": ["arbiters_grounds_00, arbiters_grounds_02_06_15"]
        
            "true"
            "Requirement.Lantern}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //93
    	"arbiters_grounds_02_06_15",
    	"neighbours": ["arbiters_grounds_01, arbiters_grounds_07, arbiters_grounds_03, arbiters_grounds_04, arbiters_grounds_09"]
        
            "true"
            "Requirement.arbiters_grounds_4_small_keys, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat}
            "Requirement.Poe_Scent, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.can_defeat_redead_knight}
            "Requirement.arbiters_grounds_2_small_keys}
            "Requirement.can_defeat_poe, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.Poe_Scent, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalfos}
        }
    	false,
    	"checks": ["Arbiters_Grounds_East_Lower_Turnable_Redead_Chest,
            "Arbiters_Grounds_Torch_Room_East_Chest,
            "Arbiters_Grounds_Torch_Room_West_Chest,
            "Arbiters_Grounds_West_Small_Chest_Behind_Block,
            "Arbiters_Grounds_West_Chandelier_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //94
    	"arbiters_grounds_03",
    	"neighbours": ["arbiters_grounds_02_06_15"]
        
            "true"
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //95
    	"arbiters_grounds_04",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_05"]
        
            "true"
            "Requirement.can_defeat_bubble, Requirement.arbiters_grounds_3_small_keys}
        }
    	false,
    	"checks": ["Arbiters_Grounds_East_Upper_Turnable_Chest,
            "Arbtiers_Grounds_East_Upper_Turnable_Redead_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //96
    	"arbiters_grounds_05",
    	"neighbours": ["arbiters_grounds_04, arbiters_grounds_14"]
        
            "true"
            "Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //97
    	"arbiters_grounds_07",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_12"]
        
            "true"
            "Requirement.can_defeat_stalfos}
        }
    	false,
    	"checks": ["Arbiters_Grounds_West_Stalfos_North_Chest,
            "Arbiters_Grounds_West_Stalfos_Southeast_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //98
    	"arbiters_grounds_08",
    	"neighbours": ["arbiters_grounds_12, arbiters_grounds_07"]
        
            "Requirement.can_defeat_poe}
            "Requirement.can_defeat_poe}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //99
    	"arbiters_grounds_09",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_16, stallord"]
        
            "true"
            "Requirement.Spinner, Requirement.Clawshot}
            "Requirement.Spinner, Requirement.Arbiters_Grounds_Big_Key}
        }
    	false,
    	"checks": ["Arbiters_Grounds_Big_Key_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //100
    	"arbiters_grounds_10",
    	"neighbours": ["arbiters_grounds_16, arbiters_grounds_11"]
        
            "true"
            "Requirement.can_defeat_poison_mite}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //101
    	"arbiters_grounds_11",
    	"neighbours": ["arbiters_grounds_10, death_sword, can_access_arbiters_grounds_13"]
        
            "true"
            "Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite}
            "Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite, Requirement.Spinner}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //102
    	"arbiters_grounds_12",
    	"neighbours": ["arbiters_grounds_07, arbiters_grounds_08"]
        
            "true"
            "Requirement.Lantern}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //103
    	"arbiters_grounds_13",
    	"neighbours": ["arbiters_grounds_11, arbiters_grounds_09"]
        
            "true"
            "Requirement.Spinner}
        }
	    false,
	    "checks": ["Arbiters_Grounds_Spinner_Room_First_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Second_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest,
            "Arbiters_Grounds_Spinner_Room_Lower North_Chest
        } 
        
	    false,
	    "Arbiter's Grounds"
    }
    { //104
    	"arbiters_grounds_14",
    	"neighbours": ["arbiters_grounds_05, arbiters_grounds_02"]
        
            "true"
            "Requirement.can_defeat_ghoul_rat, Requirement.arbiters_grounds_4_small_keys}
        }
    	false,
    	"checks": ["Arbiters_Grounds_Ghoul_Rat_Room_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //105
    	"arbiters_grounds_16",
    	"neighbours": ["arbiters_grounds_09, arbiters_grounds_10"]
        
            "true"
            "Requirement.can_defeat_bubble, Requirement.arbiters_grounds_5_small_keys}
        }
    	false,
    	"checks": ["Arbiters_Grounds_North_Turning_Room_Chest
        } 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //106
    	"stallord",
    	"neighbours": ["mirror_chamber"]
        
            "Requirement.Can_Defeat_Stallord}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Arbiter's Grounds"
    }
    { //107
    	"death_sword",
	    "neighbours": ["arbiters_grounds_11"]
        
            "Requirement.Can_Defeat_Death_Sword}
        }
	    false,
	    "checks": ["Death_Sword_Chest
        } 
        
	    false,
	    "Arbiter's Grounds"
    }
    { //108
    	"snowpeak_ruins_00_01_02_03",
    	"neighbours": ["snowpeak_summit, snowpeak_ruins_07, snowpeak_ruins_04_W, snowpeak_ruins_04_E"]
        
            "true"
            "Requirement.Ordon_Goat_Cheese}
            "Requirement.Ordon_Pumpkin}
            "Requirement.crystal_or_ball_and_chain}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Lobby_Chandelier_Chest,
            "Snowpeak_Ruins_Lobby_West_Armor_Chest,
            "Snowpeak_Ruins_lobby_East_Armor_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //109
    	"snowpeak_ruins_04_E",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_W, snowpeak_ruins_13"]
        
            "crystal_or_ball_and_chain}
            "Requirement.Ball_and_Chain}
            "Requirement.snowpeak_ruins_4_small_keys}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_East_Courtyard_Burried_Chest,
            "Snowpeak_Ruins_East_Courtyard_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //110
    	"snowpeak_ruins_04_W",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E, snowpeak_ruins_09, snowpeak_ruins_11, darkhammer, blizzeta"]
        
            "true"
            "Requirement.Ball_and_Chain}
            "true"
            "Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs}
            "Requirement.can_access_darkhammer}
            "Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs, Requirement.Snowpeak_Ruins_Bedroom_Key}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_West_Courtyard_Buried_Chest,
            "Snowpeak_Ruins_Courtyard_Central_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //111
    	"snowpeak_ruins_05_lower",
    	"neighbours": ["snowpeak_ruins_13, snowpeak_ruins_00_01_02_03"]
        
            "true"
            "Requirement.can_defeat_chilfos}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Ordon_Pumpkin_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //112
    	"snowpeak_ruins_05_upper",
    	"neighbours": ["snowpeak_ruins_05_lower, snowpeak_ruins_00_01_02_03"]
        
            "true"
            "Requirement.Ball_and_Chain}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Northeast_Chandelier_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //113
    	"snowpeak_ruins_06",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E, snowpeak_ruins_05_upper, snowpeak_ruins_07
        
            "true"
            "Requirement.crystal_or_ball_and_chain}
            "Requirement.Ball_and_Chain, Requirement.Clawshot, Requirement.can_defeat_chilfos}
            "Requirement.snowpeak_ruins_4_small_keys}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //114
    	"snowpeak_ruins_07",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_06, snowpeak_ruins_08"]
        
            "true"
            "Requirement.Ball_and_Chain, Requirement.snowpeak_ruins_4_small_keys}
            "Requirement.Ball_and_Chain}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Broken_Floor_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //115
    	"snowpeak_ruins_08",
    	"neighbours": ["snowpeak_ruins_09"]
        
            "true"
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Wooden_Beam_Central_Chest,
            "Snowpeak_Ruins_Wooden_Beam_Northwest_Chest,
            "Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //116
    	"snowpeak_ruins_09",
    	"neighbours": ["snowpeak_ruins_04_W, snowpeak_ruins_08"]
        
            "true"
            "Requirement.can_smash}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_West_Cannon_Room_Central_Chest,
            "Snowpeak_Ruins_West_Cannon_Room_Corner_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //117
    	"snowpeak_ruins_11",
    	"neighbours": ["snowpeak_ruins_04_W"]
        
            "Requirement.can_defeat_chilfos}
        }
    	false,
    	"checks": ["Snowpeak_Ruins_Chapel_Chest
        } 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //118
    	"snowpeak_ruins_13",
    	"neighbours": ["snowpeak_ruins_04_E, snowpeak_ruins_05_lower"]
        
            "true"
            "Requirement.can_defeat_mini_freezard}
        }
    	false,
    	"checks": "", 
        
	    false,
	    "Snowpeak Ruins"
    }
    { //119
    	"blizzeta",
    	"neighbours": ["snowpeak_summit"]
        
            "Requirement.Can_Defeat_Blizzeta}
        }
    	false,
    	"checks": "", 
        
    	false,
    	"Snowpeak Ruins"
    }
    { //120
	    "darkhammer",
	    "neighbours": ["snowpeak_ruins_04_W"]
        
            "Requirement.Can_Defeat_Darkhammer}
        }
	    false,
	    "checks": ["Snowpeak_Ruins_Chest_After_Darkhammer
        } 
        
	    false,
	    "Snowpeak Ruins"
    }
    { //121
	    "lanayru_ice_puzzle_cave",
	    "neighbours": ["lanayru_field"]
        
            "true"
        }
	    false,
	    "checks": ["Lanayru_Ice_Puzzle_Cave_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //122
	    "cave_of_ordeals_01_11",
	    "neighbours": ["gerudo_desert, cave_of_ordeals_12_21"]
        
            "Clawshot}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_skulltula, Requirement.can_defeat_bublin, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_tetike, Requirement.can_defeat_lizalfos.}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Cave of Ordeals"
    }
    { //123
	    "cave_of_ordeals_12_21",
	    "neighbours": ["ordon spring, cave_of_ordeals_22_31"]
        
            "Clawshot}
            "Requirement.can_defeat_helmasaur, Requirement.can_defeat_rat, Requirement.Spinner, Requirement.can_defeat_chu, Requirement.can_defeat_chu_worm, Requirement.can_defeat_bubble, Requirement.can_defeat_bublin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_stalhound, Requirement.can_defeat_poe, Requirement.can_defeat_leever}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Cave of Ordeals"
    }
    { //124
	    "cave_of_ordeals_22_31",
	    "neighbours": ["faron spring, cave_of_ordeals_32_41"]
        
            "Clawshot}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_ice_keese, Requirement.Ball_And_Chain, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalchild, Requirement.can_defeat_redead_knight, REquirement.can_defeat_bublin, Requirement.can_defeat_stalfos, Requirement.can_defeat_skulltula, Requirement.can_defeat_bubble, Requirement.can_defeat_lizalfos, Requirement.can_defeat_fire_bubble}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Cave of Ordeals"
    }
    { //125
	    "cave_of_ordeals_32_41",
	    "neighbours": ["eldin spring, cave_of_ordeals_42_50"]
        
            "Clawshot}
            "Requirement.can_defeat_beamos, Requirement.can_defeat_keese, Requirement.Powered_Dominion_Rod, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_fire_bubble, Requirement.can_defeat_redead_knight, Requirement.can_defeat_poe, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_chu, Requirement.can_defeat_ice_keese, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ice_bubble, Requirement.can_defeat_leever, Requirement.can_defeat_darknut}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Cave of Ordeals"
    }
    { //126
	    "cave_of_ordeals_42_50",
	    "neighbours": ["lanayru spring"]
        
            "Requirement.can_defeat_armos, Requirement.Double_Clawshot, Requirement.can_defeat_bokoblin, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_lizalfos, Requirement.can_defeat_bublin, Requirement.can_defeat_dinalfos, Requirement.can_defeat_poe, Requirement.can_defeat_redead_knight, Requirement.can_defeat_chu, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_rat, Requirement.can_defat_stalchild, Requirement.can_defeat_aeralfos, Requirement.can_defeat_darknut}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Cave of Ordeals"
    }
    { //127
	    "eldin_long_cave",
	    "neighbours": ["kakariko_gorge"]
        
            "true"
        }
	    false,
	    "checks": ["Eldin_Lantern_Cave_First_Chest,
            "Eldin_Lantern_Cave_Lantern_Chest,
            "Eldin_Lantern_Cave_Second_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //128
	    "lake_hylia_long_cave",
	    "neighbours": ["lake_hylia"]
        
            "true"
        }
	    false,
	    "checks": ["Lake_Lantern_Cave_First_Chest,
            "Lake_Lantern_Cave_Second_Chest,
            "Lake_Lantern_Cave_Third_Chest,
            "Lake_Lantern_Cave_Fourth_Chest,
            "Lake_Lantern_Cave_Fifth_Chest,
            "Lake_Lantern_Cave_Sixth_Chest,
            "Lake_Lantern_Cave_Seventh_Chest,
            "Lake_Lantern_Cave_Eighth_Chest,
            "Lake_Lantern_Cave_Ninth_Chest,
            "Lake_Lantern_Cave_Tenth_Chest,
            "Lake_Lantern_Cave_Eleventh_Chest,
            "Lake_Lantern_Cave_Twelfth_Chest,
            "Lake_Lantern_Cave_Thirteenth_Chest,
            "Lake_Lantern_Cave_Fourteenth_Chest,
            "Lake_Lantern_Cave_End_Lantern_Chest

        } 
        
	    false,
	    "Lanayru Province"
    }
    { //129
	    "goron_stockcave",
	    "neighbours": ["eldin_field"]
        
            "true"
        }
	    false,
	    "checks": ["Eldin_Stockcave_Upper_Chest,
            "Eldin_Stockcave_Lantern_Chest,
            "Eldin_Stockcave_Lowest_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //130
	    "grotto_1_0",
	    "neighbours": ["outside_castle_town_west"]
        
            "true"
        }
	    false,
	    "checks": ["West_Hyrule_Field_Helmasaur_Grotto_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //131
	    "grotto_1_1",
	    "neighbours": ["eldin_field"]
        
            "true"
        }
	    false,
	    "checks": ["Eldin_Field_Bomskit_Grotto_Left_Chest,
            "Eldin_Field_Bomskit_Grotto_Lantern_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //132
	    "grotto_1_2",
	    "neighbours": ["ordon_province"]
        
            "true"
        }
	    false,
	    "checks": ["Ordon_Ranch_Grotto_Lantern_Chest
        } 
        
	    false,
	    "Ordonia Province"
    }
    { //133
	    "grotto_1_3",
	    "neighbours": ["lanayru_field"]
        
            "true"
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Hyrule Field"
    }
    { //134
	    "grotto_2_0",
	    "neighbours": ["lanayru_field"]
        
            "true"
        }
	    false,
	    "checks": ["Lanayru_Field_Stalfos_Grotto_Right_Small_Chest,
            "Lanayru_Field_Stalfos_Grotto_Left_Small_Chest,
            "Lanayru_Field_Stalfos_Grotto_Stalfos_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //135
	    "grotto_2_1",
	    "neighbours": ["faron_field"]
        
            "true"
        }
	    false,
	    "checks": ["Faron_Field_Corner_Grotto_Right_Chest,
            "Faron_Field_Corner_Grotto_Left_Chest,
            "Faron_Field_Corner_Grotto_Rear_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //136
	    "grotto_2_2",
	    "neighbours": ["sacred_grove_master_sword"]
        
            "true"
        }
	    false,
	    "checks": ["Sacred_Grove_Deku_Baba_Grotto_Chest
        } 
        
	    false,
	    "Sacred Grove"
    }
    { //137
	    "grotto_3_0",
	    "neighbours": ["gerudo_desert"]
        
            "true"
        }
	    false,
	    "checks": ["Gerudo_Desert_Poe_Grotto_Lantern_Chest
        } 
        
	    false,
	    "Gerudo Desert"
    }
    { //138
	    "grotto_4_0",
	    "neighbours": ["lake_hylia_bridge"]
        
            "true"
        }
	    false,
	    "checks": ["Lake_Hylia_Bridge_Bubble_Grotto_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //139
	    "grotto_4_1",
	    "neighbours": ["gerudo_desert"]
        
            "true"
        }
	    false,
	    "checks": ["Gerudo_Desert_Skulltula_Grotto_Chest
        } 
        
	    false,
	    "Gerudo Desert"
    }
    { //140
	    "grotto_4_2",
	    "neighbours": ["can_access_snowpeak_climb"]
        
            "true"
        }
	    false,
	    "checks": ["Snowpeak_Freezard_Grotto_Chest
        } 
        
	    false,
	    "Snowpeak Province"
    }
    { //141
	    "grotto_4_3",
	    "neighbours": ["lanayru_field"]
        
            "true"
        }
	    false,
	    "checks": ["Lanayru_Field_Skulltula_Grotto_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //142
	    "grotto_5_0",
	    "neighbours": ["outside_castle_town_south"]
        
            "true"
        }
	    false,
	    "checks": ["Outside_South_Castle_Town_Tetike_Grotto_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //143
	    "grotto_5_2",
	    "neighbours": ["lake_hylia"]
        
            "true"
        }
	    false,
	    "checks": ["Lake_Hylia_Water_Toadpoli_Grotto_Chest
        } 
        
	    false,
	    "Lanayru Province"
    }
    { //144
	    "grotto_5_3",
	    "neighbours": ["eldin_field"]
        
            "true"
        }
	    false,
	    "checks": ["Eldin_Field_Bomb_Fish_Grotto_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //145
	    "grotto_5_4",
	    "neighbours": ["lake_hylia"]
        
            "true"
        }
	    false,
	    "checks": ["Lake_Hylia_Shell_Blade_Grotto_Chest
        } 
        
	    false,
	    "Lanayru Province"
    }
    { //146
	    "south_faron_woods_cave",
	    "neighbours": ["south_faron_woods, faron_mist_area"]
        
            "true"
            "Requirement.Lantern}
        }
	    false,
	    "checks": ["South_Faron_Cave_Chest
        }
	    false,
	    "Faron Woods"
    }
    { //147
	    "ordon_province",
	    "neighbours": ["south_faron_woods"]
        
            "Requirement.Wooden_Sword}
        }
	    false,
	    "checks": ["Gift_From_Rusl,
            "Links_Basement_Chest,
            "Wrestling_With_Bo
        }
	    false,
	    "Ordonia Province"
    }
    { //148
	    "south_faron_woods",
	    "neighbours": ["ordon_province, faron_field, south_faron_woods_cave, faron_mist_area"]
        
            "true"
            "Requirement.diababa_defeated}
            "Requirement.Coro_Key}
            "Requirement.can_smash, Requirement.Powered_Dominion_Rod, Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Faron Woods"
    }
    { //149
	    "faron_mist_area",
	    "neighbours": ["south_faron_woods_cave, faron_mist_cave, north_faron_woods"]
        
            "true"
            "Requirement.Lantern}
            "Requirement.Small_Key_N_Faron_Gate}
        }
	    false,
	    "checks": ["Faron_Mist_Stump_Chest,
            "Faron_Mist_North_Chest,
            "Faron_Mist_South_Chest,
            "Faron_Woods_Owl_Statue_Chest

        } 
        
	    false,
	    "Faron Woods"
    }
    { //150
	    "faron_mist_cave",
	    "neighbours": ["faron_mist_area"]
        
            "true"
        }
	    false,
	    "checks": ["Faron_Mist_Cave_Open_Chest,
            "Faron_Mist_Cave_Lantern_Chest
        }
	    false,
	    "Faron Woods"
    }
    { //151
	    "north_faron_woods",
	    "neighbours": ["faron_mist_area, forest_temple_22, lost_woods"]
        
            "true"
            "Requirement.Lantern}
            "Requirement.fused_shadow_count_3, Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["North_Faron_Woods_Deku_Baba_Chest
        }
	    false,
	    "Faron Woods"
    }
    { //152
	    "kakariko_village",
	    "neighbours": ["kakariko_gorge, eldin_field, death_mountain_trail, lake_hylia"]
        
            "true"
            "Requirement.Eldin_Vessel_of_Light}
            "true"
            "Requirement.Water_Bombs, Requirement.Iron_Boots}
        }
	    false,
	    "checks": ["Kakariko_Inn_Chest,
            "Eldin_Spring_Underwater_Chest,
            "Kakariko_Graveyard_Lantern_Chest,
            "Kakariko_Watchtower_Chest,
            "Kakariko_Watchtower_Alcove_Chest,
            "Kakariko_Bomb_Rock_Spire_Heart_Piece
        } 
        
	    false,
	    "Eldin Province"
    }
    { //153
	    "death_mountain_trail",
	    "neighbours": ["kakariko_village, death_mountain_volcano"]
        
            "true"
            "Requirement.Iron_Boots}
        }
	    false,
	    "checks": ["Death_Mountain_Alcove_Chest
        } 
        
	    false,
	    "Eldin Province"
    }
    { //154
	    "death_mountain_volcano",
	    "neighbours": ["death_mountain_trail, death_mountain_interiors"]
        
            "true"
            "Requirement.Iron_Boots, Requirement.can_defeat_goron}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Eldin Province"
    }
    { //155
	    "zoras_domain",
	    "neighbours": ["lanayru_field, snowpeak_climb"]
        
            "true"
            "Requirement.Lanayru_Vessel_of_Light}
        }
	    false,
	    "checks": ["Zoras_Domain_Chest_By_Mother_and_Child_Isles,
            "Zoras_Domain_Chest_Behind_Waterfall,
            "Zoras_Domain_Light_All_Torches_Chest,
            "Zoras_Domain_Extinguish_All_Torches_Chest,
            "Fishing_Hole_Heart_Piece
        } 
        
	    false,
	    "Lanayru Province"
    }
    { //156
	    "snowpeak_climb",
	    "neighbours": ["zoras_domain, snowpeak_summit, grotto_4_2"]
        
            "true"
            "Requirement.Reekfish_Scent, Requirement.Shadow_Crystal}
			"Requirement.Reekfish_Scent, Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Snowpeak Province"
    }
    { //157
	    "snowpeak_summit",
	    "neighbours": ["snowpeak_climb, snowpeak_ruins_00"]
        
            "Requirement.Shadow_Crystal}
            "Requirement.can_defeat_shadow_beast}
        }
	    false,
	    "checks": ["Snowpeak_Cave_Ice_Lantern_Chest
        } 
        
	    false,
	    "Snowpeak Province"
    }
    { //158
	    "lake_hylia",
	    "neighbours": ["gerudo_desert, lake_hylia_long_cave, grotto_5_2, grotto_5_4, lakebed_temple_00, city_in_the_sky_00, lake_hylia_bridge, zoras_domain"]
        
            "Requirement.Aurus_Memo, Requirement.Lanayru_Vessel_of_Light}
            "Requirement.Lanayru_Vessel_of_Light, Requirement.can_smash}
            "Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal}
            "Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal}
            "Requirement.Iron_Boots, Requirement.Water_Bombs, Requirement.Zora_Armor}
            "Requirement.Lanayru_Vessel_of_Light, Requirement.Clawshot, Requirement.Ancient_Sky_Book_Completed}
            "Requirement.Lanayru_Vessel_of_Light}
            "Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Lake_Hylia_Underwater_Chest,
            "Outside_Lanayru_Spring_Left_Statue_Chest,
            "Outside_Lanayru_Spring_Right_Statue_Chest,
            "Lanayru_Spring_Underwater_Left_Chest,
            "Lanayru_Spring_Underwater_Right_Chest,
            "Lanayru_Spring_Back_Room_Left_Chest,
            "Lanayru_Spring_Back_Room_Right_Chest,
            "Lanayru_Spring_Back_Room_Lantern_Chest,
            "Flight_By_Fowl_Top_Platform,
            "Flight_By_Fowl_Second_Platform,
            "Flight_By_Fowl_Third_Platform,
            "Flight_By_Fowl_Fourth_Platform,
            "Flight_By_Fowl_Fifth_Platform,
            "Lanayru_Spring_East_Double_Clawshot_Chest,
            "Lanayru_Spring_West_Double_Clawshot_Chest
        } 
        
	    false,
	    "Lanayru Province"
    }
    { //159
	    "castle_town",
	    "neighbours": ["outside_castle_town_west, eldin_field, outside_castle_town_south, hyrule_castle_11"]
        
            "true"
            "true"
            "true"
            "Requirement.zant_defeated, Requirement.mdh_complete}
        }
	    false,
	    "checks": ["Doctors_Office_Balcony_Chest
        } 
        
	    false,
	    "Castle Town"
    }
    { //160
	    "lost_woods",
	    "neighbours": ["north_faron_woods, sacred_grove_master_sword"]
        
            "true"
            "Requirement.can_defeat_skull_kid_2}
        }
	    false,
	    "checks": ["Lost_Woods_Lantern_Chest
        } 
        
	    false,
	    "Sacred Grove"
    }
    { //161
	    "sacred_grove_master_sword",
	    "neighbours": ["lost_woods, sacred_grove_temple_of_time, grotto_2_2"]
        
            "true"
            "Requirement.can_defeat_shadow_beast, Requirement.Master_Sword}
            "Requirement.can_smash && Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Sacred_Grove_Spinner_Chest
        } 
        
	    false,
	    "Sacred Grove"
    }
    { //162
	    "sacred_grove_temple_of_time",
	    "neighbours": ["sacred_grove_master_sword, temple_of_time_00"]
        
            "true"
            "Requirement.Master_Sword}
        }
	    false,
	    "checks": ["Sacred_Grove_Past_Owl_Statue
        } 
        
	    false,
	    "Sacred Grove"
    }
    { //163
	    "bublin_camp",
	    "neighbours": ["gerudo_desert, outside_arbiters_grounds"]
        
            "true"
            "Requirement.can_defeat_king_bublin_3}
        }
	    false,
	    "checks": ["Bublin_Camp_First_Chest_Under_Tower_at_Entrance,
            "Bublin_Camp_Small_Chest_in_Back_of_Camp
        } 
        
	    false,
	    "Gerudo Desert"
    }
    { //164
	    "outside_arbiters_grounds",
	    "neighbours": ["bublin_camp, arbiters_grounds_00"]
        
            "true"
            "true"
        }
	    false,
	    "checks": ["Outside_Arbiters_Grounds_Lantern_Chest
        } 
        
	    false,
	    "Gerudo Desert"
    }
    { //165
	    "eldin_field",
	    "neighbours": ["kakariko_gorge, kakariko_village, goron_stockcave, castle_town, lanayru_field, grotto_5_3, grotto_1_1"]
        
            "Requirement.can_smash}
            "true"
            "Requirement.Clawshot}
            "Requirement.Lanayru_Vessel_of_Light}
            "Requirement.can_smash}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Eldin_Field_Bomb_Rock_Chest,
            "Bridge_of_Eldin_Owl_Statue_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //166
	    "kakariko_gorge",
	    "neighbours": ["eldin_field, faron_field, kakariko_village, eldin_long_cave"]
        
            "Requirement.can_smash}
            "true"
            "true"
            "Requirement.can_smash}
        }
	    false,
	    "checks": ["Kakariko_Gorge_Owl_Statue_Chest,
            "Kakariko_Gorge_Double_Clawshot_Chest,
            "Kakariko_Gorge_Spire_Heart_Piece
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //167
	    "faron_field",
	    "neighbours": ["south_faron_woods, outside_castle_town_south, kakariko_gorge, lake_hylia_bridge, grotto_2_1"]
        
            "true"
            "Requirement.Lanayru_Vessel_of_Light}
            "true"
            "Requirement.Gate_Keys}
            "Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Faron_Field_Bridge_Chest,
            "Faron_Field_Tree_Heart_Piece
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //168
	    "lanayru_field",
	    "neighbours": ["eldin_field, zoras_domain, outside_castle_town_west, lanayru_ice_puzzle_cave, lake_hylia_bridge, hidden_village, grotto_2_0, grotto_4_3, grotto_1_3"]
        
            "Requirement.can_smash}
            "Requirement.can_smash}
            "true"
            "Requirement.can_smash}
            "Requirement.can_smash}
            "Requirement.Wooden_Statue}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Lanayru_Field_Behind_Gate_Underwater_Chest,
            "Lanayru_Field_Spinner_Track_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //169
	    "lake_hylia_bridge",
	    "neighbours": ["faron_field, lake_hylia, lanayru_field, outside_castle_town_west, grotto_4_0"]
        
            "Requirement.Gate_Keys}
            "true"
            "Requriement.can_smash}
            "true"
            "Requirement.Shadow_Crystal, Requirement.can_launch_bombs, Requirement.Clawshot}
        }
	    false,
	    "checks": ["Lake_Hylia_Bridge_Vines_Chest,
            "Lake_Hylia_Bridge_Cliff_Chest,
            "Lake_Hylia_Bridge_Owl_Statue_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //170
	    "outside_castle_town_west",
	    "neighbours": ["lake_hylia_bridge, lanayru_field, castle_town, grotto_1_0"]
        
            "true"
            "true"
            "true"
            "Requirement.Shadow_Crystal, Requirement.Clawshot}
        }
	    false,
	    "checks": ["Hyrule_Field_Ampitheater_Owl_Statue_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //171
	    "outside_castle_town_south",
	    "neighbours": ["castle_town, faron_field, grotto_5_0, lake hylia"]
        
            "true"
            "Requirement.Lanayru_Vessel_of_Light}
            "Requirement.Shadow_Crystal}
            "true"
        }
	    false,
	    "checks": ["South_Castle_Field_Tightrope_Chest,
            "Outside_Castle_Town_Fountain_Chest,
            "South_of_Castle_Town_Double_Clawshot_Chasm_Chest
        } 
        
	    false,
	    "Hyrule Field"
    }
    { //172
	    "gerudo_desert",
	    "neighbours": ["cave_of_ordeals, bublin_camp, grotto_3_0, grotto_4_1"]
        
            "Requirement.can_defeat_shadow_beast, Requirement.Clawshot}
            "Requirement.can_defeat_bublin}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        }
	    false,
	    "checks": ["Gerudo_Desert_Peahat_Ledge_Chest,
            "Gerudo_Desert_East_Canyon_Chest,
            "Gerudo_Desert_Lone_Small_Chest,
            "Gerudo_Desert_West_Canyon_Chest,
            "Gerudo_Desert_Northeast_Chest_Behind_Gates,
            "Gerudo_Desert_South_Chest_Behind_Wooden_Gates,
            "Gerudo_Desert_Campfire_North_Chest,
            "Gerudo_Desert_Campfire_East_Chest,
            "Gerudo_Desert_Campfire_West_Chest,
            "Gerudo_Desert_Northwest_Chest_Behind_Gates,
            "Gerudo_Desert_North_Small_Chest_Before_Bublin_Camp,
            "Gerudo_Desert_Owl_Statue_Chest
        } 
        
	    false,
	    "Gerudo Desert"
    }
    { //173
	    "mirror_chamber",
	    "neighbours": ["stallord, palace_of_twilight_00"]
        
            "true"
            "Requirement.mirror_shard_count_4, Requirement.can_defeat_shadow_beast}
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Gerudo Desert"
    }
    { //174
	    "hidden_village",
	    "neighbours": ["lanayru_field"]
        
            "true"
        }
	    false,
	    "checks": ["Cats_Hide_and_Seek_Minigame
        } 
        
	    false,
	    "Hidden Village"
    }
    { //175
	    "death_mountain_interiors",
	    "neighbours": ["death_mountain_volcano, goron_mines_01"]
        
            "true"
            "true"
        }
	    false,
	    "checks": "", 
        
	    false,
	    "Eldin Province"
    }
} 
