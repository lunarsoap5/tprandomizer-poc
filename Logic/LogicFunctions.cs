using System;
using Assets.Items;
using Randomizer;

namespace Logic
{
    class LogicFunctions
    {
        public bool canUse(Item item)
		{
			bool canUseItem = false;
			foreach (var heldItem in heldItemList)
			{
				if (item == heldItem)
				{
					canUseItem = true;
				}
			}
			return canUseItem;
		}

        public bool hasSword()
        {
            return  (canUse(Item.Wooden_Sword) ||
                    canUse(Item.Ordon_Sword) ||
                    canUse(Item.Master_Sword) ||
                    canUse(Item.Master_Sword_Light));
        }

        public bool canDefeatAeralfos()
        {
            return (canUse(Item.Clawshot) ||
                    canUse(Item.Ball_and_Chain) ||
                    hasSword() ||
                    canUse(Item.Heros_Bow) ||
                    canUse(Item.Goron_Bomb_Bag) ||
                    canUse(Item.Iron_Boots) ||
                    canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatArmos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Clawshot));
        }
        public bool canDefeatBabaSerpent()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatBabyGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Clawshot));
        }
        public bool canDefeatBari()
        {
            return (canUse(Item.Goron_Bomb_Bag) ||
            canUse(Item.Clawshot));
        }
        public bool canDefeatBeamos()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Goron_Bomb_Bag));
        }
        public bool canDefeatBigBaba()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatChu()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatBokoblin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot));
        }
        public bool canDefeatBombfish()
        {
            return (canUse(Item.Iron_Boots) &&
            (hasSword() ||
            canUse(Item.Ordon_Shield) ||
            canUse(Item.Wooden_Shield)  ||
            canUse(Item.Hylian_Shield)  ||
            canUse(Item.Clawshot)));
        }
        public bool canDefeatBombling()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatBombskit()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatBublin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatChilfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatChuWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal)) &&
            (canUse(Item.Goron_Bomb_Bag) ||
            canUse(Item.Clawshot)));
            
        }
        public bool canDefeatDarknut()
        {
            return hasSword();
        }
        public bool canDefeatDekuBaba()
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
        public bool canDefeatDekuLike()
        {    
            return (canUse(Item.Goron_Bomb_Bag) ||
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatDodongo()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatDinalfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatFireBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatFireKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatFireToadpoli()
        {
            return (canUse(Item.Wooden_Sword) ||
            canUse(Item.Ordon_Sword) ||
            canUse(Item.Master_Sword) ||
            canUse(Item.Master_Sword_Light) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatFreezard()
        {
            return canUse(Item.Ball_and_Chain);
        }
        public bool canDefeatGoron()
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
        public bool canDefeatGhoulRat()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public bool canDefeatGuay()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatHelmasaur()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatHelmasaurus()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatIceBubble()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatIceKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatPoe()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public bool canDefeatKargarok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
        }
        public bool canDefeatLeever()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatLizalfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatMiniFreezard()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatMoldorm()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatPoisonMite()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Lantern) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatPuppet()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatRat()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatRedeadKnight()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShadowBeast()
        {
            return (hasSword() ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShadowBublin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShadowDekuBaba()
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
        public bool canDefeatShadowInsect()
        {
            return canUse(Item.Shadow_Crystal);
        }
        public bool canDefeatShadowKargarok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShadowKeese()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShadowVermin()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatShellBlade()
        {
            return ((hasSword() ||
            canUse(Item.Goron_Bomb_Bag)) &&
            canUse(Item.Iron_Boots));
            }
        public bool canDefeatSkullfish()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatSkulltula()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatStalfos()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Goron_Bomb_Bag));
            }
        public bool canDefeatStalhound()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatStalchild()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatTetike()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatTileWorm()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal)) &&
            canUse(Item.Boomerang));
            }
        public bool canDefeatToado()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatWaterToadpoli()
        {
            return (hasSword() || 
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatTorchSlug()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatWalltula()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Goron_Bomb_Bag) ||
            canUse(Item.Boomerang) ||
            canUse(Item.Clawshot));
        }
        public bool canDefeatWhiteWolfos()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatYoungGohma()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatZantHead()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword());
        }
        public bool canDefeatOok()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatDangoro()
        {
            return ((hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Shadow_Crystal)) &&
            canUse(Item.Iron_Boots));
            }
        public bool canDefeatCarrierKargarok()
        {
            return canUse(Item.Shadow_Crystal);
            }
        public bool canDefeatTwilitBloat()
        {
            return canUse(Item.Shadow_Crystal);
            }
        public bool canDefeatDekuToad()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatSkullKid1()
        {
            return canUse(Item.Shadow_Crystal);
            }
        public bool canDefeatSkullKid2()
        {
            return canUse(Item.Heros_Bow);
            }
        public bool canDefeatKingBublin2()
        {
            return canUse(Item.Heros_Bow);
            }
        public bool canDefeatKingBublin3()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatKingBublin4()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatDeathSword()
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
        public bool canDefeatDarkhammer()
        {
            return (hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatPhantomZant()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword());
        }
        public bool canDefeatDiababa()
        {
            return ((canUse(Item.Boomerang) ||
            (canUse(Item.Goron_Bomb_Bag) &&
            canUse(Item.Heros_Bow))) &&
            hasSword() ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Shadow_Crystal));
            }
        public bool canDefeatFyrus()
        {
            return (canUse(Item.Heros_Bow) &&
            canUse(Item.Iron_Boots) &&
            hasSword());
            }
        public bool canDefeatMorpheel()
        {
            return (canUse(Item.Zora_Armor) &&
            canUse(Item.Iron_Boots) &&
            hasSword());
            }
        public bool canDefeatStallord()
        {
            return (canUse(Item.Spinner) &&
            hasSword());
            }
        public bool canDefeatBlizzeta()
        {
            return canUse(Item.Ball_and_Chain);
            }
        public bool canDefeatArmogohma()
        {
            return (canUse(Item.Heros_Bow) &&
            canUse(Item.Dominion_Rod));
        }
        public bool canDefeatArgorok()
        {
            return (canUse(Item.Double_Clawshot) &&
            canUse(Item.Iron_Boots) &&
            (canUse(Item.Master_Sword_Light) ||
            canUse(Item.Master_Sword)));
            }
        public bool canDefeatZant()
        {
            return ((canUse(Item.Master_Sword) ||
            canUse(Item.Master_Sword_Light)) &&
            (canUse(Item.Boomerang) &&
            canUse(Item.Clawshot) &&
            canUse(Item.Iron_Boots) &&
            canUse(Item.Zora_Armor) &&
            canUse(Item.Ball_and_Chain)));
            }
        public bool canDefeatGanondorf()
        {
            return (canUse(Item.Shadow_Crystal) &&
            canUse(Item.Master_Sword) &&
            canUse(Item.Ending_Blow) );
            }

        public bool canFreeAllMonkeys()
        {
                    return (canBreakMonkeyCage() &&
                    (forestTempleSmallKeyCount >= 4) &&
                    canBurnWebs() &&
                    canUse(Item.Boomerang) && canDefeatBokoblin() && canDefeatBigBaba());
        }

        public bool canSmash()
        {
                return (canUse(Item.Ball_and_Chain) ||
                canUse(Item.Goron_Bomb_Bag));
        }

        public bool canBurnWebs()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Lantern) ||
            canUse(Item.Goron_Bomb_Bag));
            }

        public bool hasRangedItem()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Slingshot) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot) ||
            canUse(Item.Boomerang));
            }

        public bool hasSheild()
        {
            return (canUse(Item.Ordon_Shield)  ||
            canUse(Item.Wooden_Shield)  ||
            canUse(Item.Hylian_Shield) );
            }
        public bool canLaunchBombs()
        {
            return ((canUse(Item.Boomerang) ||
            canUse(Item.Heros_Bow)) &&
            canUse(Item.Goron_Bomb_Bag));
            }

        public bool canCutHangingWeb()
        {
            return (canUse(Item.Clawshot) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Boomerang) ||
            canUse(Item.Ball_and_Chain));
        }

        public bool canPressMinesSwitch()
        {
            return (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Iron_Boots));
            }
        public bool canKnockDownHangingBaba()
        {
            return (canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot) ||
            canUse(Item.Boomerang));
            }

        public bool canBreakWoodenDoor()
        {
            return (canUse(Item.Shadow_Crystal) ||
            hasSword() ||
            (canUse(Item.Ball_and_Chain) ||
            canUse(Item.Goron_Bomb_Bag)));
        }

        public bool canKnockDownHCPainting()
        {
            return (canUse(Item.Heros_Bow) ||
            canUse(Item.Goron_Bomb_Bag));
        }
        public bool canBreakMonkeyCage()
        {
            return (hasSword() ||
            canUse(Item.Iron_Boots) ||
            canUse(Item.Spinner) ||
            canUse(Item.Ball_and_Chain) ||
            canUse(Item.Shadow_Crystal) ||
            canUse(Item.Heros_Bow) ||
            canUse(Item.Clawshot));
            }
        public bool canAccessDarkhammer()
        {
            return (canUse(Item.Ball_and_Chain) ||
            (canUse(Item.Goron_Bomb_Bag) &&
            (snowpeakRuinsSmallKeyCount >= 4)));
            }
    }
}