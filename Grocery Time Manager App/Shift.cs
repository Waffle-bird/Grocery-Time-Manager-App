using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    public class Shift
    {
        private List<Loader> loaders;
        private bool shiftTime;
        private DateTime date;

        public Shift(bool shiftTime, DateTime date)
        {
            this.shiftTime = shiftTime;
            this.date = date;
        }

        //Get Methods

        public string GetShortDate() 
        {
            return date.ToShortDateString();
        }

        public bool GetShiftTime()
        {
            return shiftTime;
        }
    }
}
