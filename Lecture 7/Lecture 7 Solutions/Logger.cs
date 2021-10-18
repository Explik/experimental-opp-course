using System.Collections.Generic;

namespace Lecture_7_Solutions
{
    public class Logger : ILogger
    {
        public List<string> Logs { get; } = new List<string>();

        public void Log(string message)
        {
            Logs.Add(message);
        }
    }
}