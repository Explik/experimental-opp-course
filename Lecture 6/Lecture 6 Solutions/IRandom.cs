namespace Lecture_6_Solutions
{
    public interface IRandom
    {
        int Next();

        int Next(int max);

        int Next(int min, int max);
    }
}