using MilitaryUnit.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            M4Carbine M4 = new M4Carbine()
            {
                Type = "M4",
                Caliber = 5.56,
                FeedingMechanismSize = 30,
                FireRate = 700
            };

            SAW Saw = new SAW()
            {
                Type = "249SAW",
                Caliber = 5.56,
                FeedingMechanismSize = 200,
                FireRate = 850
            };

            Mg240 mg240 = new Mg240()
            {
                Type = "240L",
                Caliber = 7.62,
                FeedingMechanismSize = 200,
                FireRate = 950
            };

            bool loop = true;
            do
            {
                Console.WriteLine("Choose your weapon");
                Console.WriteLine("1 = M4     2 = SAW     3 = 240     4 = EXIT\n");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        {
                            M4.Description();
                            M4.Shoot();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Saw.Description();
                            Saw.Shoot();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            mg240.Description();
                            mg240.Shoot();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            loop = false;
                            break;
                        }
                }
            } while (loop == true);

        }
    }
}

