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
