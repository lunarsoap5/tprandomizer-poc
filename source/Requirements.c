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
    Gift_From_Rusl,
    South_Faron_Cave_Chest,
    North_Faron_Cave_Open_Chest,
    North_Faron_Cave_Lantern_Chest,
    North_Faron_Woods_Deku_Baba_Chest,
    Links_Basement_Chest,
    FT_Entrance_Vine_Chest,
    FT_Central_Chest_Behind_Stairs,
    FT_Central_North_Chest,
    FT_Windless_Bridge_Chest,
    FT_Second_Monkey_Under_Bridge_Chest,
    FT_Totem_Pole_Chest,
    FT_West_Tile_Worm_Vines_Chest,
    FT_West_Deku_Like_Chest,
    FT_West_Tile_Worm_Chest_Behind_Stairs,
    FT_Central_Chest_Hanging_From_Web,
    FT_Big_Key_Chest,
    FT_East_Water_Cave_Chest,
    FT_North_Deku_Like_Chest,
    FT_East_Tile_Worm_Chest,
    Kakariko_Inn_Ches,
    Wrestling_With_Bo,
    GM_Entrance_Chest,
    GM_Main_Magnet_Room_Bottom_Chest,
    GM_Gor_Amato_Chest,
    GM_Gor_Amato_Small_Chest,
    GM_Magnet_Maze_Chest,
    GM_Crystal_Switch_Room_Underwater_Chest,
    GM_Crystal_Switch_Room_Small_Chest,
    GM_After_Crystal_Switch_Room_Magnet_Wall_Chest,
    GM_Outside_Beamos_Chest,
    GM_Gor_Ebizo_Chest,
    GM_Chest_Before_Dangoro,
    GM_Dangoro_Chest,
    GM_Beamos_Room_Chest,
    GM_Gor_Liggs_Chest,
    GM_Main_Magnet_Room_Top_Chest,
    GM_Outside_Underwater_Chest,
    Eldin_Spring_Underwater_Chest,
    Kakariko_Graveyard_Lantern_Chest,
    Kakariko_Watchtower_Chest,
    Kakariko_Watchtower_Alcove_Chest,
    Eldin_Field_Bomb_Rock_Chest,
    ZD_Chest_By_Mother_and_Child_Isles,
    ZD_Chest_Behind_Waterfall,
    Lake_Hylia_Underwater_Chest,
    LBT_Lobby_Left_Chest,
    LBT_Lobby_Rear_Chest,
    LBT_Stalactite_Room_Chest,
    LBT_Central_Room_Small_Chest,
    LBT_Central_Room_Chest,
    LBT_East_Lower_Waterwheel_Stalactite_Chest,
    LBT_East_Second_Floor_Southwest_Chest,
    LBT_East_Second_Floor_Southeast_Chest,
    LBT_East_Water_Supply_Small_Chest,
    LBT_Before_Deku_Toad_Chest,
    LBT_Before_Deku_Toad_Underwater_Left_Chest,
    LBT_Before_Deku_Toad_Underwater_Right_Chest,
    LBT_Deku_Toad_Chest,
    LBT_Chandelier_Chest,
    LBT_East_Water_Supply_Clawshot_Chest,
    LBT_Central_Room_Center_Spire_Chest,
    LBT_West_Lower_Small_Chest,
    LBT_West_Water_Supply_Small_Chest,
    LBT_West_Water_Supply_Small_Chest,
    LBT_West_Second_Floor_Southwest_Underwater_Chest,
    LBT_West_Second_Floor_Central_Small_Chest,
    LBT_West_Second_Floor_Northeast_Chest,
    LBT_West_Second_Floor_Southeast_Chest,
    LBT_Big_Key_Chest,
    LBT_Underwater_Maze_Small_Chest,
    LBT_East_Stalactite_Bridge_Chest,
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
    Flight_By_Fowl_Top_Platform,
    Flight_By_Fowl_2nd_Level,
    Flight_By_Fowl_3rd_Level,
    Flight_By_Fowl_4th_Level,
    Flight_By_Fowl_5th_Level,
    Lake_Hylia_Shell_Blade_Grotto_Chest,
    ZD_Light_All_Torches,
    ZD_Extinguish_All_Torches,
    Lanayru_Field_Skulltula_Grotto_Chest,
    Lanayru_Field_Behind_Gate_Underwater_Chest,
    Lake_Hylia_Bridge_Vines_Chest,
    Lake_Hylia_Bridge_Bubble_Grotto_Chest,
    Lake_Hylia_Bridge_Cliff_Chest,
    Faron_Field_Bridge_Chest,
    Faron_Field_Corner_Grotto_Right_Chest,
    Faron_Field_Corner_Grotto_Rear_Chest,
    Faron_Field_Corner_Grotto_Left_Chest,
    Death_Mountain_Alcove_Heart_Piece_Chest,
    GM_Outside_Clawshot_Chest,
    Eldin_Lantern_Cave_First_Chest,
    Eldin_Lantern_Cave_Heart_Piece_Chest,
    Eldin_Lantern_Cave_Second_Chest,
    South_Castle_Field_Tightrope_Chest,
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
    Gerudo_Desert_Campfire_north_Chest,
    Gerudo_Desert_Campfire_east_Chest,
    Gerudo_Desert_Campfire_west_Chest,
    Gerudo_Desert_Northwest_Chest_Behind_Gates,
    North_Small_Chest_before_Bublin_Camp,
    Bublin_Camp_First_Chest_under_Tower_at_Entrance,
    Bublin_Camp_Small_Chest_In_Back_of_Camp,
    Outside_AG_Chest,
    AG_Lobby_Chest,
    AG_East_Lower_Turnable_Redead_Chest,
    AG_Torch_Room_East_Chest,
    AG_Torch_Room_West_Chest,
    AG_East_Upper_Turnable_Chest,
    AG_East_Upper_Turnable_Redead_Chest,
    AG_Ghoul_Rat_Room_Chest,
    AG_West_Small_Chest_Behind_Block,
    AG_West_Chandelier_Chest,
    AG_West_Stalfos_North_Chest,
    AG_West_Stalfos_Southeast_Small_Chest,
    AG_North_Turning_Room_Chest,
    Spinner_Chest,
    AG_Spinner_Room_First_Small_Chest,
    AG_Spinner_Room_Second_Small_Chest,
    AG_Spinner_Room_Lower_Central_Small_Chest,
    AG_Spinner_Room_Stalfos_Alcove_Chest,
    AG_Spinner_Room_Lower_North_Chest,
    AG_Big_Key_Chest,
    Lanayru_Field_Spinner_Track_Chest,
    Lanayru_Field_Stalfos_Grotto_Right_Small_Chest,
    Lanayru_Field_Stalfos_Grotto_Left_Small_Chest,
    Lanayru_Field_Stalfos_Grotto_Stalfos_Chest,
    Outside_South_Castle_Town_Fountain_Chest,
    Ordon_Ranch_Grotto_Lantern_Chest,
    Faron_Mist_Stump_Chest,
    Faron_Mist_North_Chest,
    Faron_Mist_South_Chest,
    SPR_West_Courtyard_Buried_Chest,
    SPR_East_Courtyard_Buried_Chest,
    SPR_Ordon_Pumpkin_Chest,
    SPR_East_Courtyard_Chest,
    SPR_Wooden_Beam_Central_Chest,
    SPR_Wooden_Beam_Northwest_Chest,
    SPR_Courtyard_Central_Chest,
    SPR_Chest_After_Darkhammer,
    SPR_Broken_Floor_Chest,
    SPR_Wooden_Beam_Chandelier_Chest,
    SPR_Lobby_Chandelier_Chest,
    SPR_Lobby_West_Armor_Chest,
    SPR_Lobby_East_Armor_Chest,
    SPR_Northeast_Chandelier_Chest,
    SPR_West_Cannon_Room_Central_Chest,
    SPR_West_Cannon_Room_Corner_Chest,
    SPR_Chapel_Chest,
    Snowpeak_Cave_Ice_Lantern_Chest,
    Snowpeak_Freezard_Grotto_Chest,
    Lanayru_Ice_Block_Puzzle_Cave_Chest,
    Lost_Woods_Lantern_Chest,
    Sacred_Grove_Spinner_Chest,
    ToT_Lobby_Lantern_Chest,
    ToT_First_Staircase_Gohma_Gate_Chest,
    ToT_First_Staircase_Window_Chest,
    ToT_First_Staircase_Armos_Chest,
    ToT_Statue_Throws_Room_East_Chest,
    ToT_Moving_Wall_Beamos_Room_Chest,
    ToT_Scales_Gohma_Chest,
    ToT_Gilloutine_Chest,
    ToT_Chest_Before_Midboss,
    ToT_Darknut_Chest,
    ToT_Scales_Upper_Chest,
    ToT_BK_Room_Upper_Chest,
    ToT_Big_Key_Chest,
    ToT_Moving_Wall_Dinalfos_Room_Chest,
    ToT_Armos_Room_North_Chest,
    ToT_Armos_Room_Statue_Chest,
    Sacred_Grove_Past_Owl_Statue_Heart_Piece_Chest,
    Doctors_Office_Balcony_Chest,
    Bridge_of_Eldin_Owl_Statue_Chest,
    Kakariko_Gorge_Owl_Statue_Chest,
    Hyrule_Field_Ampitheater_Owl_Statue_Chest,
    Lake_Hylia_Bridge_Owl_Statue_Chest,
    Faron_Woods_Owl_Statue_Chest,
    Gerudo_Desert_Owl_Statue_Chest,
    CiTS_Underwater_West_Chest,
    CiTS_Underwater_East_Chest,
    CiTS_West_Wing_First_Chest,
    CiTS_East_First_Wing_Chest_After_Fans,
    CiTS_Tile_Worm_Small_Chest,
    CiTS_East_Wing_after_Dinalfos_Alcove_Chest,
    CiTS_East_Wing_after_Dinalfos_Ledge_Chest,
    CiTS_Aeralfos_Chest,
    CiTS_East_Wing_Lower_Level_Chest,
    CiTS_West_Wing_Baba_Balcony_Chest,
    CiTS_West_Wing_Narrow_Ledge_Chest,
    CiTS_West_Wing_Tile_Worm_Chest,
    CiTS_Baba_Tower_Top_Small_Chest,
    CiTS_Baba_Tower_Narrow_Ledge_Chest,
    CiTS_Baba_Tower_Alcove_Chest,
    CiTS_West_Garden_Corner_Chest,
    CiTS_West_Gardens_Lone_Island_Chest,
    CiTS_West_Garden_Lower_Chest,
    CiTS_West_Garden_Ledge_Chest,
    CiTS_Central_Outside_Chest,
    CiTS_Central_Outside_Poe_Island_Chest,
    CiTS_Boss_Key_Chest,
    CiTS_Chest_Below_Boss_Key,
    CiTS_Chest_Behind_North_Fan,
    Kakariko_Gorge_DCS_Chest,
    Lanayru_Spring_East_DCS_Chest,
    Lanayru_Spring_West_DCS_Chest,
    South_of_Castle_Town_DCS_Chasm_Chest,
    PoT_West_Wing_First_Room_Central_Chest,
    PoT_West_Wing_Second_Room_Central_Chest,
    PoT_West_Wing_Second_Room_Lower_South_Chest,
    PoT_West_Wing_Second_Room_Southeast_Chest,
    PoT_West_Wing_Chest_Behind_Wall_of_Darkness,
    PoT_East_First_Room_North_Small_Chest,
    PoT_East_First_Room_North_Chest,
    PoT_East_Second_Room_North_East_Chest,
    PoT_East_Second_Room_North_West_Chest,
    PoT_East_Second_Room_Southwest_Chest,
    PoT_East_Second_Room_Southeast_Chest,
    PoT_East_First_Room_East_Alcove,
    PoT_East_First_Room_West_Alcove,
    PoT_Central_First_Room_Chest,
    PoT_Big_Key_Chest,
    PoT_Central_Outdoor_Chest,
    PoT_Central_Tower_Chest,
    HC_Graveyard_Grave_Switch_Room_Right_Chest,
    HC_Graveyard_Grave_Switch_Room_Front_Left_Chest,
    HC_Graveyard_Grave_Switch_Room_Back_Left_Chest,
    HC_Graveyard_Owl_Statue_Chest,
    HC_East_Wing_Boomerang_Puzzle_Chest,
    HC_East_Castle_Balcony_Chest,
    HC_West_Courtyard_Northern_Small_Chest,
    HC_West_Courtyard_Central_Small_Chest,
    HC_Main_Hall_Northeast_Chest,
    HC_Lantern_Staircase_Chest,
    HC_Main_Hall_Southwest_Chest,
    HC_Main_Hall_Northwest_Chest,
    HC_Southeast_Balcony_Tower_Chest,
    HC_Big_Key_Chest,
    HC_Treasure_Room_Eighth_Small_Chest,
    HC_Treasure_Room_Seventh_Small_Chest,
    HC_Treasure_Room_Sixth_Small_Chest,
    HC_Treasure_Room_Fifth_Small_Chest,
    HC_Treasure_Room_Fourth_Small_Chest,
    HC_Treasure_Room_Third_Small_Chest,
    HC_Treasure_Room_Second_Small_Chest,
    HC_Treasure_Room_First_Small_Chest,
    HC_Treasure_Room_Fifth_Chest,
    HC_Treasure_Room_Fourth_Chest,
    HC_Treasure_Room_Third_Chest,
    HC_Treasure_Room_Second_Chest,
    HC_Treasure_Room_First_Chest

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

    
        
        case Requirement.can_cut_hanging_web:
            return (checkIfItemIsInList(items::Clawshot,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Boomerang,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems));
            break
        case Requirement.can_defeat_bombling_or_burn_webs:
            return ((hasSword() ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Heros_Bow,PlacedImportantItems) ||
            checkIfItemIsInList(items::Iron_Boots,PlacedImportantItems) ||
            checkIfItemIsInList(items::Spinner,PlacedImportantItems) ||
            checkIfItemIsInList(items::Shadow_Crystal,PlacedImportantItems)) || 
            (checkIfItemIsInList(items::Lantern,PlacedImportantItems) ||
            checkIfItemIsInList(items::Ball_and_Chain,PlacedImportantItems) ||
            checkIfItemIsInList(items::Goron_Bomb_Bag,PlacedImportantItems)));
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