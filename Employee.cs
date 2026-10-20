
namespace Lab2
{
    public class Employee
    {
        private string name;
        private Department department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public Employee(string name)
        {
            this.name = name;
            this.department = null;
        }

        public Employee(string name, Department department)
        {
            this.name = name;
            this.department = department;
        }

        public override string ToString()
        {
            if (department == null)
            {
                return name;
            }

            if (department.Head == this)
            {
                return name + " начальник отдела " + department.Title;
            }

            string headName = department.Head != null ? department.Head.Name : "не назначен";
            return name + " работает в отделе " + department.Title
                + ", начальник которого " + headName;
        }
    }
}
