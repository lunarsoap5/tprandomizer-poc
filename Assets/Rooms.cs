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
    { //91
    	"arbiters_grounds_00",
    	"neighbours": ["outside_arbiters_grounds, arbiters_grounds_01"]
        
            "neighbourRequirements": ["true",
            "Requirement.arbiters_grounds_1_small_key}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_Lobby_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //92
    	"arbiters_grounds_01",
    	"neighbours": ["arbiters_grounds_00, arbiters_grounds_02_06_15"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lantern}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //93
    	"arbiters_grounds_02_06_15",
    	"neighbours": ["arbiters_grounds_01, arbiters_grounds_07, arbiters_grounds_03, arbiters_grounds_04, arbiters_grounds_09"]
        
            "neighbourRequirements": ["true",
            "Requirement.arbiters_grounds_4_small_keys, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat}
            "Requirement.Poe_Scent, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.can_defeat_redead_knight}
            "Requirement.arbiters_grounds_2_small_keys}
            "Requirement.can_defeat_poe, Requirement.Shadow_Crystal, Requirement.Clawshot, Requirement.Poe_Scent, Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild, Requirement.can_defeat_bubble, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalfos}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_East_Lower_Turnable_Redead_Chest,
            "Arbiters_Grounds_Torch_Room_East_Chest,
            "Arbiters_Grounds_Torch_Room_West_Chest,
            "Arbiters_Grounds_West_Small_Chest_Behind_Block,
            "Arbiters_Grounds_West_Chandelier_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //94
    	"arbiters_grounds_03",
    	"neighbours": ["arbiters_grounds_02_06_15"]
        
            "neighbourRequirements": ["true",
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //95
    	"arbiters_grounds_04",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_05"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_bubble, Requirement.arbiters_grounds_3_small_keys}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_East_Upper_Turnable_Chest,
            "Arbtiers_Grounds_East_Upper_Turnable_Redead_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //96
    	"arbiters_grounds_05",
    	"neighbours": ["arbiters_grounds_04, arbiters_grounds_14"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_redead_knight, Requirement.can_defeat_stalchild}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //97
    	"arbiters_grounds_07",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_12"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_stalfos}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_West_Stalfos_North_Chest,
            "Arbiters_Grounds_West_Stalfos_Southeast_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //98
    	"arbiters_grounds_08",
    	"neighbours": ["arbiters_grounds_12, arbiters_grounds_07"]
        
            "Requirement.can_defeat_poe}
            "Requirement.can_defeat_poe}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //99
    	"arbiters_grounds_09",
    	"neighbours": ["arbiters_grounds_02_06_15, arbiters_grounds_16, stallord"]
        
            "neighbourRequirements": ["true",
            "Requirement.Spinner, Requirement.Clawshot}
            "Requirement.Spinner, Requirement.Arbiters_Grounds_Big_Key}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_Big_Key_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //100
    	"arbiters_grounds_10",
    	"neighbours": ["arbiters_grounds_16, arbiters_grounds_11"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_poison_mite}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //101
    	"arbiters_grounds_11",
    	"neighbours": ["arbiters_grounds_10, death_sword, can_access_arbiters_grounds_13"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite}
            "Requirement.can_defeat_stalfos, Requirement.can_defeat_poison_mite, Requirement.Spinner}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //102
    	"arbiters_grounds_12",
    	"neighbours": ["arbiters_grounds_07, arbiters_grounds_08"]
        
            "neighbourRequirements": ["true",
            "Requirement.Lantern}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //103
    	"arbiters_grounds_13",
    	"neighbours": ["arbiters_grounds_11, arbiters_grounds_09"]
        
            "neighbourRequirements": ["true",
            "Requirement.Spinner}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Arbiters_Grounds_Spinner_Room_First_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Second_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest,
            "Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest,
            "Arbiters_Grounds_Spinner_Room_Lower North_Chest
         ],
	    "visited": "false",
	    "Arbiter's Grounds"
    }
    { //104
    	"arbiters_grounds_14",
    	"neighbours": ["arbiters_grounds_05, arbiters_grounds_02"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_ghoul_rat, Requirement.arbiters_grounds_4_small_keys}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_Ghoul_Rat_Room_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //105
    	"arbiters_grounds_16",
    	"neighbours": ["arbiters_grounds_09, arbiters_grounds_10"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_bubble, Requirement.arbiters_grounds_5_small_keys}
        }
    	"isStartingRoom": "false",
    	"checks": ["Arbiters_Grounds_North_Turning_Room_Chest
         ],
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //106
    	"stallord",
    	"neighbours": ["mirror_chamber"]
        
            "Requirement.Can_Defeat_Stallord}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Arbiter's Grounds"
    }
    { //107
    	"death_sword",
	    "neighbours": ["arbiters_grounds_11"]
        
            "Requirement.Can_Defeat_Death_Sword}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Death_Sword_Chest
         ],
	    "visited": "false",
	    "Arbiter's Grounds"
    }
    { //108
    	"snowpeak_ruins_00_01_02_03",
    	"neighbours": ["snowpeak_summit, snowpeak_ruins_07, snowpeak_ruins_04_W, snowpeak_ruins_04_E"]
        
            "neighbourRequirements": ["true",
            "Requirement.Ordon_Goat_Cheese}
            "Requirement.Ordon_Pumpkin}
            "Requirement.crystal_or_ball_and_chain}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Lobby_Chandelier_Chest,
            "Snowpeak_Ruins_Lobby_West_Armor_Chest,
            "Snowpeak_Ruins_lobby_East_Armor_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //109
    	"snowpeak_ruins_04_E",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_W, snowpeak_ruins_13"]
        
            "crystal_or_ball_and_chain}
            "Requirement.Ball_and_Chain}
            "Requirement.snowpeak_ruins_4_small_keys}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_East_Courtyard_Burried_Chest,
            "Snowpeak_Ruins_East_Courtyard_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //110
    	"snowpeak_ruins_04_W",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E, snowpeak_ruins_09, snowpeak_ruins_11, darkhammer, blizzeta"]
        
            "neighbourRequirements": ["true",
            "Requirement.Ball_and_Chain}
            "true"
            "Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs}
            "Requirement.can_access_darkhammer}
            "Requirement.Ordon_Goat_Cheese, Requirement.Ball_and_Chain, Requirement.can_defeat_chilfos, Requirement.can_defeat_mini_freezard, Requirement.can_defeat_freezard, Requirement.snowpeak_ruins_4_small_keys, Requirement.Bombs, Requirement.Snowpeak_Ruins_Bedroom_Key}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_West_Courtyard_Buried_Chest,
            "Snowpeak_Ruins_Courtyard_Central_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //111
    	"snowpeak_ruins_05_lower",
    	"neighbours": ["snowpeak_ruins_13, snowpeak_ruins_00_01_02_03"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_chilfos}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Ordon_Pumpkin_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //112
    	"snowpeak_ruins_05_upper",
    	"neighbours": ["snowpeak_ruins_05_lower, snowpeak_ruins_00_01_02_03"]
        
            "neighbourRequirements": ["true",
            "Requirement.Ball_and_Chain}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Northeast_Chandelier_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //113
    	"snowpeak_ruins_06",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_04_E, snowpeak_ruins_05_upper, snowpeak_ruins_07
        
            "neighbourRequirements": ["true",
            "Requirement.crystal_or_ball_and_chain}
            "Requirement.Ball_and_Chain, Requirement.Clawshot, Requirement.can_defeat_chilfos}
            "Requirement.snowpeak_ruins_4_small_keys}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //114
    	"snowpeak_ruins_07",
    	"neighbours": ["snowpeak_ruins_00_01_02_03, snowpeak_ruins_06, snowpeak_ruins_08"]
        
            "neighbourRequirements": ["true",
            "Requirement.Ball_and_Chain, Requirement.snowpeak_ruins_4_small_keys}
            "Requirement.Ball_and_Chain}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Broken_Floor_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //115
    	"snowpeak_ruins_08",
    	"neighbours": ["snowpeak_ruins_09"]
        
            "neighbourRequirements": ["true",
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Wooden_Beam_Central_Chest,
            "Snowpeak_Ruins_Wooden_Beam_Northwest_Chest,
            "Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //116
    	"snowpeak_ruins_09",
    	"neighbours": ["snowpeak_ruins_04_W, snowpeak_ruins_08"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_smash}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_West_Cannon_Room_Central_Chest,
            "Snowpeak_Ruins_West_Cannon_Room_Corner_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //117
    	"snowpeak_ruins_11",
    	"neighbours": ["snowpeak_ruins_04_W"]
        
            "Requirement.can_defeat_chilfos}
        }
    	"isStartingRoom": "false",
    	"checks": ["Snowpeak_Ruins_Chapel_Chest
         ],
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //118
    	"snowpeak_ruins_13",
    	"neighbours": ["snowpeak_ruins_04_E, snowpeak_ruins_05_lower"]
        
            "neighbourRequirements": ["true",
            "Requirement.can_defeat_mini_freezard}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
	    "visited": "false",
	    "Snowpeak Ruins"
    }
    { //119
    	"blizzeta",
    	"neighbours": ["snowpeak_summit"]
        
            "Requirement.Can_Defeat_Blizzeta}
        }
    	"isStartingRoom": "false",
    	"checks": "", 
        
    	"visited": "false",
    	"Snowpeak Ruins"
    }
    { //120
	    "darkhammer",
	    "neighbours": ["snowpeak_ruins_04_W"]
        
            "Requirement.Can_Defeat_Darkhammer}
        ],
	    "isStartingRoom": "false",
	    "checks": ["Snowpeak_Ruins_Chest_After_Darkhammer
         ],
	    "visited": "false",
	    "Snowpeak Ruins"
    }
    { //121
	    "lanayru_ice_puzzle_cave",
	    "neighbours": ["lanayru_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lanayru_Ice_Puzzle_Cave_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //122
	    "cave_of_ordeals_01_11",
	    "neighbours": ["gerudo_desert, cave_of_ordeals_12_21"]
        
            "Clawshot}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_skulltula, Requirement.can_defeat_bublin, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_tetike, Requirement.can_defeat_lizalfos.}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Cave of Ordeals"
    }
    { //123
	    "cave_of_ordeals_12_21",
	    "neighbours": ["ordon spring, cave_of_ordeals_22_31"]
        
            "Clawshot}
            "Requirement.can_defeat_helmasaur, Requirement.can_defeat_rat, Requirement.Spinner, Requirement.can_defeat_chu, Requirement.can_defeat_chu_worm, Requirement.can_defeat_bubble, Requirement.can_defeat_bublin, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_stalhound, Requirement.can_defeat_poe, Requirement.can_defeat_leever}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Cave of Ordeals"
    }
    { //124
	    "cave_of_ordeals_22_31",
	    "neighbours": ["faron spring, cave_of_ordeals_32_41"]
        
            "Clawshot}
            "Requirement.can_defeat_bokoblin, Requirement.can_defeat_ice_keese, Requirement.Ball_And_Chain, Requirement.can_defeat_keese, Requirement.can_defeat_rat, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_stalchild, Requirement.can_defeat_redead_knight, REquirement.can_defeat_bublin, Requirement.can_defeat_stalfos, Requirement.can_defeat_skulltula, Requirement.can_defeat_bubble, Requirement.can_defeat_lizalfos, Requirement.can_defeat_fire_bubble}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Cave of Ordeals"
    }
    { //125
	    "cave_of_ordeals_32_41",
	    "neighbours": ["eldin spring, cave_of_ordeals_42_50"]
        
            "Clawshot}
            "Requirement.can_defeat_beamos, Requirement.can_defeat_keese, Requirement.Powered_Dominion_Rod, Requirement.can_defeat_torch_slug, Requirement.can_defeat_fire_keese, Requirement.can_defeat_dodongo, Requirement.can_defeat_fire_bubble, Requirement.can_defeat_redead_knight, Requirement.can_defeat_poe, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_chu, Requirement.can_defeat_ice_keese, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ice_bubble, Requirement.can_defeat_leever, Requirement.can_defeat_darknut}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Cave of Ordeals"
    }
    { //126
	    "cave_of_ordeals_42_50",
	    "neighbours": ["lanayru spring"]
        
            "Requirement.can_defeat_armos, Requirement.Double_Clawshot, Requirement.can_defeat_bokoblin, Requirement.can_defeat_baba_serpent, Requirement.can_defeat_lizalfos, Requirement.can_defeat_bublin, Requirement.can_defeat_dinalfos, Requirement.can_defeat_poe, Requirement.can_defeat_redead_knight, Requirement.can_defeat_chu, Requirement.can_defeat_freezard, Requirement.can_defeat_chilfos, Requirement.can_defeat_ghoul_rat, Requirement.can_defeat_rat, Requirement.can_defat_stalchild, Requirement.can_defeat_aeralfos, Requirement.can_defeat_darknut}
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Cave of Ordeals"
    }
    { //127
	    "eldin_long_cave",
	    "neighbours": ["kakariko_gorge"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Eldin_Lantern_Cave_First_Chest,
            "Eldin_Lantern_Cave_Lantern_Chest,
            "Eldin_Lantern_Cave_Second_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //128
	    "lake_hylia_long_cave",
	    "neighbours": ["lake_hylia"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
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

         ],
	    "visited": "false",
	    "Lanayru Province"
    }
    { //129
	    "goron_stockcave",
	    "neighbours": ["eldin_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Eldin_Stockcave_Upper_Chest,
            "Eldin_Stockcave_Lantern_Chest,
            "Eldin_Stockcave_Lowest_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //130
	    "grotto_1_0",
	    "neighbours": ["outside_castle_town_west"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["West_Hyrule_Field_Helmasaur_Grotto_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //131
	    "grotto_1_1",
	    "neighbours": ["eldin_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Eldin_Field_Bomskit_Grotto_Left_Chest,
            "Eldin_Field_Bomskit_Grotto_Lantern_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //132
	    "grotto_1_2",
	    "neighbours": ["ordon_province"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Ordon_Ranch_Grotto_Lantern_Chest
         ],
	    "visited": "false",
	    "Ordonia Province"
    }
    { //133
	    "grotto_1_3",
	    "neighbours": ["lanayru_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": "", 
        
	    "visited": "false",
	    "Hyrule Field"
    }
    { //134
	    "grotto_2_0",
	    "neighbours": ["lanayru_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Lanayru_Field_Stalfos_Grotto_Right_Small_Chest,
            "Lanayru_Field_Stalfos_Grotto_Left_Small_Chest,
            "Lanayru_Field_Stalfos_Grotto_Stalfos_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //135
	    "grotto_2_1",
	    "neighbours": ["faron_field"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Faron_Field_Corner_Grotto_Right_Chest,
            "Faron_Field_Corner_Grotto_Left_Chest,
            "Faron_Field_Corner_Grotto_Rear_Chest
         ],
	    "visited": "false",
	    "Hyrule Field"
    }
    { //136
	    "grotto_2_2",
	    "neighbours": ["sacred_grove_master_sword"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Sacred_Grove_Deku_Baba_Grotto_Chest
         ],
	    "visited": "false",
	    "Sacred Grove"
    }
    { //137
	    "grotto_3_0",
	    "neighbours": ["gerudo_desert"]
        
            "neighbourRequirements": ["true",
        ],
	    "isStartingRoom": "false",
	    "checks": ["Gerudo_Desert_Poe_Grotto_Lantern_Chest
         ],
	    "visited": "false",
	    "Gerudo Desert"
    }
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
