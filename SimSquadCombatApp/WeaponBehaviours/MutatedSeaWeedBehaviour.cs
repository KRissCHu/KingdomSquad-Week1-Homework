using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp.WeaponBehaviours
{
    public class MutatedSeaWeedBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Mutated Sea Weed: +5 Toxic Damage");
            Console.WriteLine("Slap!");
        }

    }
}
