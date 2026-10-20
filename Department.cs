using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Department
    {
        private string title;
        private Employee head;
        private List<Employee> employees;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Employee Head
        {
            get { return head; }
            set { head = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
        }

        public Department(string title)
        {
            this.title = title;
            this.head = null;
            this.employees = new List<Employee>();
        }

        public Department(string title, Employee head)
        {
            this.title = title;
            this.head = head;
            this.employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee != null && !employees.Contains(employee))
            {
                employees.Add(employee);
                employee.Department = this;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>(employees);
        }

        public List<Employee> GetColleagues(Employee employee)
        {
            List<Employee> result = new List<Employee>();

            if (employee == null || employee.Department != this)
            {
                return result;
            }

            foreach (Employee e in employees)
            {
                if (e != employee)
                {
                    result.Add(e);
                }
            }

            return result;
        }

        public override string ToString()
        {
            string headName = head != null ? head.Name : "не назначен";
            return "Отдел " + title + ", начальник: " + headName
                + ", сотрудников: " + employees.Count;
        }
    }
}
