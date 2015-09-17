using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternExample
{
    public abstract class Dash
    {
        protected CarComputer computer;

        public double GetSpeed(CarComputer computer)
        {
            return computer.CurentSpeed();
        }
    }
}
