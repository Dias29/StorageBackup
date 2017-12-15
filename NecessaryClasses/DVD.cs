using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecessaryClasses
{
    public class DVD : Storage
    {
        private string _nameDisk;
        private double readWriteSpeed;
       // private double oneSide = 4700;
        private double doubleSide;
        private double temp;

        public void SetNameDisk(string nameDisk)
        {
            _nameDisk = nameDisk;
        }

        public string GetNameDisk()
        {
            return _nameDisk;
        }

        public void SetSpeedDisk(double speedDisk)
        {
            readWriteSpeed = speedDisk;
        }

        public double GetSpeeDisk()
        {
            return readWriteSpeed;
        }

        //public double GetOneSide()
        //{
        //    return oneSide;
        //}

        public double GetDoubleSide()
        {
            return temp;
        }

        public void SetDoubleSide(double size)
        {
            doubleSide = size;
        }

        public DVD(string nameDisk, double side, double speed)
        {
            SetNameDisk(nameDisk);
            SetSpeedDisk(speed);
            doubleSide = side;
            //if(side == 0)
            //{
            //    side = oneSide; 
            //}
            //else
            //{
            //    side = doubleSide;
            //}

        }

        public override void CopyDataToDrive(double amountData)
        {
            temp = doubleSide;
            temp -= amountData;
        }

        public override double GetSpace()
        {
            double temp = doubleSide;
            return temp;
        }

        public override double EnquiryFreeSpace()
        {
            return GetDoubleSide();
        }

        public override object GetReference()
        {
            return "Тип: DVD диск\nПамять: 9 ГБ\n"+"Скорость чтения/записи: "+GetSpeeDisk();
        }



    }
}
