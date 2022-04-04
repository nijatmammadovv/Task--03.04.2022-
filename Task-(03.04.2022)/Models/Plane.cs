using System;
using System.Collections.Generic;
using System.Text;
using Task__03._04._2022_.Interfaces;

namespace Task__03._04._2022_.Models
{
    public class Plane:Vehicle,IEngine, IWheel
    {
        private double _wingLength;
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        public double WingLength
        {
            get
            {
                return _wingLength;
            }
            set
            {
                if (value >= 2.36 || value <= 9.96)
                    _wingLength = value;
            }
        }
        public override double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0)
                    _driveTime = value;
            }
        }
        public override double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                    _drivePath = value;
            }
        }
        public double WheelThickness
        {
            get
            {
                return _wheelThickness;
            }
            set
            {
                if (value > 0)
                    _wheelThickness = value;
            }
        }
        public double HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                if (value > 0)
                    _horsePower = value;
            }
        }
        public double TankSize
        {
            get
            {
                return _tankSize;
            }
            set
            {
                if (value > 0)
                    _tankSize = value;
            }
        }
        public double CurrentOil
        {
            get
            {
                return _currentOil;
            }
            set
            {
                if (value < TankSize)
                    _currentOil = value;
            }
        }
        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (value == "Benzin" || value == "Dizel" || value == "Elektrik" || value == "Sixilmis qaz")
                    _fuelType = value;
            }
        }
       
        public Plane(double wingLength,double driveTime,double drivePath,double wheelThickness,double horsePower,double tankSize,double currentOil,string fuelType)
        {
            WingLength = wingLength;
            DriveTime  = driveTime;
            DrivePath  = drivePath;
            WheelThickness = wheelThickness;
            HorsePower = horsePower;
            TankSize   = tankSize;
            CurrentOil = currentOil;
            FuelType   = fuelType;
        }
        public double RemainOilAmount(double TankSize, double CurrentOil)
        {
            return TankSize - CurrentOil;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"WingLength:{WingLength}\n" +
                $"DriveTime:{DriveTime}\n" +
                $"DrivePath:{DriveTime}\n" +
                $"WheelThickness:{WheelThickness}\n" +
                $"HorsePower:{HorsePower}\n" +
                $"TankSize:{TankSize}\n" +
                $"CurrentOil:{CurrentOil}\n" +
                $"FuelType:{FuelType}");
        }
    }
}
