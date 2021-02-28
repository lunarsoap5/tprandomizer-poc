#include "items.h"

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
    Kakariko_Inn_Ches,
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
    ZD_Chest_By_Mother_and_Child_Isles,
    ZD_Chest_Behind_Waterfall,
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
    

}

//Give all possible items you could use/need to meet the requirement. Only really used in Forward fill, but could be useful. Will keep for now.
list<uint8_t> getRequirementItems(Requirement requirment)
{
    list<uint8_t> items = {}
    switch (requirments)
    {
        case Requirement.Ordon_Sword:
            return items.add(items::Ordon_Sword);
            break;
        case Requirement.Master_Sword:
            return items.add(items::Master_Sword);
            break;
        case Requirement.Zora_Armor:
            return items.add(items::Zora_Armor);
            break;
        case Requirement.Shadow_Crystal:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.Big_Wallet:
            return items.add(items::Big_Wallet);
            break;
        case Requirement.Giant_Wallet:
            return items.add(items::Giant_Wallet);
            break;
        case Requirement.Coral_Earring:
            items.add(items::Fishing_Rod);
            return items.add(items::Coral_Earring);
            break;
        case Requirement.Wooden_Sword:
            return items.add(items::Wooden_Sword);
            break;
        case Requirement.Boomerang:
            return items.add(items::Boomerang);
            break;
        case Requirement.Spinner:
            return items.add(items::Spinner);
            break;
        case Requirement.Ball_And_Chain:
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.Bow:
            return items.add(items::Heros_Bow);
            break;
        case Requirement.Clawshot:
            return items.add(items::Clawshot);
            break;
        case Requirement.Iron_Boots:
            return items.add(items::Iron_Boots);
            break;
        case Requirement.Dominion_Rod:
            return items.add(items::Dominion_Rod);
            break;
        case Requirement.Double_Clawshot:
            items.add(items::Double_Clawshot);
            return items.add(items::Clawshot);
            break;
        case Requirement.Lantern:
            return items.add(items::Lantern);
            break;
        case Requirement.Master_Sword_Light:
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.Fishing_Rod:
            return items.add(items::Fishing_Rod);
            break;
        case Requirement.Slingshot:
            return items.add(items::Slingshot);
            break;
        case Requirement.Dominion_Rod_Charged:
            items.add(items::Dominion_Rod_Uncharged);
            return items.add(items::Dominion_Rod);
            break;
        case Requirement.Bombs:
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.Water_Bombs:
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.Empty_Bottle:
            return items.add(items::Empty_Bottle);
            break;
        case Requirement.Renardos_Letter:
            return items.add(items::Renardos_Letter);
            break;
        case Requirement.Invoice:
            return items.add(items::Invoice);
            break;
        case Requirement.Wooden_Statue:
            return items.add(items::Wooden_Statue);
            break;
        case Requirement.Ilias_Charm:
            return items.add(items::Ilias_Charm);
            break;
        case Requirement.Forest_Temple_Small_Key:
            return items.add(items::Forest_Temple_Small_Key);
            break;
        case Requirement.Goron_Mines_Small_Key:
            return items.add(items::Goron_Mines_Small_Key);
            break;
        case Requirement.Lakebed_Temple_Small_Key:
            return items.add(items::Lakebed_Temple_Small_Key);
            break;
        case Requirement.Arbiters_Grounds_Small_Key:
            return items.add(items::Arbiters_Grounds_Small_Key);
            break;
        case Requirement.Snowpeak_Ruins_Small_Key:
            return items.add(items::Snowpeak_Ruins_Small_Key);
            break;
        case Requirement.Temple_of_Time_Small_Key:
            return items.add(items::Temple_of_Time_Small_Key);
            break;
        case Requirement.City_in_The_Sky_Small_Key:
            return items.add(items::City_in_The_Sky_Small_Key);
            break;
        case Requirement.Palace_of_Twilight_Small_Key:
            return items.add(items::Palace_of_Twilight_Small_Key);
            break;
        case Requirement.Hyrule_Castle_Small_Key:
            return items.add(items::Hyrule_Castle_Small_Key);
            break;
        case Requirement.Aurus_Memo:
            return items.add(items::Aurus_Memo);
            break;
        case Requirement.Asheis_Sketch:
            return items.add(items::Asheis_Sketch);
            break;
        case Requirement.Forest_Temple_Big_Key:
            return items.add(items::Forest_Temple_Big_Key);
            break;
        case Requirement.Goron_Mines_Big_Key:
            items.add(items::Goron_Mines_Key_Shard_1);
            items.add(items::Goron_Mines_Key_Shard_2);
            return items.add(items::Goron_Mines_Big_Key);
            break;
        case Requirement.Lakebed_Temple_Big_Key:
            return items.add(items::Lakebed_Temple_Big_Key);
            break;
        case Requirement.Arbiters_Grounds_Big_Key:
            return items.add(items::Arbiters_Grounds_Big_Key);
            break;
        case Requirement.Snowpeak_Ruins_Bedroom_Key:
            return items.add(items::Snowpeak_Ruins_Bedroom_Key);
            break;
        case Requirement.Temple_of_Time_Big_Key:
            return items.add(items::Temple_of_Time_Big_Key);
            break;
        case Requirement.City_in_The_Sky_Big_Key:
            return items.add(items::City_in_The_Sky_Big_Key);
            break;
        case Requirement.Palace_of_Twilight_Big_Key:
            return items.add(items::Palace_of_Twilight_Big_Key);
            break;
        case Requirement.Hyrule_Castle_Big_Key:
            return items.add(items::Hyrule_Castle_Big_Key);
            break;
        case Requirement.Faron_Vessel_of_Light:
            return items.add(items::Faron_Vessel_of_Light);
            break;
        case Requirement.Eldin_Vessel_of_Light:
            return items.add(items::Eldin_Vessel_of_Light);
            break;
        case Requirement.Lanayru_Vessel_of_Light:
            return items.add(items::Lanayru_Vessel_of_Light);
            break;
        case Requirement.Ilias_Scent:
            return items.add(items::Ilias_Scent);
            break;
        case Requirement.Poe_Scent:
            return items.add(items::Poe_Scent);
            break;
        case Requirement.Reekfish_Scent:
            return items.add(items::Reekfish_Scent);
            break;
        case Requirement.Youths_Scent:
            return items.add(items::Youths_Scent);
            break;
        case Requirement.Medicine_Scent
            return items.add(items::Medicine_Scent);
            break;
        case Requirement.Ancient_Sky_Book_Empty:
            return items.add(items::Ancient_Sky_Book_Empty);
            break;
        case Requirement.Ancient_Sky_Book_Completed:
            items.add(items::Ancient_Sky_Book_Completed);
            items.add(items::Ancient_Sky_Book_Empty);
            items.add(items::Ancient_Sky_Book_First_Character);
            items.add(items::Ancient_Sky_Book_Second_Character);
            items.add(items::Ancient_Sky_Book_Third_Character);
            items.add(items::Ancient_Sky_Book_Fourth_Character);
            return items.add(items::Ancient_Sky_Book_Fifth_Character);
        case Requirement.Small_Key_N_Faron_Gate:
            return items.add(items::Small_Key_N_Faron_Gate);
            break;
        case Requirement.Gate_Keys:
            items.add(items::Gate_Keys);
            break;
        case Requirement.Ordon_Pumpkin:
            items.add(items::Ordon_Pumpkin);
            break;
        case Requirement.Ordon_Goat_Cheese:
            items.add(items::Ordon_Goat_Cheese);
            break;
        case Requirement.Coro_Key:
            items.add(items::Coro_Key);
            break;
        case Requirement.can_free_all_monkeys:
            items.add(items::Clawshot);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Shield_Attack);
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Ball_and_Chain);
            items.add(items::Lantern);
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Forest_Temple_Small_Key);
            return items.add(items::Boomerang);
            break;
        case Requirement.can_smash:
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_burn_webs:
            items.add(items::Lantern);
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Ball_and_Chain):
            break;
        case Requirement.has_ranged_item:
            items.add(items::Slingshot);
            items.add(items::Heros_Bow);
            items.add(items::Clawshot);
            items.add(items::Boomerang);
            return item.add(items::Ball_and_Chain);
            break;
        case Requirement.has_sword:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.has_sheild:
            items.add(0x2A);
            items.add(0x2B);
            return items.add(0x2C);
            break;
        case Requirement.can_launch_bombs:
            items.add(items::Boomerang);
            items.add(items::Heros_Bow);
            return items.add(items::Goron_Bomb_Bag);
            break;

    /* Enemy Logic */
        case Requirement.can_defeat_aeralfos:
            items.add(items::Clawshot);
            items.add(items::Ball_and_Chain);
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Heros_Bow);
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Iron_Boots);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_armos:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_baba_serpent:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_baby_gohma:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_bari:
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_beamos:
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.can_defeat_big_baba:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_chu:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_bokoblin:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Slingshot);
            break;
        case Requirement.can_defeat_bombfish:
            items.add(items::Iron_Boots);
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(0x2A);
            items.add(0x2B);
            items.add(0x2C);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_bombling:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_bombskit:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(0x2A);
            items.add(0x2B);
            items.add(0x2C);
            items.add(items::Boomerang);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_bubble:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_bublin:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_chilfos:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_chu_worm:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Clawshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_darknut:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.can_defeat_deku_baba:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Shield_Attack);
            items.add(items::Slingshot);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_deku_like:
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal)
        case Requirement.can_defeat_dodongo:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_dinalfos:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_fire_bubble:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_fire_keese:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_fire_toadpoli:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_freezard:
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_defeat_goron:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Shield_Attack);
            items.add(items::Slingshot);
            items.add(items::Lantern);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_ghoul_rat:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_guay:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_helmasaur:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_helmasaurus:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_ice_bubble:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_ice_keese:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_poe:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_kargarok:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_keese:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_leever:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_lizalfos
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_mini_freezard:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_moldorm:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_poison_mite:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Lantern);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_puppet:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_rat:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_redead_knight:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_shadow_beast:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Shadow_Crystal);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.can_defeat_shadow_bublin:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_shadow_deku_baba:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Shield_Attack);
            items.add(items::Slingshot);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_shadow_insect:
            return items.add(items::Shadow_Crystal);
        case Requirement.can_defeat_shadow_kargarok:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_shadow_keese:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Slingshot);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_shadow_vermin:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_shell_blade:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Iron_Boots);
            break;
        case Requirement.can_defeat_skullfish:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_skulltula:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_stalfos:
            items.add(items::Ball_and_Chain);
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.can_defeat_stalhound:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_stalchild:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_tetike:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_tile_worm:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Boomerang);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_toado:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
        case Requirement.can_defeat_water_toadpoli:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_torch_slug:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_walltula:
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Boomerang);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_defeat_white_wolfos:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_young_gohma:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_zant_head:
            items.add(items::Shadow_Crystal);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Wooden_Sword);
            return items.add(items::Master_Sword_Light);
        case Requirement.can_defeat_ook:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_dangoro:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Iron_Boots);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_carrier_kargarok:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_twilit_bloat:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_deku_toad:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_skull_kid_1:
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_skull_kid_2:
            return items.add(items::Heros_Bow);
            break;
        case Requirement.can_defeat_king_bublin_2:
            return items.add(items::Heros_Bow);
            break;
        case Requirement.can_defeat_king_bublin_3:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_king_bublin_4:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_death_sword:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Boomerang);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_darkhammer:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_phantom_zant:
            items.add(items::Shadow_Crystal);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Wooden_Sword);
            return items.add(items::Master_Sword_Light);
        case Requirement.can_defeat_diababa:
            items.add(items::Boomerang);
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Heros_Bow);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Wooden_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_defeat_fyrus:
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Wooden_Sword);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.can_defeat_morpheel:
            items.add(items::Zora_Armor);
            items.add(items::Iron_Boots);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Wooden_Sword);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.can_defeat_stallord:
            items.add(items::Spinner);
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            return items.add(items::Master_Sword_Light);
            break;
        case Requirement.can_defeat_blizzeta:
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_defeat_armogohma:
            items.add(items::Heros_Bow);
            return items.add(items::Dominion_Rod);
            break;
        case Requirement.can_defeat_argorok:
            items.add(items::Double_Clawshot);
            items.add(items::Iron_Boots);
            items.add(items::Master_Sword_Light);
            return items.add(items::Master_Sword);
            break;
        case Requirement.can_defeat_zant:
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Boomerang);
            items.add(items::Clawshot);
            items.add(items::Iron_Boots);
            items.add(items::Zora_Armor);
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_defeat_ganondorf:
            items.add(items::Shadow_Crystal);
            items.add(items::Ending_Blow);
            return items.add(items::Master_Sword);
            break;
        case Requirement.can_cut_hanging_web:
            items.add(items::Heros_Bow);
            items.add(items::Clawshot);
            items.add(items::Ball_and_Chain);
            return items.add(items::Boomerang);
            break
        case Requirement.can_defeat_bombling_or_burn_webs:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Goron_Bomb_Bag);
            items.add(items::Lantern);
            return items.add(items::Shadow_Crystal);
            break
        case Requirement.can_press_mines_switch:
            items.add(items::Iron_Boots);
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_knock_down_hanging_baba:
            items.add(items::Heros_Bow);
            items.add(items::Clawshot);
            return items.add(items::Boomerang);
            break;
        case Requirement.can_beat_mines_or_clawshot:
            items.add(items::Iron_Boots);
            items.add(items::Heros_Bow);
            items.add(items::Clawshot);
            return items.add(items::Goron_Mines_Big_Key);
            break;
        case Requirement.can_break_wooden_door:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Shadow_Crystal);
            break;
        case Requirement.can_break_snowpeak_ruins_central_ice:
            items.add(items::Ball_and_Chain);
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.can_knock_down_hc_painting:
            items.add(items::Heros_Bow);
            return items.add(items::Goron_Bomb_Bag);
            break;
        case Requirement.clawshot_or_boomerang:
            items.add(items::Boomerang);
            return items.add(items::Clawshot);
            break;
        case Requirement.has_sword_and_irons_or_bow:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Iron_Boots);
            return items.add(items::Heros_Bow);
            break;
        case Requirement.can_free_second_monkey_or_clawshot:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            return items.add(items::Clawshot);
            break;
        case Requirement.can_break_monkey_cage:
            items.add(items::Wooden_Sword);
            items.add(items::Ordon_Sword);
            items.add(items::Master_Sword);
            items.add(items::Master_Sword_Light);
            items.add(items::Ball_and_Chain);
            items.add(items::Heros_Bow);
            items.add(items::Iron_Boots);
            items.add(items::Spinner);
            items.add(items::Shadow_Crystal);
            return items.add(items::Clawshot);
        case Requirement.clawshot_or_bow:
            items.add(items::Heros_Bow);
            return items.add(items::Clawshot);
            break;
        case Requirement.crystal_or_ball_and_chain:
            items.add(items::Shadow_Crystal);
            return items.add(items::Ball_and_Chain);
            break;
        case Requirement.can_access_darkhammer:
            items.add(items::Goron_Bomb_Bag);
            return items.add(items::Ball_and_Chain);
            break;
    }
}

