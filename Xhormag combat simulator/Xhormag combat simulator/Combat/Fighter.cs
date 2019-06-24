using System;

namespace Xhormag_combat_simulator
{
    public class Fighter
    {
        private int mAbility;
        private int mEndurence;
        private int mDamage;
        private int mArmor;
        private int criticalWound;
        private bool criticalWeakness;

        public Fighter(int pAbility, int pDamage, int pArmor, int pEndurence)
        {
            SetAbility(pAbility);
            SetEndurence(pEndurence);
            SetDamage(pDamage);
            SetArmor(pArmor);
            if (pEndurence <= 120)
            {
                criticalWound = 12;
            } 
            if (pEndurence > 120)
            {
                criticalWound = pEndurence / 10;
            }
        }

        public int SetAbility(int ability)
        {
            return mAbility = ability;
        }
        public int SetEndurence(int endurence)
        {
            return mEndurence = endurence;
        }
        public int SetDamage(int damage)
        {
            return mDamage = damage;
        }
        public int SetArmor(int armor)
        {
            return mArmor = armor;
        }
        public bool SetCriticalWeakness(bool trueFalse)
        {
            return criticalWeakness = trueFalse;
        }
        public int GetAbility()
        {
            return mAbility;
        }
        public int GetEndurence()
        {
            return mEndurence;
        }
        public int GetDamage()
        {
            return mDamage;
        }
        public int GetArmor()
        {
            return mArmor;
        }
        public int GetCriticalWound()
        {
            return criticalWound;
        }
        public bool GetCriticalWeakness()
        {
            return criticalWeakness;
        }
    }
}