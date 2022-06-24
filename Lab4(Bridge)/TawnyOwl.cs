using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TawnyOwl : Animal
    {
        public TawnyOwl(IBehavior behavior) : base(behavior)
        {
            _class = AnimalClasses.Aves;
            _order = AnimalOrders.Strigiformes;
        }
    }
}
