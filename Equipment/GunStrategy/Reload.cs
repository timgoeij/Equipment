using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Reload : IGun
    {
        public void Action(Gun gun, Player player)
        {
            /*check if there is ammo in one of the hands and 
              reload the gun and unequipped the ammo clip from the hand*/
            if (gun.Ammo == null && player.LeftHandItem is AmmoClip)
            {
                gun.Ammo = (AmmoClip)player.LeftHandItem;
                player.LeftHandItem = null;
                Console.WriteLine("gun is reloaded");
            }
            else if (gun == null && player.RightHandItem is AmmoClip)
            {
                gun.Ammo = (AmmoClip)player.RightHandItem;
                player.RightHandItem = null;
                Console.WriteLine("gun is reloaded");
            }
            else
                Console.WriteLine("no ammo clip equipped");
        }
    }
}
