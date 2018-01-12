using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class King : ICharacter
    {
        public King(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
