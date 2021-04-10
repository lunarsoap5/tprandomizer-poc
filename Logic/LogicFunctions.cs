using System;
using tprandomizer_poc_main;
using System.Collections.Generic;

namespace Logic
{
    public class LogicFunctions
    {
		public int fusedShadowCount = 0;
		public int mirrorShardCount = 0;

		public bool mdhComplete;
		public static bool diababaDefeated = true;
		public static bool fyrusDefeated = true;
		public static bool morpheelDefeated = true;
		public static bool stallordDefeated= true;
		public static bool blizzetaDefeated =true;
		public static bool armogohmaDefeated = true;
		public static bool argorokDefeated = true;
		public static bool zantDefeated = true;

        

        public static bool canUse(Item item)
		{
            bool canUseItem = false;
            foreach (var checkedItem in Singleton.getInstance().Items.heldItems)
            {
                if (checkedItem == item)
                {
                    canUseItem = true;
                }
            }
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
            return (hasBombs() && canLeaveForest());
        }

        public static bool canLeaveForest()
        {
            return (canCompleteForestTemple());
        }

        public static bool canCompleteForestTemple()
        {
            return ((getItemCount(Item.Forest_Temple_Small_Key) >=4) && canUse(Item.Boomerang) && canBreakMonkeyCage() && canDefeatWalltula() && canDefeatBigBaba() && canBurnWebs() && canDefeatOok() && canDefeatDiababa() && canUse(Item.Forest_Temple_Big_Key));
        }

        public static bool canCompleteGoronMines()
        {
            return ((getItemCount(Item.Goron_Mines_Small_Key) >=3) && canDefeatDangoro() && canDefeatFyrus() && canUse(Item.Heros_Bow) && canUse(Item.Iron_Boots) && hasSword() && canUse(Item.Goron_Mines_Big_Key));
        }

        public static bool canCompleteLakebedTemple()
        {
            return ((getItemCount(Item.Lakebed_Temple_Small_Key) >=3) && canDefeatDekuToad() && canDefeatMorpheel() && canUse(Item.Clawshot) && canLaunchBombs() && canUseWaterBombs() && canUse(Item.Lakebed_Temple_Big_Key));
        }
        public static bool canCompletePalaceofTwilight()
        {
            return ((getItemCount(Item.Palace_of_Twilight_Small_Key) >=7) && canUse(Item.Master_Sword_Light) && canDefeatZantHead() && canDefeatShadowBeast() && canUse(Item.Double_Clawshot) && canDefeatPhantomZant() && canDefeatZant() && canUse(Item.Shadow_Crystal) && canUse(Item.Palace_of_Twilight_Big_Key));
        }

        public static int getItemCount(Item itemToBeCounted)
		{
            List<Item> itemList = Singleton.getInstance().Items.heldItems;
			int itemQuantity = 0;
			foreach (var item in itemList)
			{
				if (item == itemToBeCounted)
				{
					itemQuantity++;
				}
			}
            Console.WriteLine("Item: " + itemToBeCounted.ToString() + "Quantity: " + itemQuantity);
			return itemQuantity;
		}

        public void checkBossFlags(Room bossRoom)
        {
            switch (bossRoom.name)
            {
                case "Diababa":
                    if (bossRoom.visited == true && !canDefeatDiababa())
                    {
                        diababaDefeated = false;
                    }
                    break;
                case "Fyrus":
                    if (bossRoom.visited == true && !canDefeatFyrus())
                    {
                        fyrusDefeated = false;
                    }
                    break;
                case "Morpheel":
                    if (bossRoom.visited == true && !canDefeatMorpheel())
                    {
                        morpheelDefeated = false;
                    }
                    break;
                case "Stallord":
                    if (bossRoom.visited == true && !canDefeatStallord())
                    {
                        stallordDefeated = false;
                    }
                    break;
                case "Blizzeta":
                    if (bossRoom.visited == true && !canDefeatBlizzeta())
                    {
                        blizzetaDefeated = false;
                    }
                    break;
                case "Armogohma":
                    if (bossRoom.visited == true && !canDefeatArmogohma())
                    {
                        armogohmaDefeated = false;
                    }
                    break;
                case "Argorok": 
                    if (bossRoom.visited == true && !canDefeatArgorok())
                    {
                        argorokDefeated = false;
                    }
                    break;
                case "Zant":
                if (bossRoom.visited == true && !canDefeatZant())
                {
                    zantDefeated = false;
                }
                break;
            }
        }
    }
}