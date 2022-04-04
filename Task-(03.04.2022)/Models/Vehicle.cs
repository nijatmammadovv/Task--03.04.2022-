using System;
using System.Collections.Generic;
using System.Text;

namespace Task__03._04._2022_.Models
{
    public abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }

        public double AverageSpeed(double DriveTime, double DrivePath)
        {
            return DrivePath / DriveTime;
        }
        public abstract void ShowInfo();
    }
}
