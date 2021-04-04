using System;
using Assets.Items;
using tprandomizer_poc_main;

namespace Logic
{
    public class LogicFunctions
    {

        public static int forestTempleSmallKeyCount = 0;
		public static int goronMinesSmallKeyCount = 0;
		public static int lakebedTempleSmallKeyCount = 0;
		public static int arbitersGroundsSmallKeyCount = 0;
		public static int snowpeakRuinsSmallKeyCount = 0;
		public static int templeofTimeSmallKeyCount = 0;
		public static int cityinTheSkySmallKeyCount = 0;
		public static int palaceofTwilightSmallKeyCount = 0;
		public static int hyruleCastleSmallKeyCount = 0;
		public int fusedShadowCount = 0;
		public int mirrorShardCount = 0;

		public bool mdhComplete;
		public static bool diababaDefeated;
		public static bool fyrusDefeated;
		public static bool morpheelDefeated;
		public static bool stallordDefeated;
		public static bool blizzetaDefeated;
		public static bool armogohmaDefeated;
		public static bool argorokDefeated;
		public static bool zantDefeated;
		bool ganondorfDefeated;

        

        public static bool canUse(Item item)
		{
            bool canUseItem = false;
            /*ItemFunctions Items = new ItemFunctions();
            foreach (var checkedItem in Items.heldItems)
            {
                if (checkedItem == item)
                {
                    canUseItem = true;
                }
            }*/
			return canUseItem;
		}

        public static bool hasItem(int item)
		{
			bool canUseItem = false;
			
			return canUseItem;
		}

        public static bool hasSword()
        {
            return  (canUse(Item.Wooden_Sword) ||
                    canUse(Item.Ordon_Sword) ||
                    canUse(Item.Master_Sword) ||
                    canUse(Item.Master_Sword_Light));
        }

