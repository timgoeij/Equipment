using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Gun : Item
    {
        //ammo clip of the gun
        private AmmoClip ammo;

        //behaviour of the gun
        private IGun gunBehaviour;

        //property
        public AmmoClip Ammo
        {
            get { return ammo; }
            set { ammo = value; }
        }

        public Gun(Player player, Inventory inventory) : base(player, inventory)
        {
            ammo = null;
        }

        public override void Update()
        {
            Console.WriteLine("what to do with the gun: 1 single shot, 2 automatic shot, 3 reload");

            string key = Console.ReadLine();

            //check the key and give the gun his behaviour
            if (key == "1")
                gunBehaviour = new SingleShot();
            else if (key == "2")
                gunBehaviour = new AutomaticShot();
            else if (key == "3")
                gunBehaviour = new Reload();

            if (key == "1" || key == "2" || key == "3")
                performAction();

        }

        //perform the action of the behaviour
        private void performAction()
        {
            gunBehaviour.Action(this, player);
        }
    }
}
