
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

        // Конструктор 1: только личное имя (для 4.5)
        public Name(string firstName)
        {
            this.firstName = firstName;
            this.surname = null;
            this.patronymic = null;
        }

        // Конструктор 2: имя + фамилия (для 4.5)
        public Name(string firstName, string surname)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.patronymic = null;
        }

        // Конструктор 3: все три параметра (для 1.3 и 4.5)
        public Name(string firstName, string surname, string patronymic)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public override string ToString()
        {
            string result = "";

            // Порядок: Фамилия Имя Отчество, но только заданные части
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
