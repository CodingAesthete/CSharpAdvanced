﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.CarEngineAndTires
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }
}
