using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grocery_Time_Manager_App
{
    public class Employee
    {
        private int id;
        private string name;
        private List<Shift> shifts;

        public Employee(int ID, string Name)
        {
            this.id = ID;
            this.name = Name;
            this.shifts = new List<Shift>();
        }

        //Get Methods
        public string GetName()
        {
            return this.name;
        }

        public int GetId()
        {
            return this.id;
        }

        public bool CheckShift(string shortDate, bool shiftTime)
        {
            foreach (Shift shift in shifts)
            {
                if (shift.GetShortDate().Equals(shortDate) && shiftTime == shift.GetShiftTime()) 
                {
                    return true;
                }             
            }
            return false;
        }

        //Set Methods

         public void AddShift(Shift newShift)
        {
            this.shifts.Add(newShift);
        }


        public int FindShiftIndex(string shortDate, bool shiftTime)
        {
            //Finds a shift with the same unique identifiers (shortDate and shiftTime) in the shifts list
            int shiftIndex = 0;
            foreach (Shift shift in shifts)
            {
                if (shift.GetShortDate().Equals(shortDate) && shiftTime == shift.GetShiftTime())
                {
                    return shiftIndex;
                }
                shiftIndex++;
            }

            return -1;
        }

        public string GetIdName()
        {
            return id + " " + name;

            
        }

        public void RemoveShift(string shortDate, bool shiftTime)
        {
            shifts.RemoveAt(FindShiftIndex(shortDate, shiftTime));
        }

        public void AddLoader(DateTime date, bool time, Loader loader)
        {
            shifts[FindShiftIndex(date.ToShortDateString(), time)].AddLoader(loader);
        }

        public void RemoveLoader(DateTime shiftDate, DateTime loaderTime, bool time)
        {
            bool isAm = true;
            if (shiftDate.ToString("tt").Equals("pm"))
            {
                isAm = false;
            }

            MessageBox.Show(FindShiftIndex(shiftDate.ToShortDateString(), time) + "");
            shifts[FindShiftIndex(shiftDate.ToShortDateString(), isAm)].RemoveLoader(loaderTime.ToShortTimeString());

        }

        public List<Loader> GetAssignedLoaders(string shortDate, bool shiftTime)
        {
            return shifts[FindShiftIndex(shortDate, shiftTime)].GetLoaders();
        }
    }
}
