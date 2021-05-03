using System;
using tprandomizer_poc_main;
using System.Collections.Generic;

namespace tprandomizer_poc_main
{
    public class LogicFunctions
    {
		public int fusedShadowCount = 0;
		public int mirrorShardCount = 0;

		public bool mdhComplete;

        public Dictionary<Token, string> TokenDict = new Dictionary<Token, String>();

        

        public static bool canUse(Item item)
		{
            bool canUseItem = false;
            if (Singleton.getInstance().Items.heldItems.Contains(item))
                {
                    canUseItem = true;
                }
			return canUseItem;
		}

        public static bool canUseTest(string item)
		{
            bool canUseItem = false;
            foreach (var listItem in Singleton.getInstance().Items.heldItems)
            {
                if (listItem.ToString() == item)
                {
                    canUseItem = true;
                    break;
                }
            }
			return canUseItem;
		}

        public static bool hasItem(int item)
		{
			bool canUseItem = false;
			
			return canUseItem;
		}

        public static bool hasDamagingItem()
        {
            return ( hasSword() ||
                    canUse(Item.Ball_and_Chain) ||
                    (getItemCount(Item.Progressive_Bow) >= 1) ||
                    hasBombs() ||
                    canUse(Item.Iron_Boots) ||
                    canUse(Item.Spinner) ||
                    canUse(Item.Shadow_Crystal));
        }

        public static bool hasSword()
        {
            return  ((getItemCount(Item.Progressive_Sword) >= 1));
        }

