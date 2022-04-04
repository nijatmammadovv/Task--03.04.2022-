using System;
using System.Collections.Generic;
using System.Text;
using Task__03._04._2022_.Interfaces;

namespace Task__03._04._2022_.Models
{
    public class Car : Vehicle, IEngine, ITransmission, IWheel
    {
        private int _doorCount;
        private string _winCode;
        private double _driveTime;
        private double _drivePath;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private string _transmissionKind;
        private double _wheelThickness;
        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value > 0 || value <= 5)
                    _doorCount = value;
            }
        }
       
        public string WinCode { get; set; }
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
                return _driveTime;
            }
            set
            {
                if (value > 0)
                    _drivePath = value;
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
        public string TransmissionKind { get; set; }
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

        public Car(int doorCount, string winCode, double driveTime, double drivePath, double horsePower, double tankSize, double currentOil, string fuelType, string transmissionKind, double wheelThickness)
        {
            DoorCount = doorCount;
            WinCode = winCode;
            DriveTime = driveTime;
            DrivePath = drivePath;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            TransmissionKind = transmissionKind;
            WheelThickness = wheelThickness;
        }
        public double RemainOilAmount(double TankSize,double CurrentOil)
        {
            return TankSize - CurrentOil;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"DoorCount:{DoorCount}\n" +
                $"WinCode:{WinCode}\n" +
                $"DriveTime:{DriveTime}\n" +
                $"DrivePath:{DrivePath}\n" +
                $"HorsePower:{HorsePower}\n" +
                $"TankSize:{TankSize}\n" +
                $"CurrenOil:{CurrentOil}\n" +
                $"FuelType:{FuelType}\n" +
                $"TransmissionKind:{TransmissionKind}\n" +
                $"WheelThickness:{WheelThickness}");
        }
    }
}
