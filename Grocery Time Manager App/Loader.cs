using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    internal class Loader
    {
        private int aisle;
        private string productType;
        private DateTime timeIssued;
        private int numBoxes;

        public Loader(int aisle, string productType, DateTime timeIssued, int numBoxes)
        {
            this.aisle = aisle;
            this.productType = productType;
            this.timeIssued = timeIssued;
            this.numBoxes = numBoxes;
        }
    }
}
