using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class SmurfStorm : ICharacter
    {
        public SmurfStorm(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
