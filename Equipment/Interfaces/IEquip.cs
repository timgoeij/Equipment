using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public interface IEquip
    {
        void Equip();
        void ChangeBehaviour(string key);
    }
}
