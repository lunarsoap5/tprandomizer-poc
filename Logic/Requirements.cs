using System;
using Assets.Items;

int forestTempleSmallKeyCount;
int goronMinesSmallKeyCount;
int lakebedTempleSmallKeyCount;
int arbitersGroundsSmallKeyCount;
int snowpeakRuinsSmallKeyCount;
int templeofTimeSmallKeyCount;
int cityinTheSkySmallKeyCount;
int palaceofTwilightSmallKeyCount;
int hyruleCastleSmallKeyCount;
int fusedShadowCount;
int mirrorShardCount;

bool mdhComplete;
bool diababaDefeated;
bool fyrusDefeated;
bool morpheelDefeated;
bool stallordDefeated;
bool blizzetaDefeated;
bool armogohmaDefeated;
bool argorokDefeated;
bool zantDefeated;
bool ganondorfDefeated;


/*Check requirement identification */
enum Requirement
{
    /*Boss Logic Requirements*/
    Can_Defeat_Ook,
    Can_Defeat_Dangoro,
    Can_Defeat_Carrier_Kargarok,
    Can_Defeat_Twilit_Bloat,
    Can_Defeat_Deku_Toad,
    Can_Defeat_Skull_Kid_1,
    Can_Defeat_Skull_Kid_2,
    Can_Defeat_King_Bublin_2,
    Can_Defeat_King_Bublin_3,
    Can_Defeat_King_Bublin_4,
    Can_Defeat_Death_Sword,
    Can_Defeat_Darkhammer,
    Can_Defeat_Phantom_Zant,
    Can_Defeat_Diababa,
    Can_Defeat_Fyrus,
    Can_Defeat_Morpheel,
    Can_Defeat_Stallord,
    Can_Defeat_Blizzeta,
    Can_Defeat_Armogohma,
    Can_Defeat_Argorok,
    Can_Defeat_Zant,
    Can_Defeat_Ganondorf,