//Check if held items match the given requirement
bool isRequirementMet(Requirement requirment)
{
    switch (requirments)
    {
        case Requirement.Lantern:
            return checkIfItemIsInList(items::Lantern,PlacedImportantItems);
            break;

        case Requirement.Ordon_Sword:
            return checkIfItemIsInList(items::Ordon_Sword,PlacedImportantItems);
            break;
        case Requirement.Master_Sword:
            return checkIfItemIsInList(items::Master_Sword,PlacedImportantItems);
            break;
        case Requirement.Zora_Armor:
            return checkIfItemIsInList(items::Zora_Armor,PlacedImportantItems);
            break;
        case Requirement.Shadow_Crystal:
            return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
            break;
        case Requirement.Big_Wallet:
            return checkIfItemIsInList(items::Big_Wallet,PlacedImportantItems);
            break;
        case Requirement.Giant_Wallet:
            return checkIfItemIsInList(items::Giant_Wallet,PlacedImportantItems);
            break;
        case Requirement.Coral_Earring:
            return (checkIfItemIsInList(items::Coral_Earring,PlacedImportantItems) && checkIfItemIsInList(items::Fishing_Rod,PlacedImportantItems));
            break;
        case Requirement.Wooden_Sword:
            return checkIfItemIsInList(items::Wooden_Sword,PlacedImportantItems);
            break;
        case Requirement.Boomerang:
            return checkIfItemIsInList(items::Boomerang,PlacedImportantItems);
            break;
        case Requirement.Spinner:
            return checkIfItemIsInList(items::Spinner,PlacedImportantItems);
            break;
        case Requirement.Ball_And_Chain:
            return checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems);
            break;
        case Requirement.Bow:
            return checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems);
            break;
        case Requirement.Clawshot:
            return checkIfItemIsInList(items::Clawshot,PlacedImportantItems);
            break;
        case Requirement.Iron_Boots:
            return checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems);
            break;
        case Requirement.Dominion_Rod:
            return checkIfItemIsInList(items::Dominion_Rod,PlacedImportantItems);
            break;
        case Requirement.Double_Clawshot:
            return (checkIfItemIsInList(items::Clawshot,PlacedImportantItems) && checkIfItemIsInList(items::Double_Clawshot,PlacedImportantItems));;
            break;
        case Requirement.Lantern:
            return checkIfItemIsInList(items::Lantern,PlacedImportantItems);
            break;
        case Requirement.Master_Sword_Light:
            return checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems);
            break;
        case Requirement.Fishing_Rod:
            return checkIfItemIsInList(items::Fishing_Rod,PlacedImportantItems);
            break;
        case Requirement.Slingshot:
            return checkIfItemIsInList(items::Slingshot,PlacedImportantItems);
            break;
        case Requirement.Dominion_Rod_Uncharged:
            return (checkIfItemIsInList(items::Dominion_Rod,PlacedImportantItems) && checkIfItemIsInList(items::Dominion_Rod_Uncharged,PlacedImportantItems));
            break;
        case Requirement.Bombs:
            return checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems);
            break;
        case Requirement.Water_Bombs:
            return checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems);
            break;
        case Requirement.Empty_Bottle:
            return checkIfItemIsInList(items::Empty_Bottle,PlacedImportantItems);
            break;
        case Requirement.Renardos_Letter:
            return checkIfItemIsInList(items::Renardos_Letter,PlacedImportantItems);
            break;
        case Requirement.Invoice:
            return checkIfItemIsInList(items::Invoice,PlacedImportantItems);
            break;
        case Requirement.Wooden_Statue:
            return checkIfItemIsInList(items::Wooden_Statue,PlacedImportantItems);
            break;
        case Requirement.Ilias_Charm:
            return checkIfItemIsInList(items::Ilias_Charm,PlacedImportantItems);
            break;
        case Requirement.Forest_Temple_Small_Key:
            return checkIfItemIsInList(items::Forest_Temple_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Goron_Mines_Small_Key:
            return checkIfItemIsInList(items::Goron_Mines_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Lakebed_Temple_Small_Key:
            return checkIfItemIsInList(items::Lakebed_Temple_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Arbiters_Grounds_Small_Key:
            return checkIfItemIsInList(items::Arbiters_Grounds_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Snowpeak_Ruins_Small_Key:
            return checkIfItemIsInList(items::Snowpeak_Ruins_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Temple_of_Time_Small_Key:
            return checkIfItemIsInList(items::Temple_of_Time_Small_Key,PlacedImportantItems);
            break;
        case Requirement.City_in_The_Sky_Small_Key:
            return checkIfItemIsInList(items::City_in_The_Sky_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Palace_of_Twilight_Small_Key:
            return checkIfItemIsInList(items::Palace_of_Twilight_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Hyrule_Castle_Small_Key:
            return checkIfItemIsInList(items::Hyrule_Castle_Small_Key,PlacedImportantItems);
            break;
        case Requirement.Aurus_Memo:
            return checkIfItemIsInList(items::Aurus_Memo,PlacedImportantItems);
            break;
        case Requirement.Asheis_Sketch:
            return checkIfItemIsInList(items::Asheis_Sketch,PlacedImportantItems);
            break;
        case Requirement.Forest_Temple_Big_Key:
            return checkIfItemIsInList(items::Forest_Temple_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Goron_Mines_Big_Key:
            return (checkIfItemIsInList(items::Goron_Mines_Big_Key,PlacedImportantItems) && 
            checkIfItemIsInList(items::Goron_Mines_Key_Shard_1,PlacedImportantItems) 
            && checkIfItemIsInList(items::Goron_Mines_Key_Shard_2,PlacedImportantItems));
            break;
        case Requirement.Lakebed_Temple_Big_Key:
            return checkIfItemIsInList(items::Lakebed_Temple_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Arbiters_Grounds_Big_Key:
            return checkIfItemIsInList(items::Arbiters_Grounds_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Snowpeak_Ruins_Bedroom_Key:
            return checkIfItemIsInList(items::Snowpeak_Ruins_Bedroom_Key,PlacedImportantItems);
            break;
        case Requirement.Temple_of_Time_Big_Key:
            return checkIfItemIsInList(items::Temple_of_Time_Big_Key,PlacedImportantItems);
            break;
        case Requirement.City_in_The_Sky_Big_Key:
            return checkIfItemIsInList(items::City_in_The_Sky_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Palace_of_Twilight_Big_Key:
            return checkIfItemIsInList(items::Palace_of_Twilight_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Hyrule_Castle_Big_Key:
            return checkIfItemIsInList(items::Hyrule_Castle_Big_Key,PlacedImportantItems);
            break;
        case Requirement.Faron_Vessel_of_Light:
            return checkIfItemIsInList(items::Faron_Vessel_of_Light,PlacedImportantItems);
            break;
        case Requirement.Eldin_Vessel_of_Light:
            return checkIfItemIsInList(items::Eldin_Vessel_of_Light,PlacedImportantItems);
            break;
        case Requirement.Lanayru_Vessel_of_Light:
            return checkIfItemIsInList(items::Lanayru_Vessel_of_Light,PlacedImportantItems);
            break;
        case Requirement.Ilias_Scent:
            return checkIfItemIsInList(items::Ilias_Scent,PlacedImportantItems);
            break;
        case Requirement.Poe_Scent:
            return checkIfItemIsInList(items::Poe_Scent,PlacedImportantItems);
            break;
        case Requirement.Reekfish_Scent:
            return checkIfItemIsInList(items::Reekfish_Scent,PlacedImportantItems);
            break;
        case Requirement.Youths_Scent:
            return checkIfItemIsInList(items::Youths_Scent,PlacedImportantItems);
            break;
        case Requirement.Medicine_Scent
            return checkIfItemIsInList(items::Medicine_Scent,PlacedImportantItems);
            break;
        case Requirement.Ancient_Sky_Book_Empty:
            return checkIfItemIsInList(items::Ancient_Sky_Book_Empty,PlacedImportantItems);
            break;
        case Requirement.Ancient_Sky_Book_Completed:
            return (checkIfItemIsInList(items::Ancient_Sky_Book_Completed,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_Empty,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_First_Character,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_Second_Character,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_Third_Character,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_Fourth_Character,PlacedImportantItems) &&
            checkIfItemIsInList(items::Ancient_Sky_Book_Fifth_Character,PlacedImportantItems));
        case Requirement.Small_Key_N_Faron_Gate:
            return checkIfItemIsInList(items::Small_Key_N_Faron_Gate,PlacedImportantItems);
            break;
        case Requirement.Gate_Keys:
            checkIfItemIsInList(items::Gate_Keys,PlacedImportantItems);
            break;
        case Requirement.Ordon_Pumpkin:
            checkIfItemIsInList(items::Ordon_Pumpkin,PlacedImportantItems);
            break;
        case Requirement.Ordon_Goat_Cheese:
            checkIfItemIsInList(items::Ordon_Goat_Cheese,PlacedImportantItems);
            break;
        case Requirement.Coro_Key:
            checkIfItemIsInList(items::Coro_Key,PlacedImportantItems);
            break;
        case Requirement.can_free_all_monkeys:
            return ((checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shield_Attack,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            hasSword()) &&
            (forestTempleSmallKeyCount >= 4) &&
            checkIfItemIsInList(items::Lantern,PlacedImportantItems)
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
            break;
        case Requirement.can_smash:
            
            return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
            break;
        case Requirement.can_burn_webs:
            return (checkIfItemIsInList(items::Ball_and_Chain) ||
            checkIfItemIsInList(items::Lantern,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
            break;
        case Requirement.has_ranged_item:
            return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
            break;
        case Requirement.has_sword:
            return hasSword();
            break;
        case Requirement.has_sheild:
            return (checkIfItemIsInList(0x2A,PlacedImportantItems) ||
            checkIfItemIsInList(0x2B,PlacedImportantItems) ||
            checkIfItemIsInList(0x2C,PlacedImportantItems));
            break;
        case Requirement.can_launch_bombs:
            return ((checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems)) &&
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
            break;

        /* Enemy Logic */
        case Requirement.can_defeat_aeralfos:
            return canDefeatAeralfos();
            break;
        case Requirement.can_defeat_armos:
            return canDefeatArmos();
            break;
        case Requirement.can_defeat_baba_serpent:
            return canDefeatBabaSerpent();
            break;
        case Requirement.can_defeat_baby_gohma:
            return canDefeatBabyGohma();
            break;
        case Requirement.can_defeat_bari:
            return canDefeatBari();
            break;
        case Requirement.can_defeat_beamos:
            return canDefeatBeamos();
            break;
        case Requirement.can_defeat_big_baba:
            return canDefeatBigBaba();
            break;
        case Requirement.can_defeat_chu:
            return canDefeatChu();
            break;
        case Requirement.can_defeat_bokoblin:
            return canDefeatBokoblin();
            break;
        case Requirement.can_defeat_bombfish:
            return canDefeatBombfish();
            break;
        case Requirement.can_defeat_bombling:
            return canDefeatBombling();
            break;
        case Requirement.can_defeat_bombskit:
            return canDefeatBombskit();
            break;
        case Requirement.can_defeat_bubble:
            return canDefeatBubble();
            break;
        case Requirement.can_defeat_bublin:
            return canDefeatBublin();
            break;
        case Requirement.can_defeat_chilfos:
            return canDefeatChilfos();
            break;
        case Requirement.can_defeat_chu_worm:
            return canDefeatChuWorm();            
            break;
        case Requirement.can_defeat_darknut:
            return canDefeatDarknut();
            break;
        case Requirement.can_defeat_deku_baba:
            return canDefeatDekuBaba();
            break;
        case Requirement.can_defeat_deku_like:
            return canDefeatDekuLike();
            break;
        case Requirement.can_defeat_dodongo:
            return canDefeatDodongo();
            break;
        case Requirement.can_defeat_dinalfos:
            return canDefeat_Dinalfos();
            break;
        case Requirement.can_defeat_fire_bubble:
            return canDefeatFireBubble();
            break;
        case Requirement.can_defeat_fire_keese:
            return canDefeatFireKeese();
            break;
        case Requirement.can_defeat_fire_toadpoli:
            return canDefeatFireToadpoli();
            break;
        case Requirement.can_defeat_freezard:
            return canDefeatFreezard();
            break;
        case Requirement.can_defeat_goron:
            return canDefeatGoron();
            break;
        case Requirement.can_defeat_ghoul_rat:
            return canDefeatGhoulRat();
            break;
        case Requirement.can_defeat_guay:
            return canDefeatGuay();
            break;
        case Requirement.can_defeat_helmasaur:
            return canDefeatHelmasaur();
            break;
        case Requirement.can_defeat_helmasaurus:
            return canDefeatHelmasaurus();
            break;
        case Requirement.can_defeat_ice_bubble:
            return canDefeatIceBubble();
            break;
        case Requirement.can_defeat_ice_keese:
            return canDefeatIceKeese();
            break;
        case Requirement.can_defeat_poe:
            return canDefeatPoe();
            break;
        case Requirement.can_defeat_kargarok:
            return canDefeatKargarok();
            break;
        case Requirement.can_defeat_keese:
            return canDefeatKeese();
            break;
        case Requirement.can_defeat_leever:
            return canDefeatLeever();
            break;
        case Requirement.can_defeat_lizalfos
            return canDefeatLizalfos();
            break;
        case Requirement.can_defeat_mini_freezard:
            return canDefeatMiniFreezard();
            break;
        case Requirement.can_defeat_moldorm:
            return canDefeatMoldorm();
            break;
        case Requirement.can_defeat_poison_mite:
            return canDefeatPoisonMite();
            break;
        case Requirement.can_defeat_puppet:
            return canDefeatPuppet();
            break;
        case Requirement.can_defeat_rat:
            return canDefeatRat();
            break;
        case Requirement.can_defeat_redead_knight:
            return canDefeatRedeadKnight();
            break;
        case Requirement.can_defeat_shadow_beast:
            return canDefeatShadowBeast();
            break;
        case Requirement.can_defeat_shadow_bublin:
            return canDefeatShadowBublin();
            break;
        case Requirement.can_defeat_shadow_deku_baba:
            return canDefeatShadowDekuBaba();
            break;
        case Requirement.can_defeat_shadow_insect:
            return canDefeatShadowInsect();
        case Requirement.can_defeat_shadow_kargarok:
            return canDefeatShadowKargarok();
            break;
        case Requirement.can_defeat_shadow_keese:
            return canDefeatShadowKeese();
            break;
        case Requirement.can_defeat_shadow_vermin:
            return canDefeatShadowVermin();
            break;
        case Requirement.can_defeat_shell_blade:
            return canDefeatShellBlade();
            break;
        case Requirement.can_defeat_skullfish:
            return canDefeatSkullfish();
            break;
        case Requirement.can_defeat_skulltula:
            return canDefeatSkulltula();
            break;
        case Requirement.can_defeat_stalfos:
            return canDefeatStalfos();
            break;
        case Requirement.can_defeat_stalhound:
            return canDefeatStalhound();
            break;
        case Requirement.can_defeat_stalchild:
            return canDefeatStalchild();
            break;
        case Requirement.can_defeat_tetike:
            return canDefeatTetike();
            break;
        case Requirement.can_defeat_tile_worm:
            return canDefeatTileWorm();
            break;
        case Requirement.can_defeat_toado:
            return canDefeatToado();
            break;
        case Requirement.can_defeat_water_toadpoli:
            return canDefeatWaterToadpoli();
            break;
        case Requirement.can_defeat_torch_slug:
            return canDefeatTorchSlug();
            break;
        case Requirement.can_defeat_walltula:
            return canDefeatWalltula();
            break;
        case Requirement.can_defeat_white_wolfos:
            return canDefeatWhiteWolfos();
            break;
        case Requirement.can_defeat_young_gohma:
            return canDefeatYoungGohma();
            break;
        case Requirement.can_defeat_zant_head:
            return canDefeatZantHead();
            break;
        case Requirement.can_defeat_ook:
            return canDefeatOok();
            break;
        case Requirement.can_defeat_dangoro:
            return canDefeatDangoro();
            break;
        case Requirement.can_defeat_carrier_kargarok:
            return canDefeatCarrierKargarok();
            break;
        case Requirement.can_defeat_twilit_bloat:
            return canDefeatTwilitBloat();
            break;
        case Requirement.can_defeat_deku_toad:
            return canDefeatDekuToad();
            break;
        case Requirement.can_defeat_skull_kid_1:
            return canDefeatSkullKid1();
            break;
        case Requirement.can_defeat_skull_kid_2:
            return canDefeatSkullKid2();
            break;
        case Requirement.can_defeat_king_bublin_2:
            return canDefeatKingBublin2();
            break;
        case Requirement.can_defeat_king_bublin_3:
            return canDefeatKingBublin3();
            break;
        case Requirement.can_defeat_king_bublin_4:
            return canDefeatKingBublin4();
            break;
        case Requirement.can_defeat_death_sword:
            return canDefeatDeathSword();
            break;
        case Requirement.can_defeat_darkhammer:
            return canDefeatDarkhammer();
            break;
        case Requirement.can_defeat_phantom_zant:
            return canDefeatPhantomZant();
            break;
        case Requirement.can_defeat_diababa:
            return canDefeatDiababa();
            break;
        case Requirement.can_defeat_fyrus:
            return canDefeatFyrus();
            break;
        case Requirement.can_defeat_morpheel:
            return canDefeatMorpheel();
            break;
        case Requirement.can_defeat_stallord:
            return canDefeatStallord();
            break;
        case Requirement.can_defeat_blizzeta:
            return canDefeatBlizzeta();
            break;
        case Requirement.can_defeat_armogohma:
            return canDefeatArmogohma();
            break;
        case Requirement.can_defeat_argorok:
            return canDefeatArgorok();
            break;
        case Requirement.can_defeat_zant:
            return canDefeatZant();
            break;
        case Requirement.can_defeat_ganondorf:
            return canDefeatGanondorf();
            break;
        
        case Requirement.can_cut_hanging_web:
            return (checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems));
            break
        case Requirement.can_defeat_bombling_or_burn_webs:
            return (canDefeatBombling() || canBurnWebs());
            break;
        case Requirement.can_press_mines_switch:
            return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems));
            break;
        case Requirement.can_knock_down_hanging_baba:
            return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
            break;
        case Requirement.can_beat_mines_or_clawshot:
            return (checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
            ((checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) &&
            hasSword()) || 
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems)));
            break;
        case Requirement.can_break_wooden_door:
            return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
            hasSword() ||
            (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems)));
            break;
        case Requirement.can_break_snowpeak_ruins_central_ice:
            return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) &&
            (snowpeakRuinsSmallKeyCount >=4)));
            break;
        case Requirement.can_knock_down_hc_painting:
            return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
            break;
        case Requirement.clawshot_or_boomerang:
            return (checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
            break;
        case Requirement.has_sword_and_irons_or_bow:
            return ((hasSword() &&
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems)) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems));
            break;
        case Requirement.can_free_second_monkey_or_clawshot:
            return (((hasSword() ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) &&
            (forestTempleSmallKeyCount >= 4)) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
            break;
        case Requirement.can_break_monkey_cage:
            return (hasSword() ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
            break;
        case Requirement.clawshot_or_bow:
            return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
            break;
        case Requirement.crystal_or_ball_and_chain:
            return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems));
            break;
        case Requirement.can_access_darkhammer:
            return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) &&
            (snowpeakRuinsSmallKeyCount >= 4)));
            break;

        case Requirement.forest_temple_1_small_key:
            return (forestTempleSmallKeyCount >= 1);
            break;
        case Requirement.forest_temple_2_small_keys:
            return (forestTempleSmallKeyCount >= 2);
            break;
        case Requirement.forest_temple_3_small_keys:
            return (forestTempleSmallKeyCount >= 3);
            break;
        case Requirement.forest_temple_4_small_keys:
            return (forestTempleSmallKeyCount >= 4);
            break;

        case Requirement.goron_mines_1_small_key:
            return (goronMinesSmallKeyCount >= 1);
            break;
        case Requirement.goron_mines_2_small_keys:
            return (goronMinesSmallKeyCount >= 2);
            break;
        case Requirement.goron_mines_3_small_keys:
            return (goronMinesSmallKeyCount >= 3);
            break;

        case Requirement.lakebed_temple_1_small_key:
            return (lakebedTempleSmallKeyCount >= 1);
            break;    
        case Requirement.lakebed_temple_2_small_keys:
            return (lakebedTempleSmallKeyCount >= 2);
            break;
        case Requirement.lakebed_temple_3_small_keys:
            return (lakebedTempleSmallKeyCount >= 3);
            break;
        case Requirement.arbiters_grounds_1_small_key:
            return (arbitersGroundsSmallKeyCount >= 1);
            break;
        case Requirement.arbiters_grounds_2_small_keys:
            return (arbitersGroundsSmallKeyCount >= 2);
            break;
        case Requirement.arbiters_grounds_3_small_keys:
            return (arbitersGroundsSmallKeyCount >= 3);
            break;
        case Requirement.arbiters_grounds_4_small_keys:
            return (arbitersGroundsSmallKeyCount >= 4);
            break;
        case Requirement.arbiters_grounds_5_small_keys:
            return (arbitersGroundsSmallKeyCount >= 5);
            break;
        case Requirement.snowpeak_ruins_3_small_keys:
            return (snowpeakRuinsSmallKeyCount >= 3);
            break;
        case Requirement.snowpeak_ruins_4_small_keys:
            return (snowpeakRuinsSmallKeyCount >= 4);
            break;
        
        case Requirement.temple_of_time_1_small_key:
            return (templeofTimeSmallKeyCount >= 1);
            break; 
        case Requirement.temple_of_time_2_small_keys:
            return (templeofTimeSmallKeyCount >= 2);
            break; 
        case Requirement.temple_of_time_3_small_keys:
            return (templeofTimeSmallKeyCount >= 3);
            break; 

        case Requirement.city_in_the_sky_1_small_key:
            return (cityinTheSkySmallKeyCount >= 1);
            break; 

        case Requirement.palace_of_twilight_1_small_key:
            return (palaceofTwilightSmallKeyCount >= 1);
            break;
        case Requirement.palace_of_twilight_2_small_keys:
            return (palaceofTwilightSmallKeyCount >= 2);
            break;
        case Requirement.palace_of_twilight_3_small_keys:
            return (palaceofTwilightSmallKeyCount >= 3);
            break;
        case Requirement.palace_of_twilight_4_small_keys:
            return (palaceofTwilightSmallKeyCount >= 4);
            break;
        case Requirement.palace_of_twilight_5_small_keys:
            return (palaceofTwilightSmallKeyCount >= 5);
            break;
        case Requirement.palace_of_twilight_6_small_keys:
            return (palaceofTwilightSmallKeyCount >= 6);
            break;
        case Requirement.palace_of_twilight_7_small_keys:
            return (palaceofTwilightSmallKeyCount >= 7);
            break;

        case Requirement.hyrule_castle_1_small_key:
            return (hyruleCastleSmallKeyCount >= 1);
            break;
        case Requirement.hyrule_castle_2_small_keys:
            return (hyruleCastleSmallKeyCount >= 2);
            break;
        case Requirement.hyrule_castle_3_small_keys:
            return (hyruleCastleSmallKeyCount >= 3);
            break;
        
        case Requirement.fused_shadow_count_1:
            return (fusedShadowCount >= 1);
            break;
        case Requirement.fused_shadow_count_2:
            return (fusedShadowCount >= 2);
            break;
        case Requirement.fused_shadow_count_3:
            return (fusedShadowCount >= 3);
            break;
        
        case Requirement.mirror_shard_count_1:
            return (mirrorShardCount >= 1);
            break;
        case Requirement.mirror_shard_count_2:
            return (mirrorShardCount >= 2);
            break;
        case Requirement.mirror_shard_count_3:
            return (mirrorShardCount >= 3);
            break;
        case Requirement.mirror_shard_count_4:
            return (mirrorShardCount >= 4);
            break;
        case Requirement.mdh_complete:
            return (mdhComplete == true);
            break;
        case Requirement.diababa_defeated:
            return (diababaDefeated == true);
            break;
        case Requirement.fyrus_defeated:
            return (fyrusDefeated == true);
            break;
        case Requirement.morpheel_defeated:
            return (morpheelDefeated == true);
            break;
        case Requirement.stallord_defeated:
            return (stallordDefeated == true);
            break;
        case Requirement.blizzeta_defeated:
            return (blizzetaDefeated == true);
            break;
        case Requirement.armogohma_defeated:
            return (armogohmaDefeated == true);
            break;
        case Requirement.argorok_defeated:
            return (argorokDefeated == true);
            break;
        case Requirement.zant_defeated:
            return (zantDefeated == true);
            break;
        case Requirement.ganondorf_defeated:
            return (ganondorfDefeated == true);
            break;
        
    }
}


