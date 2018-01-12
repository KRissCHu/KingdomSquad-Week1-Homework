using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp.WeaponBehaviours
{
    public class ToothpasteTubeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Toothpaste Tube: +3 Burning Damage");
            Console.WriteLine("Splat!");
        }
    }
}
