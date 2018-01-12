using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class Knight : ICharacter
    {
        public Knight(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
