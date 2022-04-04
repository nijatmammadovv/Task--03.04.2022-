using System;
using System.Collections.Generic;
using System.Text;
using Task__03._04._2022_.Interfaces;

namespace Task__03._04._2022_.Models
{
   public class Bicycle:Vehicle,IWheel,ITransmission
    {
        private string _pedalKind;
        private double _driveTime;
        private double _drivePath;
        private double _wheelThicness;
        private string _transmissionKind;
        public string PedalKind
        {
            get
            {
                return _pedalKind;
            }
            set
            {
                if (value == "Auto" || value == "With the foot")
                    _pedalKind = value;
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
                return _wheelThicness;
            }
            set
            {
                if (value > 0)
                    _wheelThicness = value;
            }
        }
        public string TransmissionKind { get ; set ; }

        public Bicycle(string pedalKind,double driveTime,double drivePath,double wheelThickness,string transmissionKind)
        {
            PedalKind = pedalKind;
            DriveTime = driveTime;
            DrivePath = drivePath;
            WheelThickness   = wheelThickness;
            TransmissionKind = transmissionKind;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PedalKind:{PedalKind}\n" +
                $"DriveTime:{DriveTime}\n" +
                $"DrivePath:{DrivePath}\n" +
                $"WheelThickness:{WheelThickness}\n" +
                $"TranmissionKind:{TransmissionKind}");
        }
    }
}
