﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSquadCombatApp
{
    public class Mindil : ICharacter
    {
        public Mindil(IWeaponBehaviour iwb) : base(iwb)
        {
        }
    }
}