        public static bool canDefeatAeralfos()
        {
            return (canUse(Item.Clawshot) ||
                    canUse(Item.Ball_and_Chain) ||
                    hasSword() ||
                    canUse(Item.Heros_Bow) ||
                    hasBombs() ||
                    canUse(Item.Iron_Boots) ||
                    canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatArmos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatBabaSerpent()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBabyGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatBari()
        {
            return (canUseWaterBombs() ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatBeamos()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            hasBombs());
        }
        public static bool canDefeatBigBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChu()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBokoblin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot));
        }
        public static bool canDefeatBombfish()
        {
            return (canUse(Item.Iron_Boots) &&
            (hasSword() ||
            canUse(Item.Ordon_Shield) ||
            canUse(Item.Wooden_Shield)  ||
            canUse(Item.Hylian_Shield)  ||
            canUse(Item.Clawshot)));
        }
        public static bool canDefeatBombling()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBomskit()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBublin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChilfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChuWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal)) &&
            (hasBombs() ||
            canUse(Item.Clawshot)));
            
        }
        public static bool canDefeatDarknut()
        {
            return hasSword();
        }
        public static bool canDefeatDekuBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatDekuLike()
        {    
            return (hasBombs() ||
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDodongo()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDinalfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFireBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFireKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFireToadpoli()
        {
            return (canUse(Item.Wooden_Sword) ||
            canUse(Item.Ordon_Sword) ||
            canUse(Item.Master_Sword) ||
            canUse(Item.Master_Sword_Light) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFreezard()
        {
            return canUse(Item.Ball_and_Chain);
        }
        public static bool canDefeatGoron()
        {
            return (canUse(Item.Wooden_Sword) ||
            canUse(Item.Ordon_Sword) ||
            canUse(Item.Master_Sword) ||
            canUse(Item.Master_Sword_Light) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Lantern) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatGhoulRat()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatGuay()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatHelmasaur()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatHelmasaurus()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatIceBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatIceKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPoe()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatKargarok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatLeever()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatLizalfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatMiniFreezard()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatMoldorm()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPoisonMite()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Lantern) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPuppet()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatRat()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatRedeadKnight()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowBeast()
        {
            return (hasSword() ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowBublin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowDekuBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatShadowInsect()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatShadowKargarok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowVermin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShellBlade()
        {
            return ((hasSword() ||
            canUseWaterBombs()) &&
            canUse(Item.Iron_Boots));
        }
        public static bool canDefeatSkullfish()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatSkulltula()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatStalfos()
        {
            return (canSmash());
        }
        public static bool canDefeatStalhound()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatStalchild()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTetike()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTileWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal)) &&
            canUse(Item.Boomerang));
        }
        public static bool canDefeatToado()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatWaterToadpoli()
        {
            return (hasSword() || 
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTorchSlug()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatWalltula()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            hasBombs() ||
            canUse(Item.Boomerang) ||
            canUse(Item.Clawshot));
        }
        public static bool canDefeatWhiteWolfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatYoungGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatZantHead()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword());
        }
        public static bool canDefeatOok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDangoro()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Shadow_Crystal)) &&
            canUse(Item.Iron_Boots));
        }
        public static bool canDefeatCarrierKargarok()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatTwilitBloat()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatDekuToad()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatSkullKid1()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatSkullKid2()
        {
            return canUse(Item.Heros_Bow);
        }
        public static bool canDefeatKingBublin2()
        {
            return canUse(Item.Heros_Bow);
        }
        public static bool canDefeatKingBublin3()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatKingBublin4()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDeathSword()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner)) &&
            (canUse(Item.Boomerang) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot)) &&
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDarkhammer()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPhantomZant()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword());
        }
        public static bool canDefeatDiababa()
        {
            return ((canUse(Item.Boomerang) ||
            (hasBombs() &&
            canUse(Item.Heros_Bow))) &&
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFyrus()
        {
            return (canUse(Item.Heros_Bow) &&
            canUse(Item.Iron_Boots) &&
            hasSword());
        }
        public static bool canDefeatMorpheel()
        {
            return (canUse(Item.Zora_Armor) &&
            canUse(Item.Iron_Boots) &&
            hasSword());
        }
        public static bool canDefeatStallord()
        {
            return (canUse(Item.Spinner) &&
            hasSword());
        }
        public static bool canDefeatBlizzeta()
        {
            return canUse(Item.Ball_and_Chain);
        }
        public static bool canDefeatArmogohma()
        {
            return (canUse(Item.Heros_Bow) &&
            canUse(Item.Dominion_Rod));
        }
        public static bool canDefeatArgorok()
        {
            return (canUse(Item.Double_Clawshot) &&
            canUse(Item.Iron_Boots) &&
            (canUse(Item.Master_Sword_Light) ||
            canUse(Item.Master_Sword)));
        }
        public static bool canDefeatZant()
        {
            return ((canUse(Item.Master_Sword) ||
            canUse(Item.Master_Sword_Light)) &&
            (canUse(Item.Boomerang) &&
            canUse(Item.Clawshot) &&
            canUse(Item.Iron_Boots) &&
            canUse(Item.Zora_Armor) &&
            canUse(Item.Ball_and_Chain)));
        }
        public static bool canDefeatGanondorf()
        {
            return (canUse(Item.Shadow_Crystal) &&
            canUse(Item.Master_Sword) &&
            canUse(Item.Ending_Blow) );
        }

        public static bool canSmash()
        {
                return (canUse(Item.Ball_and_Chain) ||
                hasBombs());
        }

        public static bool canBurnWebs()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Lantern) ||
            hasBombs());
        }

        public static bool hasRangedItem()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot) ||
            canUse(Item.Boomerang));
        }

        public static bool hasSheild()
        {
            return (canUse(Item.Ordon_Shield)  ||
            canUse(Item.Wooden_Shield)  ||
            canUse(Item.Hylian_Shield) );
        }
        public static bool canLaunchBombs()
        {
            return ((canUse(Item.Boomerang) ||
            canUse(Item.Heros_Bow)) &&
            hasBombs());
        }

        public static bool canCutHangingWeb()
        {
            return (canUse(Item.Clawshot) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Boomerang) ||
            canUse(Item.Ball_and_Chain));
        }
        public static bool canKnockDownHCPainting()
        {
            return (canUse(Item.Heros_Bow) ||
            hasBombs());
        } 
        public static bool canBreakMonkeyCage()
        {
            return (hasSword() ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Shadow_Crystal) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot));
        }
        public static bool canPressMinesSwitch()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots));
        }
        public static bool canFreeAllMonkeys()
        {
                    return (canBreakMonkeyCage()  &&
                    canBurnWebs() &&
                    canUse(Item.Boomerang) && canDefeatBokoblin() && canDefeatBigBaba());
        }
        public static bool canKnockDownHangingBaba()
        {
            return (canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot) ||
            canUse(Item.Boomerang));
        }
        
        public static bool canBreakWoodenDoor()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword() ||
            (canUse(Item.Ball_and_Chain) ||
            hasBombs()));
        }

        public static bool hasBombs()
        {
            return (canUse(Item.Bomb_Bag_And_Bombs) ||
            canUse(Item.Empty_Bomb_Bag));
        }

        public static bool canUseWaterBombs()
        {
            RoomFunctions Rooms = new RoomFunctions();
            return (hasBombs() && (Rooms.RoomDict["Hidden Village"].visited == true));
        }
    }
}