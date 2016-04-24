using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class AutomaticShot : IGun
    {
        public void Action(Gun gun, Player player)
        {
            //check if the gun has an ammoclip and more than zero bullets
            if (gun.Ammo != null && gun.Ammo.Bullets > 0)
            {
                //check if the gun has more than five bullets
                if (gun.Ammo.Bullets >= 5)
                {
                    int count = 5;
                    //fire five bullets
                    while(count > 0)
                    {
                        Console.WriteLine("bullet fired");
                        gun.Ammo.Bullets -= 1;
                        count -= 1;
                    }

                    Console.WriteLine(gun.Ammo.Bullets + " bullets left");
                }
                else
                {
                    int count = gun.Ammo.Bullets;
                    //fire rest of the bullets
                    while (count > 0)
                    {
                        Console.WriteLine("bullet fired");
                        gun.Ammo.Bullets -= 1;
                        count -= 1;
                    }

                    Console.WriteLine("gun is out of ammo");
                }
            }
            else
                Console.WriteLine("not enough ammo to shoot");
        }
    }
}
