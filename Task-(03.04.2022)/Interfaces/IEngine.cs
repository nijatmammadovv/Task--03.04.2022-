using System;
using System.Collections.Generic;
using System.Text;

namespace Task__03._04._2022_.Interfaces
{
     interface IEngine
    {
        public double HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public double RemainOilAmount(double TankSize, double CurrentOil);
    }
}
