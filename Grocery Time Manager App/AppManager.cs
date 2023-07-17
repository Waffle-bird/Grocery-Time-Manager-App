using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Time_Manager_App
{
    public class AppManager
    {
        List<Employee> employees;
        Dictionary<int, List<string>> productTypes;

        //Constructor
        public AppManager()
        {
            employees = new List<Employee>();
            productTypes = new Dictionary<int, List<string>>()
            {
                {1, new List<string>(){"Juice", "Cereal", "Spreads", "Desserts" } },
                {2, new List<string>(){"Baking","Museli Bars"}},
                {3, new List<string>(){"Mexican", "Fish", "Pasta","Rice","Sauce", }}
            };
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

        public Dictionary<int, List<string>> GetProductTypes()
        {
            return productTypes;
        }

        //public int GetAisleNumbers() 
        //{
        //    return productTypes.Count;
        //}

        //public List<string> GetProductNames(int aisleNum) 
        //{ 
        //    return productTypes[aisleNum];
        //}

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
