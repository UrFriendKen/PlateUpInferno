﻿using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using System.Collections.Generic;

namespace KitchenInferno.Customs.InfernoSetting
{
    public class PyromaniaUnlock : CustomUnlockCard
    {
        public override string UniqueNameID => "pyromaniaUnlock";

        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {
            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    Process = ProcessReferences.Cook,
                    Speed = 0f,
                    BadSpeed = 0.5f
                }
            },
            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CFlammableItemsModifier()
                {
                    BurnSpeedChange = 0.667f
                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAtNight(),
                EffectType = new CApplianceSpeedModifier()
                {
                    Process = ProcessReferences.Cook,
                    Speed = 0f,
                    BadSpeed = 1f
                }
            },
            new GlobalEffect()
            {
                EffectCondition = new CEffectAtNight(),
                EffectType = new CFlammableItemsModifier()
                {
                    BurnSpeedChange = 0.5f
                }
            },

            //new GlobalEffect()
            //{
            //    EffectCondition = new CEffectAlways(),
            //    EffectType = new CFireSpreadModifier()
            //    {
            //        SpreadChanceModifier = 2f
            //    }
            //},

            new StatusEffect()
            {
                Status = Main.PYROMANIA_EFFECT_STATUS
            },

            new StatusEffect()
            {
                Status = Main.WILDFIRES_EFFECT_STATUS
            }
        };

        public override bool IsUnlockable => false;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override UnlockGroup UnlockGroup => UnlockGroup.Special;
        public override CardType CardType => CardType.Setting;

        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>()
        {
            (Locale.English, new UnlockInfo()
            {
                Locale = Locale.English,
                Name = "Pyromania",
                Description = "Fire spreads further, faster, and through walls. Hobs, and ovens, are more prone to fire. Food burns faster.",
                FlavourText = "Remember, bring your fire extinguishers to the party!"
            })
        };

        //public override Color ColourOverride => Color.red;
    }
}
