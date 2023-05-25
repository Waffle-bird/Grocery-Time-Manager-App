using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    internal class AppManager
    {
        List<Employee> employees;

        //Constructor
        public AppManager()
        {
            employees = new List<Employee>();
        }

        //Get Methods
        public string GetPreviousEmployeeName()
        {
            return employees[employees.Count - 1].GetName();
        }

        public int GetPreviousEmployeeId()
        {
            return employees[employees.Count - 1].GetId();
        }


        //Set Methods


        //Other Methods
        private int NumEmployees()
        {
            return employees.Count;
        }

        public Employee RecallPreviousEmployee()
        {
            return employees[employees.Count - 1];
        }

        public void GenerateEmployee(int id, string name)
        {
            Employee employee = new Employee(id, name);

            employees.Add(employee);
        }

    }
}