    /*Check Logic*/
    Gift_From_Rusl,
    South_Faron_Cave_Chest,
    Faron_Mist_Cave_Open_Chest,
    Faron_Mist_Cave_Lantern_Chest,
    North_Faron_Woods_Deku_Baba_Chest,
    Links_Basement_Chest,
    Forest_Temple_Entrance_Vine_Chest,
    Forest_Temple_Central_Chest_Behind_Stairs,
    Forest_Temple_Central_North_Chest,
    Forest_Temple_Windless_Bridge_Chest,
    Forest_Temple_Second_Monkey_Under_Bridge_Chest,
    Forest_Temple_Totem_Pole_Chest,
    Forest_Temple_West_Tile_Worm_Room_Vines_Chest,
    Forest_Temple_West_Deku_Like_Chest,
    Forest_Temple_West_Tile_Worm_Chest_Behind_Stairs,
    Forest_Temple_Central_Chest_Hanging_From_Web,
    Forest_Temple_Big_Key_Chest,
    Forest_Temple_East_Water_Cave_Chest,
    Forest_Temple_North_Deku_Like_Chest,
    Forest_Temple_East_Tile_Worm_Chest,
    Kakariko_Inn_Chest,
    Wrestling_With_Bo,
    Goron_Mines_Entrance_Chest,
    Goron_Mines_Main_Magnet_Room_Bottom_Chest,
    Goron_Mines_Gor_Amato_Chest,
    Goron_Mines_Gor_Amato_Small_Chest,
    Goron_Mines_Magnet_Maze_Chest,
    Goron_Mines_Crystal_Switch_Room_Underwater_Chest,
    Goron_Mines_Crystal_Switch_Room_Small_Chest,
    Goron_Mines_After_Crystal_Switch_Room_Magnet_Wall_Chest,
    Goron_Mines_Outside_Beamos_Chest,
    Goron_Mines_Gor_Ebizo_Chest,
    Goron_Mines_Chest_Before_Dangoro,
    Goron_Mines_Dangoro_Chest,
    Goron_Mines_Beamos_Room_Chest,
    Goron_Mines_Gor_Liggs_Chest,
    Goron_Mines_Main_Magnet_Room_Top_Chest,
    Goron_Mines_Outside_Underwater_Chest,
    Eldin_Spring_Underwater_Chest,
    Kakariko_Graveyard_Lantern_Chest,
    Kakariko_Watchtower_Chest,
    Kakariko_Watchtower_Alcove_Chest,
    Eldin_Field_Bomb_Rock_Chest,
    Zoras_Domain_Chest_By_Mother_and_Child_Isles,
    Zoras_Domain_Chest_Behind_Waterfall,
    Lake_Hylia_Underwater_Chest,
    Lakebed_Temple_Lobby_Left_Chest,
    Lakebed_Temple_Lobby_Rear_Chest,
    Lakebed_Temple_Stalactite_Room_Chest,
    Lakebed_Temple_Central_Room_Small_Chest,
    Lakebed_Temple_Central_Room_Chest,
    Lakebed_Temple_East_Lower_Waterwheel_Stalactite_Chest,
    Lakebed_Temple_East_Second_Floor_Southwest_Chest,
    Lakebed_Temple_East_Second_Floor_Southeast_Chest,
    Lakebed_Temple_East_Water_Supply_Small_Chest,
    Lakebed_Temple_Before_Deku_Toad_Alcove_Chest,
    Lakebed_Temple_Before_Deku_Toad_Underwater_Left_Chest,
    Lakebed_Temple_Before_Deku_Toad_Underwater_Right_Chest,
    Lakebed_Temple_Deku_Toad_Chest,
    Lakebed_Temple_Chandelier_Chest,
    Lakebed_Temple_East_Water_Supply_Clawshot_Chest,
    Lakebed_Temple_Central_Room_Center_Spire_Chest,
    Lakebed_Temple_West_Lower_Small_Chest,
    Lakebed_Temple_West_Water_Supply_Small_Chest,
    Lakebed_Temple_West_Water_Supply_Chest,
    Lakebed_Temple_West_Second_Floor_Southwest_Underwater_Chest,
    Lakebed_Temple_West_Second_Floor_Central_Small_Chest,
    Lakebed_Temple_West_Second_Floor_Northeast_Chest,
    Lakebed_Temple_West_Second_Floor_Southeast_Chest,
    Lakebed_Temple_Big_Key_Chest,
    Lakebed_Temple_Underwater_Maze_Small_Chest,
    Lakebed_Temple_East_Lower_Waterwheel_Bridge_Chest,
    Sacred_Grove_Deku_Baba_Grotto_Chest,
    West_Hyrule_Field_Helmasaur_Grotto_Chest,
    Lake_Lantern_Cave_First_Chest,
    Lake_Lantern_Cave_Second_Chest,
    Lake_Lantern_Cave_Third_Chest,
    Lake_Lantern_Cave_Fourth_Chest,
    Lake_Lantern_Cave_Fifth_Chest,
    Lake_Lantern_Cave_Sixth_Chest,
    Lake_Lantern_Cave_Seventh_Chest,
    Lake_Lantern_Cave_Eighth_Chest,
    Lake_Lantern_Cave_Ninth_Chest,
    Lake_Lantern_Cave_Tenth_Chest,
    Lake_Lantern_Cave_Eleventh_Chest,
    Lake_Lantern_Cave_Twelfth_Chest,
    Lake_Lantern_Cave_Thirtennth_Chest,
    Lake_Lantern_Cave_Fourteenth_Chest,
    Lake_Lantern_Cave_End_Lantern_Chest,
    Lake_Hylia_Water_Toadpoli_Grotto_Chest,
    Outside_Lanayru_Spring_Left_Statue_Chest,
    Outside_Lanayru_Spring_Right_Statue_Chest,
    Lanayru_Spring_Underwater_Left_Chest,
    Lanayru_Spring_Underwater_Right_Chest,
    Lanayru_Spring_Back_Room_Left_Chest,
    Lanayru_Spring_Back_Room_Right_Chest,
    Lanayru_Spring_Back_Room_Lantern_Chest,
    Flight_By_Fowl_Top_Platform_Chest,
    Flight_By_Fowl_Second_Platform_Chest,
    Flight_By_Fowl_Third_Platform_Chest,
    Flight_By_Fowl_Fourth_Platform_Chest,
    Flight_By_Fowl_Fifth_Platform_Chest,
    Lake_Hylia_Shell_Blade_Grotto_Chest,
    ZD_Light_All_Torches_Chest,
    ZD_Extinguish_All_Torches_Chest,
    Lanayru_Field_Skulltula_Grotto_Chest,
    Lanayru_Field_Behind_Gate_Underwater_Chest,
    Lake_Hylia_Bridge_Vines_Chest,
    Lake_Hylia_Bridge_Bubble_Grotto_Chest,
    Lake_Hylia_Bridge_Cliff_Chest,
    Faron_Field_Bridge_Chest,
    Faron_Field_Corner_Grotto_Right_Chest,
    Faron_Field_Corner_Grotto_Rear_Chest,
    Faron_Field_Corner_Grotto_Left_Chest,
    Death_Mountain_Alcove_Chest,
    Goron_Mines_Outside_Clawshot_Chest,
    Eldin_Lantern_Cave_First_Chest,
    Eldin_Lantern_Cave_Lantern_Chest,
    Eldin_Lantern_Cave_Second_Chest,
    Outside_South_Castle_Town_Field_Tightrope_Chest,
    Outside_South_Castle_Town_Tetike_Grotto_Chest,
    Eldin_Field_Bomskit_Grotto_Left_Chest,
    Eldin_Field_Bomskit_Grotto_Lantern_Chest,
    Eldin_Field_Water_Bomb_Fish_Grotto_Chest,
    Gerudo_Desert_Skulltula_Grotto_Chest,
    Gerudo_Desert_Peahat_Ledge_Chest,
    Gerudo_Desert_East_Canyon_Chest,
    Gerudo_Desert_Lone_Small_Chest,
    Eldin_Stockcave_Upper_Chest,
    Eldin_Stockcave_Lantern_Chest,
    Eldin_Stockcave_Lowest_Chest,
    Gerudo_Desert_West_Canyon_Chest,
    Gerudo_Desert_Poe_Grotto_Lantern_Chest,
    Gerudo_Desert_Northeast_Chest_Behind_Gates,
    Gerudo_Desert_South_Chest_Behind_Wooden_Gates,
    Gerudo_Desert_Campfire_North_Chest,
    Gerudo_Desert_Campfire_East_Chest,
    Gerudo_Desert_Campfire_West_Chest,
    Gerudo_Desert_Northwest_Chest_Behind_Gates,
    North_Small_Chest_Before_Bublin_Camp,
    Bublin_Camp_First_Chest_Under_Tower_at_Entrance,
    Bublin_Camp_Small_Chest_in_Back_of_Camp,
    Outside_Arbiters_Grounds_Lantern_Chest,
    Arbiters_Grounds_Lobby_Chest,
    Arbiters_Grounds_East_Lower_Turnable_Redead_Chest,
    Arbiters_Grounds_Torch_Room_East_Chest,
    Arbiters_Grounds_Torch_Room_West_Chest,
    Arbiters_Grounds_East_Upper_Turnable_Chest,
    Arbiters_Grounds_East_Upper_Turnable_Redead_Chest,
    Arbiters_Grounds_Ghoul_Rat_Room_Chest,
    Arbiters_Grounds_West_Small_Chest_Behind_Block,
    Arbiters_Grounds_West_Chandelier_Chest,
    Arbiters_Grounds_West_Stalfos_North_Chest,
    Arbiters_Grounds_West_Stalfos_Southeast_Chest,
    Arbiters_Grounds_North_Turning_Room_Chest,
    Arbiters_Grounds_Death_Sword_Chest,
    Arbiters_Grounds_Spinner_Room_First_Small_Chest,
    Arbiters_Grounds_Spinner_Room_Second_Small_Chest,
    Arbiters_Grounds_Spinner_Room_Lower_Central_Small_Chest,
    Arbiters_Grounds_Spinner_Room_Stalfos_Alcove_Chest,
    Arbiters_Grounds_Spinner_Room_Lower_North_Chest,
    Arbiters_Grounds_Big_Key_Chest,
    Lanayru_Field_Spinner_Track_Chest,
    Lanayru_Field_Stalfos_Grotto_Right_Small_Chest,
    Lanayru_Field_Stalfos_Grotto_Left_Small_Chest,
    Lanayru_Field_Stalfos_Grotto_Stalfos_Chest,
    Outside_South_Castle_Town_Fountain_Chest,
    Ordon_Ranch_Grotto_Lantern_Chest,
    Faron_Mist_Stump_Chest,
    Faron_Mist_North_Chest,
    Faron_Mist_South_Chest,
    Snowpeak_Ruins_West_Courtyard_Buried_Chest,
    Snowpeak_Ruins_East_Courtyard_Buried_Chest,
    Snowpeak_Ruins_Ordon_Pumpkin_Chest,
    Snowpeak_Ruins_East_Courtyard_Chest,
    Snowpeak_Ruins_Wooden_Beam_Central_Chest,
    Snowpeak_Ruins_Wooden_Beam_Northwest_Chest,
    Snowpeak_Ruins_Courtyard_Central_Chest,
    Snowpeak_Ruins_Chest_After_Darkhammer,
    Snowpeak_Ruins_Broken_Floor_Chest,
    Snowpeak_Ruins_Wooden_Beam_Chandelier_Chest,
    Snowpeak_Ruins_Lobby_Chandelier_Chest,
    Snowpeak_Ruins_Lobby_West_Armor_Chest,
    Snowpeak_Ruins_Lobby_East_Armor_Chest,
    Snowpeak_Ruins_Northeast_Chandelier_Chest,
    Snowpeak_Ruins_West_Cannon_Room_Central_Chest,
    Snowpeak_Ruins_West_Cannon_Room_Corner_Chest,
    Snowpeak_Ruins_Chapel_Chest,
    Snowpeak_Cave_Ice_Lantern_Chest,
    Snowpeak_Freezard_Grotto_Chest,
    Lanayru_Ice_Block_Puzzle_Cave_Chest,
    Lost_Woods_Lantern_Chest,
    Sacred_Grove_Spinner_Chest,
    Temple_of_Time_Lobby_Lantern_Chest,
    Temple_of_Time_First_Staircase_Gohma_Gate_Chest,
    Temple_of_Time_First_Staircase_Window_Chest,
    Temple_of_Time_First_Staircase_Armos_Chest,
    Temple_of_Time_Statue_Throws_Room_East_Chest,
    Temple_of_Time_Moving_Wall_Beamos_Room_Chest,
    Temple_of_Time_Scales_Gohma_Chest,
    Temple_of_Time_Gilloutine_Chest,
    Temple_of_Time_Chest_Before_Midboss,
    Temple_of_Time_Darknut_Chest,
    Temple_of_Time_Scales_Upper_Chest,
    Temple_of_Time_Big_Key_Chest_Room_Upper_Chest,
    Temple_of_Time_Big_Key_Chest,
    Temple_of_Time_Moving_Wall_Dinalfos_Room_Chest,
    Temple_of_Time_Statue_Throws_Room_North_Chest,
    Temple_of_Time_Statue_Throws_Room_Statue_Chest,
    Sacred_Grove_Past_Owl_Statue_Chest,
    Doctors_Office_Balcony_Chest,
    Bridge_of_Eldin_Owl_Statue_Chest,
    Kakariko_Gorge_Owl_Statue_Chest,
    Hyrule_Field_Ampitheater_Owl_Statue_Chest,
    Lake_Hylia_Bridge_Owl_Statue_Chest,
    Faron_Woods_Owl_Statue_Chest,
    Gerudo_Desert_Owl_Statue_Chest,
    City_in_The_Sky_Underwater_West_Chest,
    City_in_The_Sky_Underwater_East_Chest,
    City_in_The_Sky_West_Wing_First_Chest,
    City_in_The_Sky_East_First_Wing_Chest_After_Fans,
    City_in_The_Sky_East_Tile_Worm_Small_Chest,
    City_in_The_Sky_East_Wing_After_Dinalfos_Alcove_Chest,
    City_in_The_Sky_East_Wing_After_Dinalfos_Ledge_Chest,
    City_in_The_Sky_Aeralfos_Chest,
    City_in_The_Sky_East_Wing_Lower_Level_Chest,
    City_in_The_Sky_West_Wing_Baba_Balcony_Chest,
    City_in_The_Sky_West_Wing_Narrow_Ledge_Chest,
    City_in_The_Sky_West_Wing_Tile_Worm_Chest,
    City_in_The_Sky_Baba_Tower_Top_Small_Chest,
    City_in_The_Sky_Baba_Tower_Narrow_Ledge_Chest,
    City_in_The_Sky_Baba_Tower_Alcove_Chest,
    City_in_The_Sky_West_Garden_Corner_Chest,
    City_in_The_Sky_West_Garden_Lone_Island_Chest,
    City_in_The_Sky_West_Garden_Lower_Chest,
    City_in_The_Sky_West_Garden_Ledge_Chest,
    City_in_The_Sky_Central_Outside_Ledge_Chest,
    City_in_The_Sky_Central_Outside_Poe_Island_Chest,
    City_in_The_Sky_Big_Key_Chest,
    City_in_The_Sky_Chest_Below_Big_Key_Chest,
    City_in_The_Sky_Chest_Behind_North_Fan,
    Kakariko_Gorge_Double_Clawshot_Chest,
    Lanayru_Spring_East_Double_Clawshot_Chest,
    Lanayru_Spring_West_Double_Clawshot_Chest,
    South_of_Castle_Town_Double_Clawshot_Chasm_Chest,
    Palace_of_Twilight_West_Wing_First_Room_Central_Chest,
    Palace_of_Twilight_West_Wing_Second_Room_Central_Chest,
    Palace_of_Twilight_West_Wing_Second_Room_Lower_South_Chest,
    Palace_of_Twilight_West_Wing_Second_Room_Southeast_Chest,
    Palace_of_Twilight_West_Wing_Chest_Behind_Wall_of_Darkness,
    Palace_of_Twilight_East_Wing_First_Room_North_Small_Chest,
    Palace_of_Twilight_East_Wing_First_Room_Zant_Head_Chest,
    Palace_of_Twilight_East_Wing_Second_Room_Northeast_Chest,
    Palace_of_Twilight_East_Wing_Second_Room_Northwest_Chest,
    Palace_of_Twilight_East_Wing_Second_Room_Southwest_Chest,
    Palace_of_Twilight_East_Wing_Second_Room_Southeast_Chest,
    Palace_of_Twilight_East_Wing_First_Room_East_Alcove,
    Palace_of_Twilight_East_Wing_First_Room_West_Alcove,
    Palace_of_Twilight_Central_First_Room_Chest,
    Palace_of_Twilight_Big_Key_Chest,
    Palace_of_Twilight_Central_Outdoor_Chest,
    Palace_of_Twilight_Central_Tower_Chest,
    Hyrule_Castle_Graveyard_Grave_Switch_Room_Right_Chest,
    Hyrule_Castle_Graveyard_Grave_Switch_Room_Front_Left_Chest,
    Hyrule_Castle_Graveyard_Grave_Switch_Room_Back_Left_Chest,
    Hyrule_Castle_Graveyard_Owl_Statue_Chest,
    Hyrule_Castle_East_Wing_Boomerang_Puzzle_Chest,
    Hyrule_Castle_East_Wing_Balcony_Chest,
    Hyrule_Castle_West_Courtyard_North_Small_Chest,
    Hyrule_Castle_West_Courtyard_Central_Small_Chest,
    Hyrule_Castle_Main_Hall_Northeast_Chest,
    Hyrule_Castle_Lantern_Staircase_Chest,
    Hyrule_Castle_Main_Hall_Southwest_Chest,
    Hyrule_Castle_Main_Hall_Northwest_Chest,
    Hyrule_Castle_Southeast_Balcony_Tower_Chest,
    Hyrule_Castle_Big_Key_Chest,
    Hyrule_Castle_Treasure_Room_Eighth_Small_Chest,
    Hyrule_Castle_Treasure_Room_Seventh_Small_Chest,
    Hyrule_Castle_Treasure_Room_Sixth_Small_Chest,
    Hyrule_Castle_Treasure_Room_Fifth_Small_Chest,
    Hyrule_Castle_Treasure_Room_Fourth_Small_Chest,
    Hyrule_Castle_Treasure_Room_Third_Small_Chest,
    Hyrule_Castle_Treasure_Room_Second_Small_Chest,
    Hyrule_Castle_Treasure_Room_First_Small_Chest,
    Hyrule_Castle_Treasure_Room_Fifth_Chest,
    Hyrule_Castle_Treasure_Room_Fourth_Chest,
    Hyrule_Castle_Treasure_Room_Third_Chest,
    Hyrule_Castle_Treasure_Room_Second_Chest,
    Hyrule_Castle_Treasure_Room_First_Chest,
    Kakariko_Village_Bomb_Rock_Spire_Heart_Piece,
    Faron_Field_Tree_Heart_Piece,
    Kakariko_Gorge_Spire_Heart_Piece,
    Zant_Heart_Container,
    Fishing_Hole_Heart_Piece,
    Cats_Hide_and_Seek_Minigame,

