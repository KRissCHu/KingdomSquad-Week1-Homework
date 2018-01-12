using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSquadCombatApp.WeaponBehaviours;

namespace SimSquadCombatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter[] characters = new ICharacter[]
           {
                new King(new PaperClipBehaviour()),
                new Knight(new SwordBehaviour()),
                new Queen(new BowAndArrowBehaviour()),
                new Smurfette(new ToothpasteTubeBehaviour()),
                new SmurfStorm(new KnifeBehaviour()),
                new Troll(new ToiletPaperBehaviour()),
                new Mindil(new MutatedSeaWeedBehaviour())
           };


            foreach (var character in characters)
            {
                Console.WriteLine("The {0} is using a/n - ", character.GetType().Name);
                character.UseWeapon();
                character.Fight();
                Console.WriteLine("========================");
            }

        }
    }
}
