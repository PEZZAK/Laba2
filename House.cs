
namespace Lab2
{
    public class House
    {
        private int floors;

        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public House(int floors)
        {
            this.floors = floors;
        }

        public override string ToString()
        {
            string word;
            int lastTwo = floors % 100;
            int lastOne = floors % 10;

            if (lastTwo >= 11 && lastTwo <= 14)
            {
                word = "этажами";
            }
            else if (lastOne == 1)
            {
                word = "этажом";
            }
            else if (lastOne >= 2 && lastOne <= 4)
            {
                word = "этажами";
            }
            else
            {
                word = "этажами";
            }

            return "дом с " + floors + " " + word;
        }
    }
}