/* Other functions to be defined just to make the requirements cleaner*/
bool hasSword()
{
    return  (checkIfItemIsInList(items::Wooden_Sword,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ordon_Sword,PlacedImportantItems) ||
            checkIfItemIsInList(items::Master_Sword,PlacedImportantItems) ||
            checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems));
}

bool canDefeatAeralfos()
{
    return (checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            hasSword() ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatArmos()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatBabaSerpent()
{
    return (hasSword()
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatBabyGohma()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatBari()
{
    return (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatBeamos()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
}
bool canDefeatBigBaba()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatChu()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatBokoblin()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems));
}
bool canDefeatBombfish()
{
    return (checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    (hasSword() ||
    checkIfItemIsInList(0x2A,PlacedImportantItems) ||
    checkIfItemIsInList(0x2B,PlacedImportantItems) ||
    checkIfItemIsInList(0x2C,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems)));
}
bool canDefeatBombling()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatBombskit()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatBubble()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatBublin()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatChilfos()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatChuWorm()
{
    return ((hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) &&
    (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems)));
    
}
bool canDefeatDarknut()
{
    return hasSword();
}
bool canDefeatDekuBaba()
{
    return (hasSword();
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shield_Attack,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatDekuLike()
{    
    return (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
    hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal));
}
bool canDefeatDodongo()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatDinalfos:
{
    return (hasSword()
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatFireBubble()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatFireKeese()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatFireToadpoli()
{
    return (checkIfItemIsInList(items::Wooden_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ordon_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatFreezard()
{
    return checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems);
}
bool canDefeatGoron()
{
    return (checkIfItemIsInList(items::Wooden_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ordon_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shield_Attack,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Lantern,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatGhoulRat()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
}
bool canDefeatGuay()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatHelmasaur()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatHelmasaurus()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatIceBubble()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatIceKeese()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatPoe()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
}
bool canDefeatKargarok()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatKeese()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
}
bool canDefeatLeever()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatLizalfos()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatMiniFreezard()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatMoldorm()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatPoisonMite()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Lantern,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatPuppet()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatRat()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatRedeadKnight()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShadowBeast()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShadowBublin()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShadowDekuBaba()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shield_Attack,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
    }
bool canDefeatShadowInsect()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
}
bool canDefeatShadowKargarok()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShadowKeese()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShadowVermin()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatShellBlade()
{
    return ((hasSword() ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems)) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems));
    }
bool canDefeatSkullfish()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatSkulltula()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatStalfos()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
    }
bool canDefeatStalhound()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatStalchild()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatTetike()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatTileWorm()
{
    return ((hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) &&
    checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
    }
bool canDefeatToado()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatWaterToadpoli()
{
    return (hasSword() || 
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatTorchSlug()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatWalltula()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
    checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
}
bool canDefeatWhiteWolfos()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatYoungGohma()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatZantHead()
{
    return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
    hasSword());
}
bool canDefeatOok()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatDangoro()
{
    return ((hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems));
    }
bool canDefeatCarrierKargarok()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
    }
bool canDefeatTwilitBloat()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
    }
