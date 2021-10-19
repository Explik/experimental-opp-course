﻿using System;

namespace Lecture_8_Solutions
{
    public delegate void InputHandler(string input);

    public class ConsoleView
    {
        public event InputHandler Input;

        public void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    break;
                else Input?.Invoke(line);
            }
        }
    }
}