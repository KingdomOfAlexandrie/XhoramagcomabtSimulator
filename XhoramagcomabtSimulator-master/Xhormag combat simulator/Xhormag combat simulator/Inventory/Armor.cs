using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    class Armor
    {
        //Armor members
        public string mArmorName { get; set; }
        private string mArmorType { get; set; }
        private int mArmorValue { get; set; }

        public Armor(string pName, string pArmorType, int pAmrorValue)
        {
            mArmorName = pName;
            mArmorType = pArmorType;
            mArmorValue = pAmrorValue;
        }        //Armor getter
    }
}