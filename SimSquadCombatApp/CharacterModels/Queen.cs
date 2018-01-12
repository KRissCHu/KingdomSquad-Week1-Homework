using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class Queen : ICharacter
    {
        public Queen(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
