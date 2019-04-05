using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class SmallArms
    {
        public string Type { get; set; }
        public double Caliber { get; set; }
        public int FeedingMechanismSize { get; set; }
        public int FireRate { get; set; }

        public virtual void Description()
        {
            Console.WriteLine($"This {Type} shoots {Caliber} round. The magazine holds {FeedingMechanismSize} " +
                $"and it has a fire rate of {FireRate}");
        }
        public virtual void Shoot()
        {
            FeedingMechanismSize = 30;
            do
            {
                FeedingMechanismSize = FeedingMechanismSize - 1;
                Thread.Sleep(750);
                Console.WriteLine("Bang!");
            } while(FeedingMechanismSize > 0);
        }

    }
}
