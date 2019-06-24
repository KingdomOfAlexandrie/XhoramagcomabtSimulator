using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator.Inventory
{
    class Armor
    {
        //Armor members
        private string mArmorName;
        private string mArmorType;
        private int mArmorValue;

        public Armor(string pName, string pArmorType, int pAmrorValue)
        {
            mArmorName = pName;
            mArmorType = pArmorType;
            mArmorValue = pAmrorValue;
        }        //Armor getter
        public string GetArmorName() => mArmorName;
        public string GetArmorType() => mArmorType;
        public int GetArmorValue() => mArmorValue;
    }
}