    /*Entrance Logic*/
    Lakebed_Temple_00_01_to_02_03,

    Lakebed_Temple_02_03_to_07,
    Lakebed_Temple_02_03_to_12,
    Can_Access_Morpheel,

    Lakebed_Temple_05_to_06,

    Lakebed_Temple_07_to_10,
    Lakebed_Temple_07_to_08,

    Lakebed_Temple_08_to_09,

    Lakebed_Temple_09_to_Deku_Toad,

    Lakebed_Temple_11_to_02_03,
    Lakebed_Temple_11_to_13,
    
    Lakebed_Temple_12_to_11,
    Lakebed_Temple_12_to_05,

    Deku_Toad_to_Lakebed_Temple_09,

    Goron_Mines_01_to_03,

    Goron_Mines_03_to_04_05,
    Goron_Mines_03_to_06,

    Goron_Mines_04_05_to_14,

    Goron_Mines_06_to_07,

    Goron_Mines_07_to_09_17,
    Goron_Mines_07_to_12,

    Goron_Mines_09_17_to_Dangoro,

    Goron_Mines_11_to_13,
    Goron_Mines_11_to_16,

    Can_Access_Fyrus,

    Goron_Mines_13_to_03,

    Forest_Temple_00_01_to_02,
    Forest_Temple_00_01_to_03,
    Forest_Temple_00_01_to_09,
    Forest_Temple_00_01_to_Ook,

