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
    { //138
	    "grotto_4_0",
	    "neighbours": ["lake_hylia_bridge"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lake_Hylia_Bridge_Bubble_Grotto_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //139
	    "grotto_4_1",
	    "neighbours": ["gerudo_desert"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Gerudo_Desert_Skulltula_Grotto_Chest
         ],
	    "visited": "false",
	    "Gerudo Desert"
    }
    { //140
	    "grotto_4_2",
	    "neighbours": ["can_access_snowpeak_climb"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Snowpeak_Freezard_Grotto_Chest
         ],
	    "visited": "false",
	    "Snowpeak Province"
    }
    { //141
	    "grotto_4_3",
	    "neighbours": ["lanayru_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lanayru_Field_Skulltula_Grotto_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //142
	    "grotto_5_0",
	    "neighbours": ["outside_castle_town_south"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Outside_South_Castle_Town_Tetike_Grotto_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //143
	    "grotto_5_2",
	    "neighbours": ["lake_hylia"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lake_Hylia_Water_Toadpoli_Grotto_Chest
         ],
	    "visited": "false",
	    "Lanayru Province"
    }
    { //144
	    "grotto_5_3",
	    "neighbours": ["eldin_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Eldin_Field_Bomb_Fish_Grotto_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //145
	    "grotto_5_4",
	    "neighbours": ["lake_hylia"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lake_Hylia_Shell_Blade_Grotto_Chest
         ],
	    "visited": "false",
	    "Lanayru Province"
    }
    { //146
	    "south_faron_woods_cave",
	    "neighbours": ["south_faron_woods, faron_mist_area"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lantern}
        ],
	    "isStartingRoom": "false",
	    "checks": ["South_Faron_Cave_Chest
        ],
	    "visited": "false",
	    "Faron Woods"
    }
    { //147
	    "ordon_province",
	    "neighbours": ["south_faron_woods"]
        
            "Requirement.Wooden_Sword}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Gift_From_Rusl,
            "Links_Basement_Chest,
            "Wrestling_With_Bo
        ],
	    "visited": "false",
	    "Ordonia Province"
    }
    { //148
	    "south_faron_woods",
	    "neighbours": ["ordon_province, faron_field, south_faron_woods_cave, faron_mist_area"]
        
            "neighbourRequirements": ["true",
            "Requirement.diababa_defeated}
            "Requirement.Coro_Key}
            "Requirement.can_smash, Requirement.Powered_Dominion_Rod, Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Faron Woods"
    }
    { //149
	    "faron_mist_area",
	    "neighbours": ["south_faron_woods_cave, faron_mist_cave, north_faron_woods"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lantern}
            "Requirement.Small_Key_N_Faron_Gate}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Faron_Mist_Stump_Chest,
            "Faron_Mist_North_Chest,
            "Faron_Mist_South_Chest,
            "Faron_Woods_Owl_Statue_Chest

         ],
	    "visited": "false",
	    "Faron Woods"
    }
    { //150
	    "faron_mist_cave",
	    "neighbours": ["faron_mist_area"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Faron_Mist_Cave_Open_Chest,
            "Faron_Mist_Cave_Lantern_Chest
        ],
	    "visited": "false",
	    "Faron Woods"
    }
    { //151
	    "north_faron_woods",
	    "neighbours": ["faron_mist_area, forest_temple_22, lost_woods"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lantern}
            "Requirement.fused_shadow_count_3, Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": ["North_Faron_Woods_Deku_Baba_Chest
        ],
	    "visited": "false",
	    "Faron Woods"
    }
    { //152
	    "kakariko_village",
	    "neighbours": ["kakariko_gorge, eldin_field, death_mountain_trail, lake_hylia"]
        
            "neighbourRequirements": ["true",
            "Requirement.Eldin_Vessel_of_Light}
            "true"
            "Requirement.Water_Bombs, Requirement.Iron_Boots}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Kakariko_Inn_Chest,
            "Eldin_Spring_Underwater_Chest,
            "Kakariko_Graveyard_Lantern_Chest,
            "Kakariko_Watchtower_Chest,
            "Kakariko_Watchtower_Alcove_Chest,
            "Kakariko_Bomb_Rock_Spire_Heart_Piece
         ],
	    "visited": "false",
	    "Eldin Province"
    }
    { //153
	    "death_mountain_trail",
	    "neighbours": ["kakariko_village, death_mountain_volcano"]
        
            "neighbourRequirements": ["true",
            "Requirement.Iron_Boots}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Death_Mountain_Alcove_Chest
         ],
	    "visited": "false",
	    "Eldin Province"
    }
    { //154
	    "death_mountain_volcano",
	    "neighbours": ["death_mountain_trail, death_mountain_interiors"]
        
            "neighbourRequirements": ["true",
            "Requirement.Iron_Boots, Requirement.can_defeat_goron}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Eldin Province"
    }
    { //155
	    "zoras_domain",
	    "neighbours": ["lanayru_field, snowpeak_climb"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lanayru_Vessel_of_Light}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Zoras_Domain_Chest_By_Mother_and_Child_Isles,
            "Zoras_Domain_Chest_Behind_Waterfall,
            "Zoras_Domain_Light_All_Torches_Chest,
            "Zoras_Domain_Extinguish_All_Torches_Chest,
            "Fishing_Hole_Heart_Piece
         ],
	    "visited": "false",
	    "Lanayru Province"
    }
    { //156
	    "snowpeak_climb",
	    "neighbours": ["zoras_domain, snowpeak_summit, grotto_4_2"]
        
            "neighbourRequirements": ["true",
            "Requirement.Reekfish_Scent, Requirement.Shadow_Crystal}
			"Requirement.Reekfish_Scent, Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Snowpeak Province"
    }
    { //157
	    "snowpeak_summit",
	    "neighbours": ["snowpeak_climb, snowpeak_ruins_00"]
        
            "Requirement.Shadow_Crystal}
            "Requirement.can_defeat_shadow_beast}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Snowpeak_Cave_Ice_Lantern_Chest
         ],
	    "visited": "false",
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
        ],
	    "isStartingRoom": "false",
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
         ],
	    "visited": "false",
	    "Lanayru Province"
    }
    { //159
	    "castle_town",
	    "neighbours": ["outside_castle_town_west, eldin_field, outside_castle_town_south, hyrule_castle_11"]
        
            "neighbourRequirements": ["true",
            "true"
            "true"
            "Requirement.zant_defeated, Requirement.mdh_complete}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Doctors_Office_Balcony_Chest
         ],
	    "visited": "false",
	    "Castle Town"
    }
    { //160
	    "lost_woods",
	    "neighbours": ["north_faron_woods, sacred_grove_master_sword"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_skull_kid_2}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lost_Woods_Lantern_Chest
         ],
	    "visited": "false",
	    "Sacred Grove"
    }
    { //161
	    "sacred_grove_master_sword",
	    "neighbours": ["lost_woods, sacred_grove_temple_of_time, grotto_2_2"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_shadow_beast, Requirement.Master_Sword}
            "Requirement.can_smash && Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Sacred_Grove_Spinner_Chest
         ],
	    "visited": "false",
	    "Sacred Grove"
    }
    { //162
	    "sacred_grove_temple_of_time",
	    "neighbours": ["sacred_grove_master_sword, temple_of_time_00"]
        
            "neighbourRequirements": ["true",
            "Requirement.Master_Sword}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Sacred_Grove_Past_Owl_Statue
         ],
	    "visited": "false",
	    "Sacred Grove"
    }
    { //163
	    "bublin_camp",
	    "neighbours": ["gerudo_desert, outside_arbiters_grounds"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_king_bublin_3}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Bublin_Camp_First_Chest_Under_Tower_at_Entrance,
            "Bublin_Camp_Small_Chest_in_Back_of_Camp
         ],
	    "visited": "false",
	    "Gerudo Desert"
    }
    { //164
	    "outside_arbiters_grounds",
	    "neighbours": ["bublin_camp, arbiters_grounds_00"]
        
            "neighbourRequirements": ["true",
            "true"
        ],
	    "isStartingRoom": "false",
	    "checks": ["Outside_Arbiters_Grounds_Lantern_Chest
         ],
	    "visited": "false",
	    "Gerudo Desert"
    }
    { //165
	    "eldin_field",
	    "neighbours": ["kakariko_gorge, kakariko_village, goron_stockcave, castle_town, lanayru_field, grotto_5_3, grotto_1_1"]
        
            "Requirement.can_smash}
            "neighbourRequirements": ["true",
            "Requirement.Clawshot}
            "Requirement.Lanayru_Vessel_of_Light}
            "Requirement.can_smash}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Eldin_Field_Bomb_Rock_Chest,
            "Bridge_of_Eldin_Owl_Statue_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //166
	    "kakariko_gorge",
	    "neighbours": ["eldin_field, faron_field, kakariko_village, eldin_long_cave"]
        
            "Requirement.can_smash}
            "neighbourRequirements": ["true",
            "true"
            "Requirement.can_smash}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Kakariko_Gorge_Owl_Statue_Chest,
            "Kakariko_Gorge_Double_Clawshot_Chest,
            "Kakariko_Gorge_Spire_Heart_Piece
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //167
	    "faron_field",
	    "neighbours": ["south_faron_woods, outside_castle_town_south, kakariko_gorge, lake_hylia_bridge, grotto_2_1"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lanayru_Vessel_of_Light}
            "true"
            "Requirement.Gate_Keys}
            "Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Faron_Field_Bridge_Chest,
            "Faron_Field_Tree_Heart_Piece
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //168
	    "lanayru_field",
	    "neighbours": ["eldin_field, zoras_domain, outside_castle_town_west, lanayru_ice_puzzle_cave, lake_hylia_bridge, hidden_village, grotto_2_0, grotto_4_3, grotto_1_3"]
        
            "Requirement.can_smash}
            "Requirement.can_smash}
            "neighbourRequirements": ["true",
            "Requirement.can_smash}
            "Requirement.can_smash}
            "Requirement.Wooden_Statue}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lanayru_Field_Behind_Gate_Underwater_Chest,
            "Lanayru_Field_Spinner_Track_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //169
	    "lake_hylia_bridge",
	    "neighbours": ["faron_field, lake_hylia, lanayru_field, outside_castle_town_west, grotto_4_0"]
        
            "Requirement.Gate_Keys}
            "neighbourRequirements": ["true",
            "Requriement.can_smash}
            "true"
            "Requirement.Shadow_Crystal, Requirement.can_launch_bombs, Requirement.Clawshot}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lake_Hylia_Bridge_Vines_Chest,
            "Lake_Hylia_Bridge_Cliff_Chest,
            "Lake_Hylia_Bridge_Owl_Statue_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //170
	    "outside_castle_town_west",
	    "neighbours": ["lake_hylia_bridge, lanayru_field, castle_town, grotto_1_0"]
        
            "neighbourRequirements": ["true",
            "true"
            "true"
            "Requirement.Shadow_Crystal, Requirement.Clawshot}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Hyrule_Field_Ampitheater_Owl_Statue_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //171
	    "outside_castle_town_south",
	    "neighbours": ["castle_town, faron_field, grotto_5_0, lake hylia"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lanayru_Vessel_of_Light}
            "Requirement.Shadow_Crystal}
            "true"
        ],
	    "isStartingRoom": "false",
	    "checks": ["South_Castle_Field_Tightrope_Chest,
            "Outside_Castle_Town_Fountain_Chest,
            "South_of_Castle_Town_Double_Clawshot_Chasm_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //172
	    "gerudo_desert",
	    "neighbours": ["cave_of_ordeals, bublin_camp, grotto_3_0, grotto_4_1"]
        
            "Requirement.can_defeat_shadow_beast, Requirement.Clawshot}
            "Requirement.can_defeat_bublin}
            "Requirement.Shadow_Crystal}
            "Requirement.Shadow_Crystal}
        ],
	    "isStartingRoom": "false",
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
         ],
	    "visited": "false",
	    "Gerudo Desert"
    }
    { //173
	    "mirror_chamber",
	    "neighbours": ["stallord, palace_of_twilight_00"]
        
            "neighbourRequirements": ["true",
            "Requirement.mirror_shard_count_4, Requirement.can_defeat_shadow_beast}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Gerudo Desert"
    }
    { //174
	    "hidden_village",
	    "neighbours": ["lanayru_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Cats_Hide_and_Seek_Minigame
         ],
	    "visited": "false",
	    "Hidden Village"
    }
    { //175
	    "death_mountain_interiors",
	    "neighbours": ["death_mountain_volcano, goron_mines_01"]
        
            "neighbourRequirements": ["true",
            "true"
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Eldin Province"
    }
} 
