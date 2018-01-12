using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class Smurfette : ICharacter
    {
        public Smurfette(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
