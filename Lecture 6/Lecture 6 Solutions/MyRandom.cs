using System;

namespace Lecture_6_Solutions
{
    public class MyRandom : IRandom
    {
        private Random random = new Random();

        public int Next()
        {
            return random.Next();
        }

        public int Next(int max)
        {
            return random.Next(max);
        }

        public int Next(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}