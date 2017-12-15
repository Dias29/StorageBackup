using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecessaryClasses
{
    public class HDD : Storage
    {
        private double _speedHDD;
        private int _countOfSections;
        private int _volumeOfSections;

        public void SetSpeedHDD(double speedHDD)
        {
            _speedHDD = speedHDD;
        }

        public double GetSpeedHDD()
        {
            return _speedHDD;
        }

        public void SetCountSections(int countSections)
        {
            _countOfSections = countSections;
        }

        public int GetCountSections()
        {
            return _countOfSections;
        }

        public void SetVolumeSections(int volumeSections)
        {
            _volumeOfSections = volumeSections;
        }

        public int GetVolumeSections()
        {
            return _volumeOfSections;
        }

        public override double GetSpace()
        {
            throw new NotImplementedException();
        }

        public override void CopyDataToDrive(double amountData)
        {
            throw new NotImplementedException();
        }

        public override double EnquiryFreeSpace()
        {
            throw new NotImplementedException();
        }

        public override object GetReference()
        {
            throw new NotImplementedException();
        }

        public HDD(double speedHDD, int countSections, int volumeSections)
        {
            SetSpeedHDD(speedHDD);
            SetCountSections(countSections);
            SetVolumeSections(volumeSections);
        }
    }
}
