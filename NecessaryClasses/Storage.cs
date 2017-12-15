using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecessaryClasses
{
    public abstract class Storage
    {
        private string _nameOfDrive;
        private string _modelOfDrive;
        private double _speedOfDrive;

        public string GetName()
        {
            return _nameOfDrive;
        }

        public void SetName(string nameOfDrive)
        {
            _nameOfDrive = nameOfDrive;
        }

        public string GetModel(string modelOfDrive)
        {
            return _modelOfDrive;
        }

        public void SetModel(string modelOfDrive)
        {
            _modelOfDrive = modelOfDrive;
        }

        public double GetSpeed()
        {
            return _speedOfDrive;
        }

        public void SetSpeed(double speedOfDrive)
        {
            _speedOfDrive = speedOfDrive;
        }

        public abstract double GetSpace();
        //public abstract int GetSpace(Storage drive);
        public abstract void CopyDataToDrive(double amountData);
        public abstract double EnquiryFreeSpace();
        public abstract object GetReference(); 



    }
}
