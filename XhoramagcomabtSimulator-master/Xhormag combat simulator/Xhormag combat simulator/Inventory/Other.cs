﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xhormag_combat_simulator
{
    class Other
    {
        //Miscellaneous members
        private string mMiscellaneousName;
        private string mDescription;
        private int mVolume;
        

        public Other(string pName, string pDescription, int pVolume)
        {
            mMiscellaneousName = pName;
            mDescription = pDescription;
            mVolume = pVolume;
        }

        //Miscellaneous getter
        public string MiscellaneousName => mMiscellaneousName;
        public string GetDescription() => mDescription;
        public int GetVolume() => mVolume;
    }
}