        public static bool canDefeatAeralfos()
        {
            return ((getItemCount(Item.Progressive_Clawshot) >= 1) ||
                    hasDamagingItem());
        }
        public static bool canDefeatArmos()
        {
            return (hasDamagingItem() ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatBabaSerpent()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBabyGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatBari()
        {
            return (canUseWaterBombs() ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatBeamos()
        {
            return (canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            hasBombs());
        }
        public static bool canDefeatBigBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChu()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBokoblin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Clawshot) >= 1)));
        }
        public static bool canDefeatBombling()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBomskit()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatBublin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChilfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatChuWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal)) &&
            (hasBombs() ||
            (getItemCount(Item.Progressive_Clawshot) >= 1)));
            
        }
        public static bool canDefeatDarknut()
        {
            return hasSword();
        }
        public static bool canDefeatDekuBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatDekuLike()
        {    
            return (hasBombs() ||
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDodongo()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFireKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFireToadpoli()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFreezard()
        {
            return canUse(Item.Ball_and_Chain);
        }
        public static bool canDefeatGoron()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Lantern) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatGhoulRat()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatGuay()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatHelmasaur()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatHelmasaurus()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatIceBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatIceKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatLeever()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatLizalfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatMiniFreezard()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatMoldorm()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPoisonMite()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Lantern) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatPuppet()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatRat()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatRedeadKnight()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowDekuBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shield_Attack) ||
            canUse(Item.Slingshot) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatShadowInsect()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public static bool canDefeatShadowKargarok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatShadowVermin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatSkulltula()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatStalchild()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTetike()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTileWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Shadow_Crystal)) &&
            canUse(Item.Boomerang));
        }
        public static bool canDefeatToado()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatWaterToadpoli()
        {
            return (hasSword() || 
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatTorchSlug()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatWalltula()
        {
            return (canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            hasBombs() ||
            canUse(Item.Boomerang) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
        }
        public static bool canDefeatWhiteWolfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatYoungGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatSkullKid()
        {
            return (getItemCount(Item.Progressive_Bow) >= 1);
        }
        public static bool canDefeatKingBublinBridge()
        {
            return (getItemCount(Item.Progressive_Bow) >= 1);
        }
        public static bool canDefeatKingBublinDesert()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatKingBublinCastle()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1)) &&
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatDarkhammer()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1))) &&
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public static bool canDefeatFyrus()
        {
            return ((getItemCount(Item.Progressive_Bow) >= 1) &&
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
            return ((getItemCount(Item.Progressive_Bow) >= 1) &&
            (getItemCount(Item.Progressive_Dominion_Rod) >= 1));
        }
        public static bool canDefeatArgorok()
        {
            return ((getItemCount(Item.Progressive_Clawshot) >= 2) &&
            canUse(Item.Iron_Boots) &&
            (getItemCount(Item.Progressive_Sword) >= 3));
        }
        public static bool canDefeatZant()
        {
            return ((getItemCount(Item.Progressive_Sword) >= 3) &&
            (canUse(Item.Boomerang) &&
            (getItemCount(Item.Progressive_Clawshot) >= 1) &&
            canUse(Item.Iron_Boots) &&
            canUse(Item.Zora_Armor) &&
            canUse(Item.Ball_and_Chain)));
        }
        public static bool canDefeatGanondorf()
        {
            return (canUse(Item.Shadow_Crystal) &&
            (getItemCount(Item.Progressive_Sword) >= 3) );
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
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1) ||
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
            (getItemCount(Item.Progressive_Bow) >= 1)) &&
            hasBombs());
        }

        public static bool canCutHangingWeb()
        {
            return ((getItemCount(Item.Progressive_Clawshot) >= 1) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            canUse(Item.Boomerang) ||
            canUse(Item.Ball_and_Chain));
        }
        public static bool canKnockDownHCPainting()
        {
            return ((getItemCount(Item.Progressive_Bow) >= 1) ||
            hasBombs());
        } 
        public static bool canBreakMonkeyCage()
        {
            return (hasSword() ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Shadow_Crystal) ||
            (getItemCount(Item.Progressive_Bow) >= 1) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1));
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
            return ((getItemCount(Item.Progressive_Bow) >= 1) ||
            (getItemCount(Item.Progressive_Clawshot) >= 1) ||
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
            return ((getItemCount(Item.Forest_Temple_Small_Key) >=4) && canUse(Item.Boomerang) && canUse(Item.Small_Key_N_Faron_Gate) && canBreakMonkeyCage() && canDefeatWalltula() && canDefeatBigBaba() && canBurnWebs() && canDefeatOok() && canDefeatDiababa() && canUse(Item.Forest_Temple_Big_Key));
        }

        public static bool canCompleteGoronMines()
        {
            return ((getItemCount(Item.Goron_Mines_Small_Key) >=3) && canDefeatDangoro() && canDefeatFyrus() && (getItemCount(Item.Progressive_Bow) >= 1) && canUse(Item.Iron_Boots) && hasSword() && canUse(Item.Goron_Mines_Big_Key));
        }

        public static bool canCompleteLakebedTemple()
        {
            return ((getItemCount(Item.Lakebed_Temple_Small_Key) >=3) && canDefeatDekuToad() && canDefeatMorpheel() && (getItemCount(Item.Progressive_Clawshot) >= 1) && canLaunchBombs() && canUseWaterBombs() && canUse(Item.Lakebed_Temple_Big_Key));
        }

        public static bool canCompleteSnowpeakRuins()
        {
            return (canDefeatBlizzeta() && canUse(Item.Ordon_Goat_Cheese) && canUse(Item.Ordon_Pumpkin) && canUse(Item.Ball_and_Chain) && canDefeatChilfos() && canDefeatMiniFreezard() && canDefeatFreezard() && (getItemCount(Item.Snowpeak_Ruins_Small_Key) >= 4) && hasBombs() && canUse(Item.Snowpeak_Ruins_Bedroom_Key));
        }

        public static bool canCompleteTempleofTime()
        {
            return ((getItemCount(Item.Progressive_Dominion_Rod) >= 1) && (getItemCount(Item.Progressive_Bow) >= 1) && canUse(Item.Spinner) && canDefeatLizalfos() && canDefeatDinalfos() && canDefeatDarknut() && canDefeatArmogohma() && canUse(Item.Temple_of_Time_Big_Key) && (getItemCount(Item.Temple_of_Time_Small_Key) >= 3));
        }
        public static bool canCompletePalaceofTwilight()
        {
            return ((getItemCount(Item.Palace_of_Twilight_Small_Key) >=7) && (getItemCount(Item.Progressive_Sword) >= 4) && canDefeatZantHead() && canDefeatShadowBeast() && (getItemCount(Item.Progressive_Clawshot) >= 2) && canDefeatPhantomZant() && canDefeatZant() && canUse(Item.Shadow_Crystal) && canUse(Item.Palace_of_Twilight_Big_Key));
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
            return itemQuantity;
		}

        public static int getSingleBugCount()
		{
            List<Item> itemList = Singleton.getInstance().Items.heldItems;
			int itemQuantity = 0;

            if (itemList.Contains(Item.Male_Ant) || itemList.Contains(Item.Female_Ant))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Beetle) || itemList.Contains(Item.Female_Beetle))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Butterfly) || itemList.Contains(Item.Female_Butterfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Dayfly) || itemList.Contains(Item.Female_Dayfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Dragonfly) || itemList.Contains(Item.Female_Dragonfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Grasshopper) || itemList.Contains(Item.Female_Grasshopper))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Ladybug) || itemList.Contains(Item.Female_Ladybug))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Mantis) || itemList.Contains(Item.Female_Mantis))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Phasmid) || itemList.Contains(Item.Female_Phasmid))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Pill_Bug) || itemList.Contains(Item.Female_Pill_Bug))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Snail) || itemList.Contains(Item.Female_Snail))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Stag_Beetle) || itemList.Contains(Item.Female_Stag_Beetle))
            {
                itemQuantity++;
            }
            return itemQuantity;
		}

        public static int getBugPairCount()
		{
            List<Item> itemList = Singleton.getInstance().Items.heldItems;
			int itemQuantity = 0;

            if (itemList.Contains(Item.Male_Ant) && itemList.Contains(Item.Female_Ant))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Beetle) && itemList.Contains(Item.Female_Beetle))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Butterfly) && itemList.Contains(Item.Female_Butterfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Dayfly) && itemList.Contains(Item.Female_Dayfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Dragonfly) && itemList.Contains(Item.Female_Dragonfly))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Grasshopper) && itemList.Contains(Item.Female_Grasshopper))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Ladybug) && itemList.Contains(Item.Female_Ladybug))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Mantis) && itemList.Contains(Item.Female_Mantis))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Phasmid) && itemList.Contains(Item.Female_Phasmid))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Pill_Bug) && itemList.Contains(Item.Female_Pill_Bug))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Snail) && itemList.Contains(Item.Female_Snail))
            {
                itemQuantity++;
            }
            if (itemList.Contains(Item.Male_Stag_Beetle) && itemList.Contains(Item.Female_Stag_Beetle))
            {
                itemQuantity++;
            }
            return itemQuantity;
		}

        public static bool verifyItemQuantity(string itemToBeCounted, int quantity)
		{
            List<Item> itemList = Singleton.getInstance().Items.heldItems;
			int itemQuantity = 0;
            bool isQuantity = false;
            
			foreach (var item in itemList)
			{
				if (item.ToString() == itemToBeCounted)
				{
					itemQuantity++;
				}
			}
            if (itemQuantity >= quantity)
            {
                isQuantity = true;
            }
            return isQuantity;
		}
    }
}