    Forest_Temple_02_to_01,

    Forest_Temple_03_to_05,
    Forest_Temple_03_to_07,
    Forest_Temple_03_to_Ook,

    Forest_Temple_09_to_10,
    Forest_Temple_09_to_11,
    Forest_Temple_09_to_12,

    Forest_Temple_12_to_19,
    Can_Access_Diababa,

    Forest_Temple_22_to_00_01,

    Temple_of_Time_00_to_01,
    Temple_of_Time_00_to_08,
    
    Temple_of_Time_01_to_02,

    Temple_of_Time_02_to_03,
    Temple_of_Time_02_to_04,

    Temple_of_Time_04_to_05,
    
    Temple_of_Time_05_to_06,

    Temple_of_Time_07_to_darknut,

    Can_Access_Armogohma,

    City_in_The_Sky_00_16_to_Lake_Hylia,
    City_in_The_Sky_00_06_to_01,

    City_in_The_Sky_01_to_02_03_14,

    City_in_The_Sky_02_03_14_to_04,
    City_in_The_Sky_02_03_14_to_06,
    City_in_The_Sky_02_03_14_to_13,
    City_in_The_Sky_02_03_14_to_15,

    City_in_The_Sky_04_to_07_lower,

    City_in_The_Sky_05_to_Aeralfos,
    City_in_The_Sky_05_to_04,

