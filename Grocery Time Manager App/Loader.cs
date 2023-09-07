using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    public class Loader
    {
        private int aisle;
        private string productType;
        private DateTime timeIssued;
        private int numBoxes;
        private bool completed;

        public Loader(int aisle, string productType, DateTime timeIssued, int numBoxes)
        {
            this.aisle = aisle;
            this.productType = productType;
            this.timeIssued = timeIssued;
            this.numBoxes = numBoxes;
        }

        public int GetAisle() 
        {  
            return aisle; 
        }
        public string GetProductType() {  
            return productType; 
        }
        public DateTime GetTimeIssued() {  
            return timeIssued; 
        }
        public int GetNumBoxes() 
        { 
            return numBoxes;
        }    
    }
}
