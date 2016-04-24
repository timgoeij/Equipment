using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public abstract class BaseStrategy : IEquip
    {
        //the player and the inventory
        protected Player player;
        protected Inventory inventory;

        public BaseStrategy(Player player, Inventory inventory)
        {
            this.player = player;
            this.inventory = inventory;
        }

        //equip function
        public abstract void Equip();

        //switch items
        protected void switchItem(Item equipped, Item newItem)
        {
            if (equipped is Rock)
            {
                inventory.Rock = true;
                Console.WriteLine("rock is unequipped");
            }
                
            if (equipped is FlashLight)
            {
                inventory.FlashLight = true;
                Console.WriteLine("flashlight is unequipped");
            }
                
            if (equipped is AmmoClip)
            {
                inventory.AmmoClip = true;
                Console.WriteLine("ammo clip is unequipped");
            }
                
            if (equipped is Hat)
            {
                inventory.Hat = true;
                Console.WriteLine("hat is unequipped");
            }
                
            if (equipped is Gun)
            {
                inventory.Gun = true;
                Console.WriteLine("gun is unequipped");
            }
                

            equipped = newItem;
        }

        //change the behaviour of the equip function
        public void ChangeBehaviour(string key)
        {
            switch (key)
            {
                case "a":
                    inventory.EquipBehaviour = new EquipAmmoClip(player, inventory);
                    break;
                case "h":
                    inventory.EquipBehaviour = new EquipHat(player, inventory);
                    break;
                case "f":
                    inventory.EquipBehaviour = new EquipFlashLight(player, inventory);
                    break;
                case "g":
                    inventory.EquipBehaviour = new EquipGun(player, inventory);
                    break;
                case "r":
                    inventory.EquipBehaviour = new EquipRock(player, inventory);
                    break;
            }
        }
    }
}
