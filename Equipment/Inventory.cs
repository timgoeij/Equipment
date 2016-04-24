using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Inventory : IObserver
    {
        private static Inventory instance;

        //items in inventory are true, equipped items are false
        private bool gun = true;
        private bool ammoClip = true;
        private bool rock = true;
        private bool flashLight = true;
        private bool hat = true;

        //behaviour of the equip function
        private IEquip equipBehaviour;

        //temperory gun variable
        private Gun tempGun = null;

        //properties
        public IEquip EquipBehaviour
        {
            set { equipBehaviour = value; }
        }

        public Gun TempGun
        {
            get { return tempGun; }
            set { tempGun = value; }
        } 

        public bool Gun
        {
            get { return gun; }
            set { gun = value; }
        }

        public bool AmmoClip
        {
            get { return ammoClip; }
            set { ammoClip = value; }
        }

        public bool Rock
        {
            get { return rock; }
            set { rock = value; }
        }

        public bool FlashLight
        {
            get { return flashLight; }
            set { flashLight = value; }
        }

        public bool Hat
        {
            get { return hat; }
            set { hat = value; }
        }

        //player
        private Player player;

        //private constructor because inventory is a singleton
        private Inventory(Player player)
        {
            this.player = player;
            equipBehaviour = new EquipFlashLight(player, this);
        }

        //get an instance of inventory
        public static Inventory getInstance(Player player)
        {
            if (instance == null)
                instance = new Inventory(player);

            return instance;
        }

        //notify function because inventory is a observer too
        public void Notify(string key)
        {
            //change te behaviour of the equip function
            equipBehaviour.ChangeBehaviour(key);

            //perform the equip function
            performEquip();
        }

        private void performEquip()
        {
            equipBehaviour.Equip();
        }
    }
}
