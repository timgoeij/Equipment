using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class AmmoClip : Item
    {
        private int bullets;

        public int Bullets
        {
            get { return bullets; }
            set { bullets = value; }
        }


        public AmmoClip(Player player, Inventory inventory) : base(player, inventory)
        {
            bullets = 20;
        }
    }
}
