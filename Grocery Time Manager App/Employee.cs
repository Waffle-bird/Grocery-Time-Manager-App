using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    internal class Employee
    {
        private int ID;
        private string Name;
        private List<Shift> Shifts;

        public Employee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shifts = new List<Shift>();
        }

        //Get Methods
        public string GetName()
        {
            return this.Name;
        }

        public int GetId()
        {
            return this.ID;
        }

        //Set Methods

         


    }
}
