using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MilitaryUnit
{
    class SAW : SmallArms
    {
        public override void Description()
        {
            Console.WriteLine($"Perfect Maching Gun of one man!" +
                $"The {Type} shoots {Caliber}, holds {FeedingMechanismSize}, and shoots {FireRate}rounds per minute!");
        }

        public override void Shoot()
        {
            FeedingMechanismSize = 200;
            do
            {
                FeedingMechanismSize = FeedingMechanismSize - 1;
                Thread.Sleep(85);
                Console.WriteLine("Bang!");
            } while (FeedingMechanismSize > 0);
            Console.WriteLine("Out of Ammo!");
        }
    }
}
