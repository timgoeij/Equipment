using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public abstract class Item
    {
        //player and inventory
        protected Player player;
        protected Inventory inventory;

        public Item(Player player, Inventory inventory)
        {
            this.player = player;
            this.inventory = inventory;
        }

        //update function is virtual because not every item used has an update function
        public virtual void Update()
        {

        }
    }
}