    City_in_The_Sky_06_to_10,

    City_in_The_Sky_07_lower_to_08,

    City_in_The_Sky_07_upper_to_05,

    City_in_The_Sky_08_to_07_upper,

    City_in_The_Sky_10_to_11,

    City_in_The_Sky_11_to_12,

    City_in_The_Sky_12_to_13,

    City_in_The_Sky_13_to_02,

    Can_Access_Argorok,

    Aeralfos_to_City_in_The_Sky_05,

    Palace_of_Twilight_00_01_to_02,
    Palace_of_Twilight_00_01_to_04,
    Palace_of_Twilight_00_01_to_07,

    Palace_of_Twilight_02_to_Phantom_Zant_1,

    Palace_of_Twilight_04_to_05,

    Palace_of_Twilight_05_to_Phantom_Zant_2,

    Palace_of_Twilight_07_to_11,

    Palace_of_Twilight_08_to_09,

    Can_Access_Zant,

    Palace_of_Twilight_11_to_08,

    Hyrule_Castle_01_to_02,

    Hyrule_Castle_02_to_03,
    Hyrule_Castle_02_to_05,

    Hyrule_Castle_03_to_04,

    Hyrule_Castle_04_to_01,
    Hyrule_Castle_04_to_15,

    Hyrule_Castle_05_to_06,

