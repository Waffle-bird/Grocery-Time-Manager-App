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
            this.loaders = new List<Loader>();
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

        //Other Methods
        public void AddLoader(Loader loader)
        {
            loaders.Add(loader);
        }

        public void RemoveLoader(string shortTime)
        {
            int loaderIndex = 0;
            foreach (Loader loader in loaders)
            {
                if (loader.GetTimeIssued().ToShortTimeString().Equals(shortTime))
                {
                    loaders.RemoveAt(loaderIndex);
                    break;
                }
                loaderIndex++;
            }
        }

        public List<Loader> GetLoaders()
        {
            return this.loaders;
        }

        private int SumBoxes()
        {
            int sumBoxes = 0;
            foreach (var loader in loaders)
            {
                sumBoxes += loader.GetNumBoxes();
            }

            return sumBoxes;
        }

        public string ShiftSummary()
        {
            string time = "am";
            if (shiftTime == false)
            {
                time = "pm";
            }


            return $"Date: {date.ToShortDateString()}\n" +
                $"Time: {time}\n" +
                $"No. Boxes Completed: {SumBoxes()}";
        }

    }
}
