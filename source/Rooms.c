#include "Checks.h"

struct Room
{
    string name; //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
    list<*Room> neighbours; //Refers to the rooms of the same stage that can be accesed from this room
    list<list<Requirement>> neighbourRequirments; //List of list of requirements to enter each neighbouring room
    bool isStartingRoom; //Defines if it is the stage you start the game in
    list<*Check> checks; //Checks contained inside the room
    bool visited;
    string region;
}


Room Rooms []
{
    { //0
        "lakebed_temple_00_01",
        new list<*Room> {},
        new list<list<Requirement>> 
        {
            new list<Requirement> {}, 
            new list<Requirement>{Requirement.can_launch_bombs},
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Lobby_Left_Chest, 
            checks.Lakebed_Temple_Lobby_Rear_Chest,
            checks.Lakebed_Temple_Stalactite_Room_Chest
        },
        
        false,
        "Lakebed Temple"
    },
    { //1
        "lakebed_temple_02_03",
        new list<*Room> {}, //(lakebed_temple_00_01, lakebed_temple_07, lakebed_temple_08, lakebed_temple_12, morpheel)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}, 
            new list<Requirement> {Requirement.lakebed_temple_1_small_key}, 
            new list<Requirement> {}, 
            new list<Requirement> {Requirement.lakebed_temple_3_small_keys, Requirement.can_launch_bombs},
            new list<Requirement> {Requirement.lakebed_temple_3_small_keys, Requirement.can_launch_bombs, Requirement.Clawshot, Requirement.Lakebed_Temple_Big_Key}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Central_Room_Small_Chest,
            checks.Lakebed_Temple_Central_Room_Chest,
            checks.Lakebed_Temple_Chandelier_Chest,
            checks.Lakebed_Temple_Center_Spire_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //2
        "lakebed_temple_05",
        new list<*Room> {}, //(lakebed_temple_12, lakebed_temple_06),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Zora_Armor, Requirement.Water_Bombs}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Underwater_Maze_Small_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //3
        "lakebed_temple_06",
        new list<*Room> {}, //(lakebed_temple_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Big_Key_Chest
        }, 
        
        false
    },
    { //4
        "lakebed_temple_07",
        new list<*Room> {}, //(lakebed_temple_02_03, lakebed_temple_10, lakebed_temple_08),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_lauch_bombs},
            new list<Requirement> {Requirement.can_lauch_bombs}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_East_Second_Floor_Southwest_Chest,
            checks.Lakebed_Temple_East_Second_Floor_Southeast_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //5
        "lakebed_temple_08",
        new list<*Room> {}, //(lakebed_temple_02_03, lakebed_temple_09),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.lakebed_temple_3_small_keys, Requirement.can_launch_bombs}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest,
            checks.Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //6
        "lakebed_temple_09",
        new list<*Room> {}, //(lakebed_temple_08, deku_toad),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.lakebed_temple_3_small_keys, Requirement.Zora_Armor, Requirement.Water_Bombs}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Before_Deku_Toad_Alcove_Chest,
            checks.Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest,
            checks.Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //7
        "lakebed_temple_10",
        new list<*Room> {}, //(lakebed_temple_07),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_East_Water_Supply_Small_Chest,
            checks.Lakebed_Temple_East_Water_Supply_Clawshot_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //8
        "lakebed_temple_11",
        new list<*Room> {}, //(lakebed_temple_02_03, lakebed_temple_12, lakebed_temple_13),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Clawshot, Requirement.can_lauch_bombs},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot, Requirement.can_lauch_bombs},
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest,
            checks.Lakebed_Temple_West_Second_Floor_Northeast_Chest,
            checks.Lakebed_Temple_West_Second_Floor_Southeast_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //9
        "lakebed_temple_12",
        new list<*Room> {}, //(lakebed_temple_11, lakebed_temple_02_03, lakebed_temple_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Clawshot},
            new list<Requirement> {},
			new list<Requirement> {Requirement.Clawshot},
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_West_Lower_Small_Chest,
            checks.Lakebed_Temple_West_Second_Floor_Central_Small_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //10
        "lakebed_temple_13",
        new list<*Room> {}, //(lakebed_temple_11),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_West_Water_Supply_Small_Chest,
            checks.Lakebed_Temple_West_Water_Supply_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //11
        "deku_toad",
        new list<*Room> {}, //(lakebed_temple_09),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Deku_Toad, Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.Lakebed_Temple_Deku_Toad_Chest
        }, 
        
        false,
        "Lakebed Temple"
    },
    { //12
        "morpheel",
        new list<*Room> {}, //(lake_hylia),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Morpheel}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Lakebed Temple"
    },
    { //13
        "goron_mines_01",
        new list<*Room> {}, //(death_mountain_interiors, goron_mines_03),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots},
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Entrance_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //14
        "goron_mines_03",
        new list<*Room> {}, //(goron_mines_01, goron_mines_04_05, goron_mines_06),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.goron_mines_1_small_key},
            new list<Requirement> {Requirement.goron_mines_1_small_key, Requirement.Iron_Boots},
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Main_Magnet_Room_Bottom_Chest,
            checks.Goron_Mines_Main_Magnet_Room_Top_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //15
        "goron_mines_04_05",
        new list<*Room> {}, //(goron_mines_03, goron_mines_14),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots},
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Magnet_Maze_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //16
        "goron_mines_06",
        new list<*Room> {}, //(goron_mines_03, goron_mines_07),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.has_sword_and_irons_or_bow, Requirement.goron_mines_2_small_keys},
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Crystal_Switch_Room_Underwater_Chest,
            checks.Goron_Mines_Crystal_Switch_Room_Small_Chest,
            checks.Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //17
        "goron_mines_07",
        new list<*Room> {}, //(goron_mines_06, goron_mines_09, goron_mines_12),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.goron_mines_3_small_keys},
            new list<Requirement> {Requirement.Bow, Requirement.Iron_Boots}
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Outside_Beamos_Chest,
            checks.Goron_Mines_Outside_Underwater_Chest,
            checks.Goron_Mines_Outside_Clawshot_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //18
        "goron_mines_09_17",
        new list<*Room> {}, //(goron_mines_07, dangoro),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots},
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Gor_Ebizo_Chest,
            checks.Goron_Mines_Chest_Before_Dangoro
        }, 
        
        false,
        "Goron Mines"
    },
    { //19
        "goron_mines_11",
        new list<*Room> {}, //(dangoro, goron_mines_13, goron_mines_16),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Bow},
            new list<Requirement> {Requirement.Bow}
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Dangoro_Chest,
            checks.Goron_Mines_Beamos_Room_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //20
        "goron_mines_12",
        new list<*Room> {}, //(goron_mines_07, fyrus),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Bow, Requirement.can_defeat_bublin, Requirement.Goron_Mines_Big_Key},
        },
        false,
        new list<Check> {}, 
        
        false,
        "Goron Mines"
    },
    { //21
        "goron_mines_13",
        new list<*Room> {}, //(goron_mines_11, goron_mines_03),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots, Requirement.Bow},
        },
        false,
        new list<Check> {}, 
        
        false,
        "Goron Mines"
    },
    { //22
        "goron_mines_14",
        new list<*Room> {}, //(goron_mines_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Gor_Amato_Chest,
            checks.Goron_Mines_Gor_Amato_Small_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //23
        "goron_mines_16",
        new list<*Room> {}, //(goron_mines_11),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Goron_Mines_Gor_Liggs_Chest
        }, 
        
        false,
        "Goron Mines"
    },
    { //24
        "fyrus",
        new list<*Room> {}, //(kakariko_village),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Fyrus}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Goron Mines"
    },
    { //25
        "dangoro",
        new list<*Room> {}, //(goron_mines_09, goron_mines_11),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Dangoro},
            new list<Requirement> {Requirement.Can_Defeat_Dangoro},
        },
        false,
        new list<Check> {}, 
        
        false,
        "Goron Mines"
    },

    //Forest Temple
    { //26
        "forest_temple_00_01",
        new list<*Room> {}, //(forest_temple_22, forest_temple_02, forest_temple_03, forest_temple_09, ook),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_bombling_or_burn_webs, Requirement.forest_temple_4_small_keys},
            new list<Requirement> {Requirement.can_burn_webs, Requirement.can_free_second_monkey_or_clawshot},
            new list<Requirement> {Requirement.can_defeat_bombling_or_burn_webs},
            new list<Requirement> {Requirement.can_burn_webs, Requirement.can_defeat_bombling, Requirement.can_defeat_walltula, Requirement.can_defeat_big_baba, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage, Requirement.forest_temple_4_small_keys},
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_Central_Chest_Behind_Stairs,
            checks.Forest_Temple_Central_North_Chest,
            checks.Forest_Temple_Central_Chest_Hanging_From_Web,
            checks.Forest_Temple_Big_Key_Chest,
            checks.Forest_Temple_East_Water_Cave_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //27
        "forest_temple_02",
        new list<*Room> {}, //(forest_temple_00_01),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_bokoblin}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_Second_Monkey_Under_Bridge_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //28
        "forest_temple_03",
        new list<*Room> {}, //(forest_temple_00_01, forest_temple_05, forest_temple_07, ook),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_bombling},
            new list<Requirement> {Requirement.can_defeat_bombling, Requirement.can_defeat_walltula},
            new list<Requirement> {Requirement.Boomerang}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_West_Deku_Like_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //29
        "forest_temple_05",
        new list<*Room> {}, //(forest_temple_03),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_Totem_Pole_Chest,
            checks.Forest_Temple_West_Tile_Worm_Room_Vines_Chest,
            checks.Forest_Temple_West_Tile_Worm_Room_Chest_Behind_Stairs
        }, 
        
        false,
        "Forest Temple"
    },
    { //30
        "forest_temple_07",
        new list<*Room> {}, //(forest_temple_03),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Forest Temple"
    },
    { //31
        "forest_temple_09",
        new list<*Room> {}, //(forest_temple_00_01, forest_temple_10, forest_temple_11, forest_temple_12),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Boomerang, Requirement.forest_temple_4_small_keys},
            new list<Requirement> {Requirement.Boomerang},
            new list<Requirement> {Requirement.Boomerang},
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_Windless_Bridge_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //32
        "forest_temple_10",
        new list<*Room> {}, //(forest_temple_09),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_North_Deku_Like_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //33
        "forest_temple_11",
        new list<*Room> {}, //(forest_temple_09),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_East_Tile_Worm_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //34
        "forest_temple_12",
        new list<*Room> {}, //(forest_temple_09, forest_temple_19, diababa),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Boomerang, Requirement.can_defeat_bokoblin, Requirement.can_defeat_walltula},
            new list<Requirement> {Requirement.can_burn_webs, Requirement.can_defeat_bombling, Requirement.can_defeat_big_baba, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage, Requirement.forest_temple_4_small_keys, Requirement.Boomerang, Requirement.can_defeat_skulltula, Requirement.can_defeat_walltula}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Forest Temple"
    },
    { //35
        "forest_temple_19",
        new list<*Room> {}, //(forest_temple_12),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Forest Temple"
    },
    { //36
        "forest_temple_22",
        new list<*Room> {}, //(north_faron_woods, forest_temple_00),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_walltula, Requirement.can_defeat_bokoblin, Requirement.can_break_monkey_cage}
        },
        false,
        new list<Check> 
        {
            checks.Forest_Temple_Entrance_Vines_Chest
        }, 
        
        false,
        "Forest Temple"
    },
    { //37
        "ook",
        new list<*Room> {}, //(forest_temple_03),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Ook, Requirement.Boomerang}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Forest Temple"
    },
    { //38
        "diababa",
        new list<*Room> {}, //(south_faron_woods),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Diababa}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Forest Temple"
    },
    { //39
        "temple_of_time_00",
        new list<*Room> {}, //(sacred_grove_temple_of_time, temple_of_time_01, temple_of_time_08),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.temple_of_time_1_small_key},
            new list<Requirement> {Requirement.Dominion_Rod, Requirement.Bow, Requirement.Spinner, Requirement.can_defeat_lizalfos, Requirement.can_defeat_dinalfos, Requirement.can_defeat_darknut, Requirement.temple_of_time_3_small_keys}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Lantern_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //40
        "temple_of_time_01",
        new list<*Room> {}, //(temple_of_time_00, temple_of_time_02),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.has_ranged_item, Requirement.can_defeat_young_gohma, Requirement.can_defeat_lizalfos}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_First_Staircase_Gohma_Gate_Chest
            checks.Temple_of_Time_First_Staircase_Window_Chest,
            checks.Temple_of_Time_First_Staircase_Armos_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //41
        "temple_of_time_02",
        new list<*Room> {}, //(temple_of_time_01, temple_of_time_03, temple_of_time_04),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Spinner},
            new list<Requirement> {Requirement.Spinner, Requirement.temple_of_time_2_small_keys}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Temple of Time"
    },
    { //42
        "temple_of_time_03",
        new list<*Room> {}, //(temple_of_time_02),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Statue_Throws_Room_East_Chest,
            checks.Temple_of_Time_Statue_Throws_Room_North_Chest,
            checks.Temple_of_Time_Statue_Throws_Room_Statue_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //43
        "temple_of_time_04",
        new list<*Room> {}, //(temple_of_time_02, temple_of_time_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Bow, Requirement.can_defeat_lizalfos, Requirement.can_defeat_dinalfos}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Moving_Wall_Beamos_Room_Chest,
            checks.Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //44
        "temple_of_time_05",
        new list<*Room> {}, //(temple_of_time_04, temple_of_time_06, temple_of_time_07),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot, Requirement.Spinner},
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Scales_Gohma_Chest,
            checks.Temple_of_Time_Scales_Upper_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //45
        "temple_of_time_06",
        new list<*Room> {}, //(temple_of_time_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Big_Key_Chest,
            checks.Temple_of_Time_Big_Key_Chest_Room_Upper_Chest
        }, 
        
        false,
        "Temple of Time"
    },
    { //46
        temple_of_time_07,
        new list<*Room> {}, //(temple_of_time_05, darknut),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_lizalfos, Requirement.can_defeat_baby_gohma, Requirement.can_defeat_young_gohma, Requirement.can_defeat_armos, Requirement.temple_of_time_3_small_keys}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Gilloutine_Chest,
            checks.Temple_of_Time_Chest_Before_Midboss
        }, 
        
        false,
        "Temple of Time"
    },
    { //47
        "temple_of_time_08",
        new list<*Room> {}, //(temple_of_time_00, armogohma),
        new list<list<Requirement>>
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Dominion_rod, Requirement.Temple_of_Time_Big_Key}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Temple of Time"
    },
    { //48
        "darknut",
        new list<*Room> {}, //(temple_of_time_07),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Darknut, Requirement.Dominion_Rod}
        },
        false,
        new list<Check> 
        {
            checks.Temple_of_Time_Darknut_Chest    
        }, 
        
        false,
        "Temple of Time"
    },
    { //49
        "armogohma",
        new list<*Room> {}, //(sacred_grove_temple_of_time),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Armogohma}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Temple of Time"
    },

    { //50
        "city_in_the_sky_00_16",
        new list<*Room> {}, //(lake_hylia, city_in_the_sky_01),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Clawshot},
            new list<Requirement> {Requirement.Clawshot_or_Bow}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_Underwater_West_Chest,
            checks.City_in_The_Sky_Underwater_East_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //51
        "city_in_the_sky_01",
        new list<*Room> {}, //(city_in_the_sky_00, city_in_the_sky_02_03_14),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //52
        "city_in_the_sky_02_03_14",
        new list<*Room> {}, //(city_in_the_sky_01, city_in_the_sky_04, city_in_the_sky_06, city_in_the_sky_15),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Spinner, Requirement.city_in_the_sky_1_small_key},
            new list<Requirement> {Requirement.Clawshot},
            new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_kargarok, Requirement.Shadow_Crystal, Requirement.Iron_Boots}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_Big_Key_Chest,
            checks.City_in_The_Sky_Chest_Below_Big_Key_Chest,
            checks.City_in_The_Sky_Chest_Behind_North_Fan
        }, 
        
        false,
        "City in the Sky"
    },
    { //53
        "city_in_the_sky_04",
        new list<*Room> {}, //(city_in_the_sky_02_03_14, city_in_the_sky_07_lower),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_East_First_Wing_Chest_After_Fans,
            checks.City_in_The_Sky_East_Wing_Lower_Level_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //54
        "city_in_the_sky_05",
        new list<*Room> {}, //(city_in_the_sky_04, city_in_the_sky_07_upper, aeralfos),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Double_Clawshot},
            new list<Requirement> {},
            new list<Requirement> {}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //55
        "city_in_the_sky_06",
        new list<*Room> {}, //(city_in_the_sky_02_03_14, city_in_the_sky_10),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Double_Clawshot}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //56
        "city_in_the_sky_07_lower",
        new list<*Room> {}, //(city_in_the_sky_04, city_in_the_sky_08),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_tile_worm}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_East_Tile_Worm_Small_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //57
        "city_in_the_sky_07_upper",
        new list<*Room> {}, //(city_in_the_sky_08, city_in_the_sky_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_East_Wing_After_Dinalfos_Alcove_Chest,
            checks.City_in_The_Sky_East_Wing_After_Dinalfos_Ledge_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //58
        "city_in_the_sky_08",
        new list<*Room> {}, //(city_in_the_sky_07_lower, city_in_the_sky_07_upper),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot, Requirement.can_defeat_dinalfos}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //59
        "city_in_the_sky_10",
        new list<*Room> {}, //(city_in_the_sky_06, city_in_the_sky_11),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Double_Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_West_Wing_First_Chest,
            checks.City_in_The_Sky_West_Wing_Baba_Balcony_Chest,
            checks.City_in_The_Sky_West_Wing_Narrow_Ledge_Chest,
            checks.City_in_The_Sky_West_Wing_Tile_Worm_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //60
        "city_in_the_sky_11",
        new list<*Room> {}, //(city_in_the_sky_10, city_in_the_sky_12),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_baba_serpent}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_Baba_Tower_Top_Small_Chest,
            checks.City_in_The_Sky_Baba_Tower_Narrow_Ledge_Chest,
            checks.City_in_The_Sky_Baba_Tower_Alcove_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //61
        "city_in_the_sky_12",
        new list<*Room> {}, //(city_in_the_sky_11, city_in_the_sky_13),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Double_Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_West_Garden_Corner_Chest,
            checks.City_in_The_Sky_West_Garden_Lone_Island_Chest,
            checks.City_in_The_Sky_West_Garden_Lower_Chest,
            checks.City_in_The_Sky_West_Garden_Ledge_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //62
        "city_in_the_sky_13",
        new list<*Room> {}, //(city_in_the_sky_12, city_in_the_sky_02),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Double_Clawshot},
            new list<Requirement> {}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_Central_Outside_Chest,
            checks.City_in_The_Sky_Central_Outside_Poe_Island_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //63
        "city_in_the_sky_15",
        new list<*Room> {}, //(city_in_the_sky_01_02_03_14, argorok),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_aeralfos, Requirement.City_in_The_Sky_Big_Key}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //64
        "argorok",
        new list<*Room> {}, //(city_in_the_sky_00_16),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Argorok}
        },
        false,
        new list<Check> {}, 
        
        false,
        "City in the Sky"
    },
    { //65
        "aeralfos",
        new list<*Room> {}, //(city_in_the_sky_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Double_Clawshot, Requirement.can_defeat_aeralfos}
        },
        false,
        new list<Check> 
        {
            checks.City_in_The_Sky_Aeralfos_Chest
        }, 
        
        false,
        "City in the Sky"
    },
    { //66
        "palace_of_twilight_00_01",
        new list<*Room> {}, //(mirror_chamber, palace_of_twilight_02, palace_of_twilight_04, palace_of_twilight_07),
         new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_1_small_key, Requirement.can_defeat_zant_head, Requirement.Clawshot},
            new list<Requirement> {Requirement.can_defeat_phantom_zant, Requirement.Clawshot, Requirement.can_defeat_zant_head, Requirement.palace_of_twilight_2_small_keys},
            new list<Requirement> {Requirement.can_defeat_phantom_zant, Requirement.Clawshot, Requirement.can_defeat_zant_head, Requirement.Shadow_Crystal, Requirement.palace_of_twilight_4_small_keys, Requirement.Light_Sword},
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_West_Wing_First_Room_Central_Chest,
            checks.Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //67
        "palace_of_twilight_02",
        new list<*Room> {}, //(palace_of_twilight_00_01, phantom_zant_1),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_2_small_keys, Requirement.can_defeat_zant_head, Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_West_Wing_Second_Room_Central_Chest,
            checks.Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest,
            checks.Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //68
        "palace_of_twilight_04",
        new list<*Room> {}, //(palace_of_twilight_00_01, palace_of_twilight_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_3_small_keys, Requirement.can_defeat_zant_head, Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest,
            checks.Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest,
            checks.Palace_of_Twilight_East_Wing_First_Room_East_Alcove,
            checks.Palace_of_Twilight_East_Wing_First_Room_West_Alcove
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //69
        "palace_of_twilight_05",
        new list<*Room> {}, //(palace_of_twilight_04, phantom_zant_2),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_4_small_keys, Requirement.can_defeat_shadow_beast, Requirement.Clawshot}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest,
            checks.Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest,
            checks.Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest,
            checks.Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest
        }
        , 
        false,
        "Palace of Twilight"
    },
    { //70
        "palace_of_twilight_07",
        new list<*Room> {}, //(palace_of_twilight_00_01, palace_of_twilight_11),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_5_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_Central_First_Room_Chest
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //71
        "palace_of_twilight_08",
        new list<*Room> {}, //(palace_of_twilight_11, palace_of_twilight_09),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_7_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_Central_Tower_Chest
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //72
        "palace_of_twilight_09",
        new list<*Room> {}, //(palace_of_twilight_08, zant),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Palace_of_Twilight_Big_Key, Requirement.can_defeat_shadow_beast}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Palace of Twilight"
    },
    { //73
        "palace_of_twilight_11",
        new list<*Room> {}, //(palace_of_twilight_07, palace_of_twilight_08),
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.palace_of_twilight_6_small_keys, Requirement.can_defeat_zant_head, Requirement.Light_Sword}
        },
        false,
        new list<Check> 
        {
            checks.Palace_of_Twilight_Big_Key_Chest,
            checks.Palace_of_Twilight_Central_Outdoor_Chest
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //74
        "phantom_zant_1",
        new list<*Room> {}, //(palace_of_twilight_02),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_phantom_zant}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Palace of Twilight"
    },
    { //75
        "phantom_zant_2",
        new list<*Room> {}, //(palace_of_twilight_05),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_phantom_zant}
        },
        false,
        new list<Check> {}, 
        
        false,
        "Palace of Twilight"
    },
    { //76
        "zant",
        new list<*Room> {}, //(palace_of_twilight_00_01),
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_zant}
        },
        false,
        new list<Check> 
        {
            checks.Zant_Heart_Container
        }, 
        
        false,
        "Palace of Twilight"
    },
    { //77
	    "hyrule_castle_01",
	    new list<*Room> {}, //(hyrule_castle_11, hyrule_castle_02)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_lizalfos, Requirement.Double_Clawshot}
        },
	    false,
	    new list<Check> 
        {
            checks.Hyrule_Castle_Main_Hall_Northeast_Chest,
            checks.Hyrule_Castle_Main_Hall_Southwest_Chest,
            checks.Hyrule_Castle_Main_Hall_Northwest_Chest
        }, 
        
	    false,
	    "Hyrule Castle"
    },
    { //78
	    "hyrule_castle_02",
	    new list<*Room> {}, //(hyrule_castle_01, hyrule_castle_03, hyrule_castle_05)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang},
            new list<Requirement> {Requirement.can_defeat_darknut, Requirement.Lantern, Requirement.Boomerang}
        },
	    false,
	    new list<Check> 
        {
            checks.Hyrule_Castle_Lantern_Staircase_Chest
        }, 
        
	    false,
	    "Hyrule Castle"
    },
    { //79
	    "hyrule_castle_03",
	    new list<*Room> {}, //(hyrule_castle_02, hyrule_castle_04)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_knock_down_hc_painting, Requirement.can_defeat_lizalfos}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Hyrule Castle"
    },
    { //80
    	"hyrule_castle_04",
    	new list<*Room> {}, //(hyrule_castle_03, hyrule_castle_01, hyrule_castle_15)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_darknut},
            new list<Requirement> {Requirement.can_defeat_darknut}
        },
    	false,
    	new list<Check> 
        {}, 
    	false,
    	"Hyrule Castle"
    },
    { //81
    	"hyrule_castle_05",
	    new list<*Room> {}, //(hyrule_castle_02, hyrule_castle_06)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Hyrule Castle"
    },
    { //82
    	"hyrule_castle_06",
    	new list<*Room> {}, //(hyrule_castle_05, hyrule_castle_01, hyrule_castle_15)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_dinalfos},
            new list<Requirement> {Requirement.can_defeat_dinalfos}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Hyrule Castle"
    },
    { //83
    	"hyrule_castle_08",
    	new list<*Room> {}, //(hyrule_castle_12)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
    	false,
    	new list<Check> 
        {
            checks.Hyrule_Castle_Treasure_Room_Eighth_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Seventh_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Sixth_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Fifth_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Fourth_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Third_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Second_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_First_Small_Chest,
            checks.Hyrule_Castle_Treasure_Room_Fifth_Chest,
            checks.Hyrule_Castle_Treasure_Room_Fourth_Chest,
            checks.Hyrule_Castle_Treasure_Room_Third_Chest,
            checks.Hyrule_Castle_Treasure_Room_Second_Chest,
            checks.Hyrule_Castle_Treasure_Room_First_Chest
        }, 
        
    	false,
    	"Hyrule Castle"
    },
    { //84
    	"hyrule_castle_09",
    	new list<*Room> {}, //(hyrule_castle_14)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
    	false,
    	new list<Check> 
        {
            checks.Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest,
            checks.Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest,
            checks.Hyrule_Castle_Graveyard_Grave_Switch_Room_Rear_Left_Chest,
            checks.Hyrule_Castle_Graveyard_Owl_Statue_Chest
        }, 
        
    	false,
    	"Hyrule Castle"
    },
    { //85
    	"hyrule_castle_11",
    	new list<*Room> {}, //(castle_town, hyrule_castle_01, hyrule_castle_13, hyrule_castle_14)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.hyrule_castle_1_small_key},
            new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_kargarok},
            new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_kargarok}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Hyrule Castle"
    },
    { //86
    	"hyrule_castle_12",
    	new list<*Room> {}, //(hyrule_castle_15, hyrule_castle_08, ganondorf_castle())
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.hyrule_castle_3_small_keys, Requirement.Spinner, Requirement.Double_Clawshot, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos},
            new list<Requirement> {Requirement.Spinner, Requirement.Double_Clawshot, Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.Hyrule_Castle_Big_Key}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Hyrule Castle"
    },
    { //87
    	"hyrule_castle_13",
    	new list<*Room> {}, //(hyrule_castle_11)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
    	false,
    	new list<Check> 
        {
            checks.Hyrule_Castle_West_Courtyard_North_Small_Chest,
            checks.Hyrule_Castle_West_Courtyard_Central_Small_Chest
        }, 
        
    	false,
    	"Hyrule Castle"
    },
    { //88
    	"hyrule_castle_14",
	    new list<*Room> {}, //(hyrule_castle_11, hyrule_castle_09)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest,
            checks.Hyrule_Castle_East_Wing_Balcony_Chest
        }, 
        
	    false,
	    "Hyrule Castle"
    },
    { //89
    	"hyrule_castle_15",
    	new list<*Room> {}, //(hyrule_castle_04, hyrule_castle_06, hyrule_castle_12)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_darknut, Requirement.can_defeat_lizalfos, Requirement.can_knock_down_hc_painting},
            new list<Requirement> {Requirement.Lantern, Requirement.can_defeat_dinalfos},
            new list<Requirement> {Requirement.hyrule_castle_2_small_keys}
        },
    	false,
    	new list<Check> 
        {
            checks.Hyrule_Castle_Southeast_Balcony_Tower_Chest,
            checks.Hyrule_Castle_Big_Key_Chest
        }, 
        
    	false,
    	"Hyrule Castle"
    },
    { //90
    	"ganondorf_castle",
    	new list<*Room> {}, //(hyrule_castle_12)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Ganondorf"
    },
    { //91
    	"arbiters_grounds_00",
    	new list<*Room> {}, //(outside_arbiters_grounds, arbiters_grounds_01)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.arbiters_grounds_1_small_key}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_Lobby_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //92
    	"arbiters_grounds_01",
    	new list<*Room> {}, //(arbiters_grounds_00, arbiters_grounds_02_06_15)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //93
    	"arbiters_grounds_02_06_15",
    	new list<*Room> {}, //(arbiters_grounds_01, arbiters_grounds_07, arbiters_grounds_03, arbiters_grounds_04, arbiters_grounds_09)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.arbiters_grounds_4_small_keys, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat},
            new list<Requirement> {Requirement.Poe_Scent, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.can_defeat_redead_knight},
            new list<Requirement> {Requirement.arbiters_grounds_2_small_keys},
            new list<Requirement> {Requirement.can_defeat_poe, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.Poe_Scent, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalfos},
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_East_Lower_Turnable_Redead_Chest,
            checks.Arbiters_Grounds_Torch_Room_East_Chest,
            checks.Arbiters_Grounds_Torch_Room_West_Chest,
            checks.Arbiters_Grounds_West_Small_Chest_Behind_Block,
            checks.Arbiters_Grounds_West_Chandelier_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //94
    	"arbiters_grounds_03",
    	new list<*Room> {}, //(arbiters_grounds_02_06_15)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //95
    	"arbiters_grounds_04",
    	new list<*Room> {}, //(arbiters_grounds_02_06_15, arbiters_grounds_05)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_bubble, Requirement.arbiters_grounds_3_small_keys}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_East_Upper_Turnable_Chest,
            checks.Arbtiers_Grounds_East_Upper_Turnable_Redead_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //96
    	"arbiters_grounds_05",
    	new list<*Room> {}, //(arbiters_grounds_04, arbiters_grounds_14)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //97
    	"arbiters_grounds_07",
    	new list<*Room> {}, //(arbiters_grounds_02_06_15, arbiters_grounds_12)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_stalfos}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_West_Stalfos_North_Chest,
            checks.Arbiters_Grounds_West_Stalfos_Southeast_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //98
    	"arbiters_grounds_08",
    	new list<*Room> {}, //(arbiters_grounds_12, arbiters_grounds_07)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_poe},
            new list<Requirement> {Requirement.can_defeat_poe}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //99
    	"arbiters_grounds_09",
    	new list<*Room> {}, //(arbiters_grounds_02_06_15, arbiters_grounds_16, stallord)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Spinner, Requirement.Clawshot},
            new list<Requirement> {Requirement.Spinner, Requirement.Arbiters_Grounds_Big_Key}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_Big_Key_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //100
    	"arbiters_grounds_10",
    	new list<*Room> {}, //(arbiters_grounds_16, arbiters_grounds_11)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_poison_mite}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //101
    	"arbiters_grounds_11",
    	new list<*Room> {}, //(arbiters_grounds_10, death_sword, can_access_arbiters_grounds_13)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite},
            new list<Requirement> {Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite, Requirement.Spinner}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //102
    	"arbiters_grounds_12",
    	new list<*Room> {}, //(arbiters_grounds_07, arbiters_grounds_08)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //103
    	"arbiters_grounds_13",
    	new list<*Room> {}, //(arbiters_grounds_11, arbiters_grounds_09)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Spinner}
        },
	    false,
	    new list<Check> 
        {
            checks.Arbiters_Grounds_Spinner_Room_First_Small_Chest,
            checks.Arbiters_Grounds_Spinner_Room_Second_Small_Chest,
            checks.Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest,
            checks.Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest,
            checks.Arbiters_Grounds_Spinner_Room_Lower North_Chest
        }, 
        
	    false,
	    "Arbiter's Grounds"
    },
    { //104
    	"arbiters_grounds_14",
    	new list<*Room> {}, //(arbiters_grounds_05, arbiters_grounds_02)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_ghoul_rat, Requirement.arbiters_grounds_4_small_keys}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_Ghoul_Rat_Room_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //105
    	"arbiters_grounds_16",
    	new list<*Room> {}, //(arbiters_grounds_09, arbiters_grounds_10)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_bubble, Requirement.arbiters_grounds_5_small_keys}
        },
    	false,
    	new list<Check> 
        {
            checks.Arbiters_Grounds_North_Turning_Room_Chest
        }, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //106
    	"stallord",
    	new list<*Room> {}, //(mirror_chamber)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Stallord}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Arbiter's Grounds"
    },
    { //107
    	"death_sword",
	    new list<*Room> {}, //(arbiters_grounds_11)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Death_Sword},
        },
	    false,
	    new list<Check> 
        {
            checks.Death_Sword_Chest
        }, 
        
	    false,
	    "Arbiter's Grounds"
    },
    { //108
    	"snowpeak_ruins_00_01_02_03",
    	new list<*Room> {}, //(snowpeak_summit, snowpeak_ruins_07, snowpeak_ruins_04_W, snowpeak_ruins_04_E)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ordon_Goat_Cheese},
            new list<Requirement> {Requirement.Ordon_Pumpkin},
            new list<Requirement> {Requirement.crystal_or_ball_and_chain}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Lobby_Chandelier_Chest,
            checks.Snowpeak_Ruins_Lobby_West_Armor_Chest,
            checks.Snowpeak_Ruins_lobby_East_Armor_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //109
    	"snowpeak_ruins_04_E",
    	new list<*Room> {}, //(snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_W, snowpeak_ruins_13)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ball_and_Chain},
            new list<Requirement> {Requirement.snowpeak_ruins_4_small_keys},
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_East_Courtyard_Burried_Chest,
            checks.Snowpeak_Ruins_East_Courtyard_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //110
    	"snowpeak_ruins_04_W",
    	new list<*Room> {}, //(snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E, snowpeak_ruins_09, snowpeak_ruins_11, darkhammer, blizzeta)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ball_and_Chain},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs},
            new list<Requirement> {Requirement.can_access_darkhammer},
            new list<Requirement> {Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs, Requirement.Snowpeak_Ruins_Bedroom_Key},
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_West_Courtyard_Buried_Chest,
            checks.Snowpeak_Ruins_Courtyard_Central_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //111
    	"snowpeak_ruins_05_lower",
    	new list<*Room> {}, //(snowpeak_ruins_13, snowpeak_ruins_00_01_02_03)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_chilfos}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Ordon_Pumpkin_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //112
    	"snowpeak_ruins_05_upper",
    	new list<*Room> {}, //(snowpeak_ruins_05_lower, snowpeak_ruins_00_01_02_03)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ball_and_Chain}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Northeast_Chandelier_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //113
    	"snowpeak_ruins_06",
    	new list<*Room> {}, //(snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E,
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.crystal_or_ball_and_chain},
            new list<Requirement> {Requirement.Ball_and_Chain, Requirement.Clawshot, Requirement.can_defeat_chilfos}
            new list<Requirement> {Requirement.snowpeak_ruins_4_small_keys}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //114
    	"snowpeak_ruins_07",
    	new list<*Room> {}, //(snowpeak_ruins_00_01_02_03, snowpeak_ruins_06, snowpeak_ruins_08)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Ball_and_Chain, Requirement.snowpeak_ruins_4_small_keys},
            new list<Requirement> {}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Broken_Floor_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //115
    	"snowpeak_ruins_08",
    	new list<*Room> {}, //(snowpeak_ruins_09)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Wooden_Beam_Central_Chest,
            checks.Snowpeak_Ruins_Wooden_Beam_Northwest_Chest,
            checks.Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //116
    	"snowpeak_ruins_09",
    	new list<*Room> {}, //(snowpeak_ruins_04_W, snowpeak_ruins_08)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_smash}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_West_Cannon_Room_Central_Chest,
            checks.Snowpeak_Ruins_West_Cannon_Room_Corner_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //117
    	"snowpeak_ruins_11",
    	new list<*Room> {}, //(snowpeak_ruins_04_W)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_chilfos}
        },
    	false,
    	new list<Check> 
        {
            checks.Snowpeak_Ruins_Chapel_Chest
        }, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //118
    	"snowpeak_ruins_13",
    	new list<*Room> {}, //(snowpeak_ruins_04_E, snowpeak_ruins_05_lower)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_mini_freezard}
        },
    	false,
    	new list<Check> {}, 
        
	    false,
	    "Snowpeak Ruins"
    },
    { //119
    	"blizzeta",
    	new list<*Room> {}, //(snowpeak_summit)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Blizzeta}
        },
    	false,
    	new list<Check> {}, 
        
    	false,
    	"Snowpeak Ruins"
    },
    { //120
	    "darkhammer",
	    new list<*Room> {}, //(snowpeak_ruins_04_W)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Can_Defeat_Darkhammer}
        },
	    false,
	    new list<Check> 
        {
            checks.Snowpeak_Ruins_Chest_After_Darkhammer
        }, 
        
	    false,
	    "Snowpeak Ruins"
    },
    { //121
	    "lanayru_ice_puzzle_cave",
	    new list<*Room> {}, //(lanayru_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lanayru_Ice_Puzzle_Cave_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //122
	    "cave_of_ordeals_01_11",
	    new list<*Room> {}, //(gerudo_desert, cave_of_ordeals_12_21)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Clawshot},
            new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_skulltula, Requirement.can_defeat_bublin, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_tetike, Requirement.can_defeat_lizalfos.}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Cave of Ordeals"
    },
    { //123
	    "cave_of_ordeals_12_21",
	    new list<*Room> {}, //(ordon spring, cave_of_ordeals_22_31)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Clawshot},
            new list<Requirement> {Requirement.can_defeat_helmasaur, Requirement.can_defeat_rat, Requirement.Spinner, Requirement.can_defeat_chu, Requirement.can_defeat_chu_worm, Requirement.can_defeat_bubble, Requirement.can_defeat_bublin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_stalhound, Requirement.can_defeat_poe, Requirement.can_defeat_leever}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Cave of Ordeals"
    },
    { //124
	    "cave_of_ordeals_22_31",
	    new list<*Room> {}, //(faron spring, cave_of_ordeals_32_41)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Clawshot},
            new list<Requirement> {Requirement.can_defeat_bokoblin, Requirement.can_defeat_ice_keese, Requirement.Ball_And_Chain, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalchild, Requirement.can_defeat_redead_knight, REquirement.can_defeat_bublin, Requirement.can_defeat_stalfos, Requirement.can_defeat_skulltula, Requirement.can_defeat_bubble, Requirement.can_defeat_lizalfos, Requirement.can_defeat_fire_bubble}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Cave of Ordeals"
    },
    { //125
	    "cave_of_ordeals_32_41",
	    new list<*Room> {}, //(eldin spring, cave_of_ordeals_42_50)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Clawshot},
            new list<Requirement> {Requirement.can_defeat_beamos, Requirement.can_defeat_keese, Requirement.Powered_Dominion_Rod, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_fire_bubble, Requirement.can_defeat_redead_knight, Requirement.can_defeat_poe, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_chu, Requirement.can_defeat_ice_keese, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ice_bubble, Requirement.can_defeat_leever, Requirement.can_defeat_darknut}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Cave of Ordeals"
    },
    { //126
	    "cave_of_ordeals_42_50",
	    new list<*Room> {}, //(lanayru spring)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_armos, Requirement.Double_Clawshot, Requirement.can_defeat_bokoblin, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_lizalfos, Requirement.can_defeat_bublin, Requirement.can_defeat_dinalfos, Requirement.can_defeat_poe, Requirement.can_defeat_redead_knight, Requirement.can_defeat_chu, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_rat, Requirement.can_defat_stalchild, Requirement.can_defeat_aeralfos, Requirement.can_defeat_darknut}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Cave of Ordeals"
    },
    { //127
	    "eldin_long_cave",
	    new list<*Room> {}, //(kakariko_gorge)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Eldin_Lantern_Cave_First_Chest,
            checks.Eldin_Lantern_Cave_Lantern_Chest,
            checks.Eldin_Lantern_Cave_Second_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //128
	    "lake_hylia_long_cave",
	    new list<*Room> {}, //(lake_hylia)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Lantern_Cave_First_Chest,
            checks.Lake_Lantern_Cave_Second_Chest,
            checks.Lake_Lantern_Cave_Third_Chest,
            checks.Lake_Lantern_Cave_Fourth_Chest,
            checks.Lake_Lantern_Cave_Fifth_Chest,
            checks.Lake_Lantern_Cave_Sixth_Chest,
            checks.Lake_Lantern_Cave_Seventh_Chest,
            checks.Lake_Lantern_Cave_Eighth_Chest,
            checks.Lake_Lantern_Cave_Ninth_Chest,
            checks.Lake_Lantern_Cave_Tenth_Chest,
            checks.Lake_Lantern_Cave_Eleventh_Chest,
            checks.Lake_Lantern_Cave_Twelfth_Chest,
            checks.Lake_Lantern_Cave_Thirteenth_Chest,
            checks.Lake_Lantern_Cave_Fourteenth_Chest,
            checks.Lake_Lantern_Cave_End_Lantern_Chest

        }, 
        
	    false,
	    "Lanayru Province"
    },
    { //129
	    "goron_stockcave",
	    new list<*Room> {}, //(eldin_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Eldin_Stockcave_Upper_Chest,
            checks.Eldin_Stockcave_Lantern_Chest,
            checks.Eldin_Stockcave_Lowest_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //130
	    "grotto_1_0",
	    new list<*Room> {}, //(outside_castle_town_west)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.West_Hyrule_Field_Helmasaur_Grotto_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //131
	    "grotto_1_1",
	    new list<*Room> {}, //(eldin_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Eldin_Field_Bomskit_Grotto_Left_Chest,
            checks.Eldin_Field_Bomskit_Grotto_Lantern_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //132
	    "grotto_1_2",
	    new list<*Room> {}, //(ordon_province)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Ordon_Ranch_Grotto_Lantern_Chest
        }, 
        
	    false,
	    "Ordonia Province"
    },
    { //133
	    "grotto_1_3",
	    new list<*Room> {}, //(lanayru_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Hyrule Field"
    },
    { //134
	    "grotto_2_0",
	    new list<*Room> {}, //(lanayru_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lanayru_Field_Stalfos_Grotto_Right_Small_Chest,
            checks.Lanayru_Field_Stalfos_Grotto_Left_Small_Chest,
            checks.Lanayru_Field_Stalfos_Grotto_Stalfos_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //135
	    "grotto_2_1",
	    new list<*Room> {}, //(faron_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Faron_Field_Corner_Grotto_Right_Chest,
            checks.Faron_Field_Corner_Grotto_Left_Chest,
            checks.Faron_Field_Corner_Grotto_Rear_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //136
	    "grotto_2_2",
	    new list<*Room> {}, //(sacred_grove_master_sword)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Sacred_Grove_Deku_Baba_Grotto_Chest
        }, 
        
	    false,
	    "Sacred Grove"
    },
    { //137
	    "grotto_3_0",
	    new list<*Room> {}, //(gerudo_desert)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Gerudo_Desert_Poe_Grotto_Lantern_Chest
        }, 
        
	    false,
	    "Gerudo Desert"
    },
    { //138
	    "grotto_4_0",
	    new list<*Room> {}, //(lake_hylia_bridge)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Hylia_Bridge_Bubble_Grotto_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //139
	    "grotto_4_1",
	    new list<*Room> {}, //(gerudo_desert)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Gerudo_Desert_Skulltula_Grotto_Chest
        }, 
        
	    false,
	    "Gerudo Desert"
    },
    { //140
	    "grotto_4_2",
	    new list<*Room> {}, //(can_access_snowpeak_climb)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Snowpeak_Freezard_Grotto_Chest
        }, 
        
	    false,
	    "Snowpeak Province"
    },
    { //141
	    "grotto_4_3",
	    new list<*Room> {}, //(lanayru_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lanayru_Field_Skulltula_Grotto_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //142
	    "grotto_5_0",
	    new list<*Room> {}, //(outside_castle_town_south)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Outside_South_Castle_Town_Tetike_Grotto_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //143
	    "grotto_5_2",
	    new list<*Room> {}, //(lake_hylia)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Hylia_Water_Toadpoli_Grotto_Chest
        }, 
        
	    false,
	    "Lanayru Province"
    },
    { //144
	    "grotto_5_3",
	    new list<*Room> {}, //(eldin_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Eldin_Field_Bomb_Fish_Grotto_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //145
	    "grotto_5_4",
	    new list<*Room> {}, //(lake_hylia)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Hylia_Shell_Blade_Grotto_Chest
        }, 
        
	    false,
	    "Lanayru Province"
    },
    { //146
	    "south_faron_woods_cave",
	    new list<*Room> {}, //(south_faron_woods, faron_mist_area)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern}
        },
	    false,
	    new list<Check> 
        {
            checks.South_Faron_Cave_Chest
        },
	    false,
	    "Faron Woods"
    },
    { //147
	    "ordon_province",
	    new list<*Room> {}, //(south_faron_woods)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Wooden_Sword}
        },
	    false,
	    new list<Check> 
        {
            checks.Gift_From_Rusl,
            checks.Links_Basement_Chest,
            checks.Wrestling_With_Bo
        },
	    false,
	    "Ordonia Province"
    },
    { //148
	    "south_faron_woods",
	    new list<*Room> {}, //(ordon_province, faron_field, south_faron_woods_cave, faron_mist_area)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.diababa_defeated},
            new list<Requirement> {Requirement.Coro_Key},
            new list<Requirement> {Requirement.can_smash, Requirement.Powered_Dominion_Rod, Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Faron Woods"
    },
    { //149
	    "faron_mist_area",
	    new list<*Room> {}, //(south_faron_woods_cave, faron_mist_cave, north_faron_woods)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern},
            new list<Requirement> {Requirement.Small_Key_N_Faron_Gate}
        },
	    false,
	    new list<Check> 
        {
            checks.Faron_Mist_Stump_Chest,
            checks.Faron_Mist_North_Chest,
            checks.Faron_Mist_South_Chest,
            checks.Faron_Woods_Owl_Statue_Chest

        }, 
        
	    false,
	    "Faron Woods"
    },
    { //150
	    "faron_mist_cave",
	    new list<*Room> {}, //(faron_mist_area)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Faron_Mist_Cave_Open_Chest,
            checks.Faron_Mist_Cave_Lantern_Chest
        },
	    false,
	    "Faron Woods"
    },
    { //151
	    "north_faron_woods",
	    new list<*Room> {}, //(faron_mist_area, forest_temple_22, lost_woods)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lantern},
            new list<Requirement> {Requirement.fused_shadow_count_3, Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.North_Faron_Woods_Deku_Baba_Chest
        },
	    false,
	    "Faron Woods"
    },
    { //152
	    "kakariko_village",
	    new list<*Room> {}, //(kakariko_gorge, eldin_field, death_mountain_trail, lake_hylia)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Eldin_Vessel_of_Light},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Water_Bombs, Requirement.Iron_Boots}
        },
	    false,
	    new list<Check> 
        {
            checks.Kakariko_Inn_Chest,
            checks.Eldin_Spring_Underwater_Chest,
            checks.Kakariko_Graveyard_Lantern_Chest,
            checks.Kakariko_Watchtower_Chest,
            checks.Kakariko_Watchtower_Alcove_Chest,
            checks.Kakariko_Bomb_Rock_Spire_Heart_Piece
        }, 
        
	    false,
	    "Eldin Province"
    },
    { //153
	    "death_mountain_trail",
	    new list<*Room> {}, //(kakariko_village, death_mountain_volcano)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots}
        },
	    false,
	    new list<Check> 
        {
            checks.Death_Mountain_Alcove_Chest
        }, 
        
	    false,
	    "Eldin Province"
    },
    { //154
	    "death_mountain_volcano",
	    new list<*Room> {}, //(death_mountain_trail, death_mountain_interiors)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Iron_Boots, Requirement.can_defeat_goron}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Eldin Province"
    },
    { //155
	    "zoras_domain",
	    new list<*Room> {}, //(lanayru_field, snowpeak_climb)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light}
        },
	    false,
	    new list<Check> 
        {
            checks.Zoras_Domain_Chest_By_Mother_and_Child_Isles,
            checks.Zoras_Domain_Chest_Behind_Waterfall,
            checks.Zoras_Domain_Light_All_Torches_Chest,
            checks.Zoras_Domain_Extinguish_All_Torches_Chest,
            checks.Fishing_Hole_Heart_Piece
        }, 
        
	    false,
	    "Lanayru Province"
    },
    { //156
	    "snowpeak_climb",
	    new list<*Room> {}, //(zoras_domain, snowpeak_summit, grotto_4_2)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Reekfish_Scent, Requirement.Shadow_Crystal},
			new list<Requirement> {Requirement.Reekfish_Scent, Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Snowpeak Province"
    },
    { //157
	    "snowpeak_summit",
	    new list<*Room> {}, //(snowpeak_climb, snowpeak_ruins_00)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.can_defeat_shadow_beast}
        },
	    false,
	    new list<Check> 
        {
            checks.Snowpeak_Cave_Ice_Lantern_Chest
        }, 
        
	    false,
	    "Snowpeak Province"
    },
    { //158
	    "lake_hylia",
	    new list<*Room> {}, //(gerudo_desert, lake_hylia_long_cave, grotto_5_2, grotto_5_4, lakebed_temple_00, city_in_the_sky_00, lake_hylia_bridge, zoras_domain)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Aurus_Memo, Requirement.Lanayru_Vessel_of_Light},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.can_smash},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Iron_Boots, Requirement.Water_Bombs, Requirement.Zora_Armor},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Clawshot, Requirement.Ancient_Sky_Book_Completed}
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light, Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Hylia_Underwater_Chest,
            checks.Outside_Lanayru_Spring_Left_Statue_Chest,
            checks.Outside_Lanayru_Spring_Right_Statue_Chest,
            checks.Lanayru_Spring_Underwater_Left_Chest,
            checks.Lanayru_Spring_Underwater_Right_Chest,
            checks.Lanayru_Spring_Back_Room_Left_Chest,
            checks.Lanayru_Spring_Back_Room_Right_Chest,
            checks.Lanayru_Spring_Back_Room_Lantern_Chest,
            checks.Flight_By_Fowl_Top_Platform,
            checks.Flight_By_Fowl_Second_Platform,
            checks.Flight_By_Fowl_Third_Platform,
            checks.Flight_By_Fowl_Fourth_Platform,
            checks.Flight_By_Fowl_Fifth_Platform,
            checks.Lanayru_Spring_East_Double_Clawshot_Chest,
            checks.Lanayru_Spring_West_Double_Clawshot_Chest
        }, 
        
	    false,
	    "Lanayru Province"
    },
    { //159
	    "castle_town",
	    new list<*Room> {}, //(outside_castle_town_west, eldin_field, outside_castle_town_south, hyrule_castle_11)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {},
            new list<Requirement> {},
            new list<Requirement> {Requirement.zant_defeated, Requirement.mdh_complete}
        },
	    false,
	    new list<Check> 
        {
            checks.Doctors_Office_Balcony_Chest
        }, 
        
	    false,
	    "Castle Town"
    },
    { //160
	    "lost_woods",
	    new list<*Room> {}, //(north_faron_woods, sacred_grove_master_sword)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_skull_kid_2}
        },
	    false,
	    new list<Check> 
        {
            checks.Lost_Woods_Lantern_Chest
        }, 
        
	    false,
	    "Sacred Grove"
    },
    { //161
	    "sacred_grove_master_sword",
	    new list<*Room> {}, //(lost_woods, sacred_grove_temple_of_time, grotto_2_2)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_shadow_beast, Requirement.Master_Sword},
            new list<Requirement> {Requirement.can_smash && Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Sacred_Grove_Spinner_Chest
        }, 
        
	    false,
	    "Sacred Grove"
    },
    { //162
	    "sacred_grove_temple_of_time",
	    new list<*Room> {}, //(sacred_grove_master_sword, temple_of_time_00)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Master_Sword}
        },
	    false,
	    new list<Check> 
        {
            checks.Sacred_Grove_Past_Owl_Statue
        }, 
        
	    false,
	    "Sacred Grove"
    },
    { //163
	    "bublin_camp",
	    new list<*Room> {}, //(gerudo_desert, outside_arbiters_grounds)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_defeat_king_bublin_3}
        },
	    false,
	    new list<Check> 
        {
            checks.Bublin_Camp_First_Chest_Under_Tower_at_Entrance,
            checks.Bublin_Camp_Small_Chest_in_Back_of_Camp
        }, 
        
	    false,
	    "Gerudo Desert"
    },
    { //164
	    "outside_arbiters_grounds",
	    new list<*Room> {}, //(bublin_camp, arbiters_grounds_00)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Outside_Arbiters_Grounds_Lantern_Chest
        }, 
        
	    false,
	    "Gerudo Desert"
    },
    { //165
	    "eldin_field",
	    new list<*Room> {}, //(kakariko_gorge, kakariko_village, goron_stockcave, castle_town, lanayru_field, grotto_5_3, grotto_1_1)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Clawshot},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Eldin_Field_Bomb_Rock_Chest,
            checks.Bridge_of_Eldin_Owl_Statue_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //166
	    "kakariko_gorge",
	    new list<*Room> {}, //(eldin_field, faron_field, kakariko_village, eldin_long_cave)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {},
            new list<Requirement> {},
            new list<Requirement> {Requirement.can_smash}
        },
	    false,
	    new list<Check> 
        {
            checks.Kakariko_Gorge_Owl_Statue_Chest,
            checks.Kakariko_Gorge_Double_Clawshot_Chest,
            checks.Kakariko_Gorge_Spire_Heart_Piece
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //167
	    "faron_field",
	    new list<*Room> {}, //(south_faron_woods, outside_castle_town_south, kakariko_gorge, lake_hylia_bridge, grotto_2_1)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Gate_Keys},
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Faron_Field_Bridge_Chest,
            checks.Faron_Field_Tree_Heart_Piece
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //168
	    "lanayru_field",
	    new list<*Room> {}, //(eldin_field, zoras_domain, outside_castle_town_west, lanayru_ice_puzzle_cave, lake_hylia_bridge, hidden_village, grotto_2_0, grotto_4_3, grotto_1_3)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {}
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {Requirement.can_smash},
            new list<Requirement> {Requirement.Wooden_Statue},
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Lanayru_Field_Behind_Gate_Underwater_Chest,
            checks.Lanayru_Field_Spinner_Track_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //169
	    "lake_hylia_bridge",
	    new list<*Room> {}, //(faron_field, lake_hylia, lanayru_field, outside_castle_town_west, grotto_4_0)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.Gate_Keys},
            new list<Requirement> {},
            new list<Requirement> {Requriement.can_smash},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Shadow_Crystal, Requirement.can_launch_bombs, Requirement.Clawshot}
        },
	    false,
	    new list<Check> 
        {
            checks.Lake_Hylia_Bridge_Vines_Chest,
            checks.Lake_Hylia_Bridge_Cliff_Chest,
            checks.Lake_Hylia_Bridge_Owl_Statue_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //170
	    "outside_castle_town_west",
	    new list<*Room> {}, //(lake_hylia_bridge, lanayru_field, castle_town, grotto_1_0)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {},
            new list<Requirement> {},
            new list<Requirement> {Requirement.Shadow_Crystal, Requirement.Clawshot}
        },
	    false,
	    new list<Check> 
        {
            checks.Hyrule_Field_Ampitheater_Owl_Statue_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //171
	    "outside_castle_town_south",
	    new list<*Room> {}, //(castle_town, faron_field, grotto_5_0, lake hylia)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.Lanayru_Vessel_of_Light},
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.South_Castle_Field_Tightrope_Chest,
            checks.Outside_Castle_Town_Fountain_Chest,
            checks.South_of_Castle_Town_Double_Clawshot_Chasm_Chest
        }, 
        
	    false,
	    "Hyrule Field"
    },
    { //172
	    "gerudo_desert",
	    new list<*Room> {}, //(cave_of_ordeals, bublin_camp, grotto_3_0, grotto_4_1)
        new list<list<Requirement>> 
        {
            new list<Requirement> {Requirement.can_defeat_shadow_beast, Requirement.Clawshot},
            new list<Requirement> {Requirement.can_defeat_bublin},
            new list<Requirement> {Requirement.Shadow_Crystal},
            new list<Requirement> {Requirement.Shadow_Crystal}
        },
	    false,
	    new list<Check> 
        {
            checks.Gerudo_Desert_Peahat_Ledge_Chest,
            checks.Gerudo_Desert_East_Canyon_Chest,
            checks.Gerudo_Desert_Lone_Small_Chest,
            checks.Gerudo_Desert_West_Canyon_Chest,
            checks.Gerudo_Desert_Northeast_Chest_Behind_Gates,
            checks.Gerudo_Desert_South_Chest_Behind_Wooden_Gates,
            checks.Gerudo_Desert_Campfire_North_Chest,
            checks.Gerudo_Desert_Campfire_East_Chest,
            checks.Gerudo_Desert_Campfire_West_Chest,
            checks.Gerudo_Desert_Northwest_Chest_Behind_Gates,
            checks.Gerudo_Desert_North_Small_Chest_Before_Bublin_Camp,
            checks.Gerudo_Desert_Owl_Statue_Chest
        }, 
        
	    false,
	    "Gerudo Desert"
    },
    { //173
	    "mirror_chamber",
	    new list<*Room> {}, //(stallord, palace_of_twilight_00)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {Requirement.mirror_shard_count_4, Requirement.can_defeat_shadow_beast}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Gerudo Desert"
    },
    { //174
	    "hidden_village",
	    new list<*Room> {}, //(lanayru_field)
        new list<list<Requirement>> 
        {
            new list<Requirement> {}
        },
	    false,
	    new list<Check> 
        {
            checks.Cats_Hide_and_Seek_Minigame
        }, 
        
	    false,
	    "Hidden Village"
    },
    { //175
	    "death_mountain_interiors",
	    new list<*Room> {}, //(death_mountain_volcano, goron_mines_01)
        new list<list<Requirement>> 
        {
            new list<Requirement> {},
            new list<Requirement> {}
        },
	    false,
	    new list<Check> {}, 
        
	    false,
	    "Eldin Province"
    }
} 
