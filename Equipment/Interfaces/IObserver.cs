using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public interface IObserver
    {
        void Notify(string key);
    }
}
