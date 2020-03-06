using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding
{
    class Car : Vehicle
    {
        public int GetSpeed()
        {
            return (acceleration - brakeTime);
        }
    }
}
