using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class WhiteHare : Animal
    {
       public WhiteHare(IBehavior behavior) : base(behavior)
        {
            _class = AnimalClasses.Mammalia;
            _order = AnimalOrders.Lagomorpha;
        }
    }
}