bool canDefeatDekuToad()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatSkullKid1()
{
    return checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
    }
bool canDefeatSkullKid2()
{
    return checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems);
    }
bool canDefeatKingBublin2()
{
    return checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems);
    }
bool canDefeatKingBublin3()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatKingBublin4()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatDeathSword()
{
    return ((hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems)) &&
    (checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems)) &&
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatDarkhammer()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatPhantomZant()
{
    return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems);
    hasSword());
}
bool canDefeatDiababa()
{
    return ((checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) &&
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems))) &&
    hasSword() ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems));
    }
bool canDefeatFyrus()
{
    return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    hasSword());
    }
bool canDefeatMorpheel()
{
    return (checkIfItemIsInList(items::Zora_Armor,PlacedImportantItems) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    hasSword());
    }
bool canDefeatStallord()
{
    return (checkIfItemIsInList(items::Spinner,PlacedImportantItems) &&
    hasSword());
    }
bool canDefeatBlizzeta()
{
    return checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems);
    }
bool canDefeatArmogohma()
{
    return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) &&
    checkIfItemIsInList(items::Dominion_Rod,PlacedImportantItems));
}
bool canDefeatArgorok()
{
    return (checkIfItemIsInList(items::Double_Clawshot,PlacedImportantItems) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    (checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword,PlacedImportantItems)));
    }
