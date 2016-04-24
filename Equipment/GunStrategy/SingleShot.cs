using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class SingleShot : IGun
    {
        public void Action(Gun gun, Player player)
        {
            //check if the gun has an ammoclip and more than zero bullets
            if (gun.Ammo != null && gun.Ammo.Bullets > 0)
            {
                gun.Ammo.Bullets -= 1;
                Console.WriteLine("single bullet fired");
                Console.WriteLine("");
                Console.WriteLine(gun.Ammo.Bullets + "bullets left");
            }
            else
                Console.WriteLine("not enough ammo to shoot");
        }
    }
}
