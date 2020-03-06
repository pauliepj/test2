using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding
{
    class Vehicle
    {
        public int acceleration;
        protected int brakeTime;

        public void Brake(int b)
        {
            brakeTime = b;


        }
        public void Acceleration(int a)
        {
            acceleration = a;
        }
    }

}