bool canDefeatZant()
{
    return ((checkIfItemIsInList(items::Master_Sword,PlacedImportantItems) ||
    checkIfItemIsInList(items::Master_Sword_Light,PlacedImportantItems)) &&
    (checkIfItemIsInList(items::Boomerang,PlacedImportantItems) &&
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems) &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    checkIfItemIsInList(items::Zora_Armor,PlacedImportantItems) &&
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems)));
    }
bool canDefeatGanondorf()
{
    return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) &&
    checkIfItemIsInList(items::Master_Sword,PlacedImportantItems) &&
    checkIfItemIsInList(0xE1,PlacedImportantItems));
    }

bool canFreeAllMonkeys()
{
            return ((checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shield_Attack,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            hasSword()) &&
            (forestTempleSmallKeyCount >= 4) &&
            checkIfItemIsInList(items::Lantern,PlacedImportantItems) &&
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
}

bool canSmash()
{
        return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
        checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
}

bool canBurnWebs()
{
    return (checkIfItemIsInList(items::Ball_and_Chain) ||
    checkIfItemIsInList(items::Lantern,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
    }

bool hasRangedItem()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Slingshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
    }

bool hasSheild()
{
    return (checkIfItemIsInList(0x2A,PlacedImportantItems) ||
    checkIfItemIsInList(0x2B,PlacedImportantItems) ||
    checkIfItemIsInList(0x2C,PlacedImportantItems));
    }
bool canLaunchBombs()
{
    return ((checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems)) &&
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
    }

bool canCutHangingWeb()
{
    return (checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems));
}

bool canDefeatBomblingOrBurnWebs()
{
    return (canDefeatBombling() || canBurnWebs());
    }

bool canPressMinesSwitch()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems));
    }
