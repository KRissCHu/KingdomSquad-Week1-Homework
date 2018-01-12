using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp.WeaponBehaviours
{
    public class PaperClipBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Paperclip: +1 Piercing Damage");
            Console.WriteLine("Throw!");
        }
    }
}