    Hyrule_Castle_06_to_01,
    Hyrule_Castle_06_to_15,

    Hyrule_Castle_09_to_14,

    Hyrule_Castle_11_to_01,
    Hyrule_Castle_11_to_13,
    Hyrule_Castle_11_to_14,
    Hyrule_Castle_12_to_08,
    Can_Access_Ganondorf,

    Hyrule_Castle_14_to_09,

    Hyrule_Castle_15_to_04,
    Hyrule_Castle_15_to_06,
    Hyrule_Castle_15_to_12,

    Arbiters_Grounds_00_to_01,

    Arbiters_Grounds_01_to_02_06_15,

    Arbiters_Grounds_02_06_15_to_07,
    Arbiters_Grounds_02_06_15_to_03,
    Arbiters_Grounds_02_06_15_to_04,
    Arbiters_Grounds_02_06_15_to_09,

    Arbiters_Grounds_04_to_05,

    Arbiters_Grounds_05_to_14,

    Arbiters_Grounds_07_to_12,

    Arbiters_Grounds_08_to_12,
    Arbiters_Grounds_08_to_07,

    Arbiters_Grounds_09_to_16,
    Arbiters_Grounds_09_to_13, //Only used in Glitched Logic or tricks

    Arbiters_Grounds_10_to_11,

