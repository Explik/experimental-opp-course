namespace Lecture_6_Solutions
{
    public class Die
    {
        private int _numOfSides;
        private IRandom _random;

        public Die(IRandom random) : this(random, 6)
        {
        }

        public Die(IRandom random, int numofSides)
        {
            _random = random;
            _numOfSides = numofSides;
        }

        public int Roll()
        {
            return _random.Next(1, _numOfSides);
        }
    }
}