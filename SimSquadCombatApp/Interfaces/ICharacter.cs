using System;
using System.Collections.Generic;
using System.Text;

namespace SimSquadCombatApp
{
    public abstract class ICharacter
    {
        private IWeaponBehaviour iWeaponBehaviour;

        public ICharacter(IWeaponBehaviour iwb)
        {
            this.iWeaponBehaviour = iwb;
        }

        public void UseWeapon()
        {
            this.iWeaponBehaviour.UseWeapon();
        }

        public void Fight()
        {
            Console.WriteLine("TO WAR!");
        }
    }
}
