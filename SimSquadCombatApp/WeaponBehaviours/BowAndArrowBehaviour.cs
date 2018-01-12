using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp.WeaponBehaviours
{
    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Bow & Arrow: +5 Piercing Damage");
            Console.WriteLine("Thonk!");
        }
    }
}
