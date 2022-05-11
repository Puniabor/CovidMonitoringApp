using System;
using System.Collections.Generic;
using System.Text;

namespace Covid_Monitoring_System
{
    class BusinessLocation
    {
        private string businessName;

        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }

        private string branchCode;

        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }

        private int maximumCapacity;

        public int MaximumCapacity
        {
            get { return maximumCapacity; }
            set { maximumCapacity = value; }
        }

        private int visitorsNow;

        public int VisitorsNow
        {
            get { return visitorsNow; }
            set { visitorsNow = value; }
        }

        public BusinessLocation() { }
        public BusinessLocation(string bn,string bc,int mc)
        {
            BusinessName = bn;
            BranchCode = bc;
            MaximumCapacity = mc;
        }

        public bool IsFull()
        {
            if (visitorsNow >= MaximumCapacity)
            {
                return true;
            }
            else { return false; }
        }

        public override string ToString()
        {
            return $"Business Location: {BusinessName} Code:{BranchCode} Max Cap:{MaximumCapacity} Visitors Now:{VisitorsNow}";
        }
    }
}
