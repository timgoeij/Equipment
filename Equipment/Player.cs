using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Player
    {
        //item places to equip an item
        private Item leftHandItem = null;
        private Item rightHandItem = null;
        private Item headItem = null;

        //inventory as the observer
        private IObserver inventory;

        public Item LeftHandItem
        {
            get { return leftHandItem; }
            set { leftHandItem = value; }
        }

        public Item RightHandItem
        {
            get { return rightHandItem; }
            set { rightHandItem = value; }
        }

        public Item HeadItem
        {
            get { return headItem; }
            set { headItem = value; }
        }

        public Player()
        {
            //get an instance of th 
            inventory = Inventory.getInstance(this);
        }

        public void Update()
        {
            //get the key that is pressed
            string keyCode = Console.ReadLine();
            Console.WriteLine("");

            //notify the inventory
            inventory.Notify(keyCode);

            //update the items in the hand if its not null
            if (leftHandItem != null)
                leftHandItem.Update();

            if (rightHandItem != null)
                rightHandItem.Update();
        }
    }
}