    Arbiters_Grounds_11_to_death_sword,
    Arbiters_Grounds_11_to_13,

    Arbiters_Grounds_12_to_08,
    Arbiters_Grounds_13_to_09,

    Arbiters_Grounds_14_to_02_06_15,

    Arbiters_Grounds_16_to_10,

    Snowpeak_Ruins_00_01_02_03_to_07,
    Snowpeak_Ruins_00_01_02_03_to_04_W,
    Snowpeak_Ruins_00_01_02_03_to_04_E,

    Snowpeak_Ruins_04_E_to_04_W,
    Snowpeak_Ruins_04_E_to_13,

    Snowpeak_Ruins_04_W_to_04_E,
    Snowpeak_Ruins_04_W_to_09,
    Snowpeak_Ruins_04_W_to_11,
    Snowpeak_Ruins_04_W_to_Darkhammer,
    Snowpeak_Ruins_04_W_to_Blizzeta,

    Snowpeak_Ruins_05_Lower_to_00_01_02_03,
    Snowpeak_Ruins_05_Upper_to_00_01_02_03,

    Snowpeak_Ruins_06_to_04_E,
    Snowpeak_Ruins_06_to_05_Upper,
    Snowpeak_Ruins_06_to_07,

    Snowpeak_Ruins_07_to_06,

    Snowpeak_Ruins_09_to_08,

    Snowpeak_Ruins_11_to_04_W,

    Snowpeak_Ruins_13_to_05_Lower,

