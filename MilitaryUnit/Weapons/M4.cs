using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M4Carbine : SmallArms
    {
        string WeaponAttachment = "320";
        public override void Description()
        {
            Console.WriteLine($"The U.S. Military's primary weapon system for its service members" +
                $"The {Type} shoots {Caliber}, holds {FeedingMechanismSize}, and shoots {FireRate}rounds per minute!");
        }
        public override void Shoot()
        {
            FeedingMechanismSize = 30;
            do
            {
                FeedingMechanismSize = FeedingMechanismSize - 1;
                Thread.Sleep(100);
                Console.WriteLine("Bang!");
            } while (FeedingMechanismSize > 0);
            Console.WriteLine($"Shooting {WeaponAttachment}");
            Console.WriteLine("Out of Ammo!");
        }
    }
}
