 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;
using System.IO;
using System.Reflection;
using Lab4;

namespace Lab4
{
    public class EmployeeDB
    {
        private SQLiteConnection database;

        public EmployeeDB()
        {
            database = new SQLiteConnection(setups.DatabasePath);
            database.CreateTable<Employee>();
        }

        public int SaveEmployee()
        {
            var lastEmployee = database.Table<Employee>().OrderByDescending(e => e.Id).FirstOrDefault();
            return lastEmployee != null ? lastEmployee.Id + 1 : 1;
        }
        
        public void AddEmployee(Employee employee)
        {
            database.Insert(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            database.Delete(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            database.Update(employee);
        }

        public List<Employee> GetEmployees()
        {
            return database.Table<Employee>().ToList();
        }

        public Employee GetEmployee(int id)
        {
            return database.Get<Employee>(id);
        }

        public void Dispose()
        {
            database.Dispose();
        }
    }
}