    Cave_of_Ordeals_01_11_to_12_21,

    Cave_of_Ordeals_12_21_to_22_31,

    Cave_of_Ordeals_22_31_to_32_41,

    Cave_of_Ordeals_32_41_to_42_50,

    Can_Complete_Cave_of_Ordeals,

    South_Faron_Woods_Cave_to_Faron_Mist_Area,

    Ordon_Province_to_South_Faron_Woods,

    South_Faron_Woods_to_Faron_Field,
    South_Faron_Woods_to_South_Faron_Woods_Cave,
    South_Faron_Woods_to_Faron_Mist_Area,

    Faron_Mist_Area_to_Faron_Mist_Cave,
    Faron_Mist_Area_to_North_Faron_Woods,

    North_Faron_Woods_to_Forest_Temple,
    North_Faron_Woods_to_Lost_Woods,

    Kakariko_Village_to_Eldin_Field,
    Kakariko_Village_to_Lake_Hylia,

    Death_Mountain_Trail_to_Volcano,

    Death_Mountain_Volcano_to_Interiors,

    Zoras_Domain_to_Snowpeak,

    Snowpeak_Climb_to_Snowpeak_Summit,
    Snowpeak_Climb_to_Grotto_4_2,

    Snowpeak_Summit_to_Snowpeak_Climb,
    Snowpeak_Summit_to_Snowpeak_Ruins,

    Lake_Hylia_to_Gerudo_Desert,
    Lake_Hylia_to_Lake_Hylia_Long_Cave,
    Lake_Hylia_to_Grotto_5_2, 
    Lake_Hylia_to_Grotto_5_4,
    Lake_Hylia_to_Lakebed_Temple,
    Lake_Hylia_to_City_in_The_Sky,
    Lake_Hylia_to_Lake_Hylia_Bridge,
    Lake_Hylia_to_Zoras_Domain,

    Castle_Town_to_Hyrule_Castle,

    Lost_Woods_to_Sacred_Grove_Master_Sword,

    Sacred_Grove_Master_Sword_to_Sacred_Grove_Temple_of_Time,
    Sacred_Grove_Master_Sword_to_Grotto_2_2,

    Sacred_Grove_Temple_of_Time_to_Temple_of_Time,

    Bublin_Camp_to_Outside_Arbiters_Grounds,

    Eldin_Field_to_Kakariko_Gorge,
    Eldin_Field_to_Goron_Stockcave,
    Eldin_Field_to_Castle_Town,
    Eldin_Field_to_Lanayru_Field,
    Eldin_Field_to_Grotto_5_3,
    Eldin_Field_to_Grotto_1_1,

    Kakariko_Gorge_to_Eldin_Field,
    Kakariko_Gorge_to_Eldin_Long_Cave,

    Faron_Field_to_Outside_Castle_Town_South,
    Faron_Field_to_Lake_Hylia_Bridge,
    Faron_Field_to_Grotto_2_1,

    Lanayru_Field_to_Eldin_Field,
    Lanayru_Field_to_Zoras_Domain,
    Lanayru_Field_to_Lanayru_Ice_Puzzle_Cave,
    Lanayru_Field_to_Lake_Hylia_Bridge, 
    Lanayru_Field_to_Hidden_Village,
    Lanayru_Field_to_Grotto_2_0,
    Lanayru_Field_to_Grotto_4_3,
    Lanayru_Field_to_Grotto_1_3,

    Lake_Hylia_Bridge_to_Faron_Field,
    Lake_Hylia_Bridge_to_Lanayru_Field,
    Lake_Hylia_Bridge_to_Grotto_4_0,

    Outside_Castle_Town_West_to_Grotto_1_0,

    Outside_Castle_Town_South_to_Faron_Field,
    Outside_Castle_Town_South_to_Grotto_5_0,

    Gerudo_Desert_to_Cave_of_Ordeals,
    Gerudo_Desert_to_Bublin_Camp,
    Gerudo_Desert_to_Grotto_3_0,
    Gerudo_Desert_to_Grotto_4_1,
    Mirror_Chamber_to_Palace_of_Twilight,
    
}
