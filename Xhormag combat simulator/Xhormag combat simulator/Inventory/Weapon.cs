using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator.Inventory
{
    class Weapon
    {
        //Weapon members
        private string mWeaponName;
        private int mAbilityBonus;
        private int mDamageBonus;

        public Weapon(string pName, int pAbiltityBonus, int pDamageBonus)
        {
            mWeaponName = pName;
            mAbilityBonus = pAbiltityBonus;
            mDamageBonus = pDamageBonus;
        }

        //Weapon getter
        public string GetWeaponName() => mWeaponName;
        public int GetWeaponAbilityBonus() => mAbilityBonus;
        public int GetWeaponDamageBonus() => mDamageBonus;
    }
}
