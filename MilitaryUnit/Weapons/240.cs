using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MilitaryUnit.Weapons
{
    class Mg240 : SmallArms
    {
        public int AmmoBearer = 600;

        public override void Description()
        {
            Console.WriteLine($"This machine gun is a valuable company asset in the battle field" +
                $"The {Type} shoots {Caliber}, holds {FeedingMechanismSize}, and shoots {FireRate}rounds per minute!");
        }

        public override void Shoot()
        {
            FeedingMechanismSize = 200 + AmmoBearer;
            do
            {
                FeedingMechanismSize = FeedingMechanismSize - 1;
                Thread.Sleep(50);
                Console.WriteLine("Bang!");
            } while (FeedingMechanismSize > 0);
            Console.WriteLine("Out of Ammo!");
        }
    }
}
