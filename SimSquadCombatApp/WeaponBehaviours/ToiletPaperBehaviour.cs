using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp.WeaponBehaviours
{
    public class ToiletPaperBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Toilet Paper Roll: +2 Soft Damage");
            Console.WriteLine("Rollout!");
        }

    }
}
