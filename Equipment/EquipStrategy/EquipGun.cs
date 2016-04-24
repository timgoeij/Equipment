using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class EquipGun : BaseStrategy
    {
        public EquipGun(Player player, Inventory inventory) 
            : base(player, inventory)
        {

        }

        public override void Equip()
        {
            if (inventory.Gun)
            {
                Console.WriteLine("where equip the gun clip? left hand: 1, right hand 2, head 3");

                string key = Console.ReadLine();

                //check if the key is 1 and equip the item to the left hand
                if (key == "1")
                {
                    if (player.LeftHandItem != null)
                        switchItem(player.LeftHandItem, new Gun(player, inventory));
                    else if (inventory.TempGun != null)
                        player.LeftHandItem = inventory.TempGun;
                    else
                        player.LeftHandItem = new Gun(player, inventory);

                }//check if the key is 2 and equip the item to the right hand
                else if (key == "2")
                {
                    
                    if (player.RightHandItem != null)
                        switchItem(player.RightHandItem, new Gun(player, inventory));
                    else if(inventory.TempGun != null)
                        player.RightHandItem = inventory.TempGun;
                    else
                        player.RightHandItem = new Gun(player, inventory);

                }//check if the key is 3 and equip the item to the head
                else if (key == "3")
                {
                   
                    if (player.HeadItem != null)
                        switchItem(player.HeadItem, new Gun(player, inventory));
                    else if (inventory.TempGun != null)
                        player.HeadItem = inventory.TempGun;
                    else
                        player.HeadItem = new Gun(player, inventory);

                }

                if (key == "1" || key == "2" || key == "3")
                {
                    Console.WriteLine("gun is enquipped");
                    inventory.Gun = false;
                }
            }
            else
                Console.WriteLine("gun already equipped");
        }
    }
}
