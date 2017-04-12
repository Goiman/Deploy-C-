namespace Dojodachi
{
    public class DojodachiInfo
    {
        public int Fullness { get; set; }

        public int Happiness { get; set; }

        public int Meals { get; set; }

        public int Energy { get; set; }

        public DojodachiInfo()
        {
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
        }
    }
}