bool canKnockDownHangingBaba()
{
    return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
    checkIfItemIsInList(items::Boomerang,PlacedImportantItems));
    }

bool canBeatMinesOrClawshot()
{
    return (checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) &&
    ((checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) &&
    hasSword()) || 
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems)));
    }

bool canBreakWoodenDoor()
{
    return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
    hasSword() ||
    (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems)));
    }
bool canBreakSnowpeakRuinsCentralIce()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) &&
    (snowpeakRuinsSmallKeyCount >=4)));
    }

bool canKnockDownHCPainting()
{
    return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems));
    }

bool clawshotOrBoomerang()
{
    return (checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
    }

bool hasSwordAndIronsOrBow()
{
    return ((hasSword() &&
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems)) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems));
    }

bool canFreeSecondMonkeyOrClawshot()
{
    return (((hasSword() ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) &&
    (forestTempleSmallKeyCount >= 4)) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
    }

bool canBreakMonkeyCage()
{
    return (hasSword() ||
    checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
    checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
    checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
    }
bool clawshotOrBow()
{
    return (checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
    checkIfItemIsInList(items::Clawshot,PlacedImportantItems));
    }

bool crystalOrBallAndChain()
{
    return (checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems) ||
    checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems));
    }

bool canAccessDarkhammer()
{
    return (checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
    (checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems) &&
    (snowpeakRuinsSmallKeyCount >= 4)));
    }