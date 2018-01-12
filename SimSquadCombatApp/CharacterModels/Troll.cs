using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class Troll : ICharacter
    {
        public Troll(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
