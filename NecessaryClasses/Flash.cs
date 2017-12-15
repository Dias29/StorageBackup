using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecessaryClasses
{
    public class Flash : Storage
    {
        //private double speedUSB3 { get; set; }
        private double _volumeSpace;
        private double temp;

        public double GetVolume()
        {
            return temp;
        }

        public void SetVolume(double volumeSpace)
        {
            _volumeSpace = volumeSpace;
        }


        public Flash(string nameDrive, double volumeSpace, double speedDrive)
        {
            SetName(nameDrive);
            _volumeSpace = volumeSpace;
            SetSpeed(speedDrive);
        }

        public override void CopyDataToDrive(double amountData)
        {
            temp = _volumeSpace;
            temp -= amountData;
        }

        public override double GetSpace()
        {
            double temp = _volumeSpace;
            return temp;
        }


        public override double EnquiryFreeSpace()
        {
            return GetVolume();
        }

        public override object GetReference()
        {
            return "Тип: Flash\nОбъем памяти: 16 ГБ\nCкорость: USB3.0 4800 Мб/с";   //Знаю, не правильно
        }
    }
}
