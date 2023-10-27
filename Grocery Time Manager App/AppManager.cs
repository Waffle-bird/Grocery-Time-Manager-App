using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grocery_Time_Manager_App
{
    public class AppManager
    {
        private List<Employee> employees;
        Dictionary<int, List<string>> productTypes;

        //Constructor
        public AppManager()
        {
            employees = new List<Employee>();

            productTypes = new Dictionary<int, List<string>>()
            {
                {1, new List<string>(){"Juice", "Cereal", "Spreads", "Desserts" } },
                {2, new List<string>(){"Sugar", "Baking","Museli Bars"}},
                {3, new List<string>(){"Mexican", "Fish", "Pasta","Rice","Sauce", }}
            };
        }

        //Get Methods
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> GetEmployees(DateTime searchDate)
        {
            List<Employee> foundEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.CheckShift(searchDate.ToShortDateString()))
                {
                    foundEmployees.Add(employee);
                }
            }
            return foundEmployees;
        }

        public string GetPreviousEmployeeName()
        {
            return employees[employees.Count - 1].GetName();
        }

        public int GetPreviousEmployeeId()
        {
            return employees[employees.Count - 1].GetId();
        }

        public int NumEmployees()
        {
            return employees.Count;
        }

        public Dictionary<int, List<string>> GetProductTypes()
        {
            return productTypes;
        }

        //Set Methods





        //Other Methods


        public Employee RecallPreviousEmployee()
        {
            return employees[employees.Count - 1];
        }

        public Employee RecallSelectedEmployee(int id)
        {
            return employees[FindEmployeeIndex(id)];
        }

        public void AddShift(int id, Shift newShift)
        {
            employees[FindEmployeeIndex(id)].AddShift(newShift);
        }

        public List<string> AssignableEmployees(DateTime todayDate)
        {
            List<string> employees = new List<string>();
            bool am = true;
            if (todayDate.ToString("tt").ToLower().Equals("pm"))
            {
                am = false;
            }

            foreach (Employee employee in CurrentlyWorkingEmployees(todayDate.ToShortDateString(), am))
            {
                employees.Add($"{employee.GetId()} {employee.GetName()}");
            }

            return employees;
        }


        private int FindEmployeeIndex(int id)
        {
            //Checks the id held within the employee object against the index of the same id
            //held in the employeeList to find the index of the desired employee
            for (int employeeIndex = 0; employeeIndex < employees.Count; employeeIndex++)
            {
                if (employees[employeeIndex].GetId()== id)
                {
                    return employeeIndex;
                }
            }

            return -1;
        }

        public void GenerateEmployee(int id, string name)
        {
            Employee employee = new Employee(id, name);

            employees.Add(employee);
        }


        //Reads all lines from the SavedEmployees.txt file. Then splits the content of the lines on each "," into seperate tokens.
        //Then adds and employee to the employees list with the ID and name specified
        public void LoadEmployees()
        {
            string textFile = "SavedEmployees.txt";
            string[] lines = File.ReadAllLines(textFile);

            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');

                employees.Add(new Employee(Convert.ToInt32(tokens[0]), tokens[1]));
            }
        }

        public List<Employee> CurrentlyWorkingEmployees(string shortDate, bool shiftTime)
        {
            //Checks to see if an employee in the employee list has a matching shift in their personal shifts list.
            //If true, then they do have a shift that matches with the selected date and time, therefore they are working
            //and added to the workingEmployees list.
            List<Employee> workingEmployees = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.CheckShift(shortDate, shiftTime))
                {
                    workingEmployees.Add(employee);
                }
            }

            return workingEmployees;
        }

        public List<Employee> NotWorkingEmployees (string shortDate, bool shiftTime)
        {
            //Checks to see if an employee in the employee list has a matching shift in their personal shifts list.
            //If false, then they do not have a shift that matches with the selected date and time, therefore they are  not working
            //and added to the notWorkingEmployees list.

            List<Employee> notWorkingEmployees = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (!employee.CheckShift(shortDate, shiftTime))
                {
                    notWorkingEmployees.Add(employee);
                }
            }

            return notWorkingEmployees;
        }

        public void RemoveEmployeeShift(int id, string shortDate, bool shiftTime)
        {
            employees[FindEmployeeIndex(id)].RemoveShift(shortDate, shiftTime);
        }

        public void AddLoader(int id, DateTime date, bool time, Loader loader)
        {
            employees[FindEmployeeIndex(id)].AddLoader(date, time, loader);

        }
        
        public void RemoveLoader(int id, DateTime shiftDate, DateTime loaderTime, bool time)
        {
            employees[FindEmployeeIndex(id)].RemoveLoader(shiftDate, loaderTime, time);
        }

        public List<Loader> GetAssignedLoaders(string shortDate, bool shiftTime, int id)
        {
            return employees[FindEmployeeIndex(id)].GetAssignedLoaders(shortDate, shiftTime);
        }

    }
}
