
namespace Lab2
{
    public class Name
    {
        private string surname;
        private string firstName;
        private string patronymic;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public Name(string firstName)
        {
            this.firstName = firstName;
            this.surname = null;
            this.patronymic = null;
        }

        public Name(string firstName, string surname)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.patronymic = null;
        }

        public Name(string firstName, string surname, string patronymic)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public override string ToString()
        {
            string result = "";

            if (surname != null && surname != "")
            {
                result = surname;
            }

            if (firstName != null && firstName != "")
            {
                if (result != "")
                {
                    result = result + " " + firstName;
                }
                else
                {
                    result = firstName;
                }
            }

            if (patronymic != null && patronymic != "")
            {
                if (result != "")
                {
                    result = result + " " + patronymic;
                }
                else
                {
                    result = patronymic;
                }
            }

            return result;
        }
    }
}
