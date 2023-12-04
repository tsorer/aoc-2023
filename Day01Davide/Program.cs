﻿using AocShared;

namespace Day01Davide
{
    class Program
    {
        static void Main() {
            FileReader fileReader = new();

            CalibrationReader calibrationReader = new CalibrationReader(fileReader.Lines);
            Console.WriteLine($"Summe aller Zahlen ist {calibrationReader.GetSum}");
        }

    }
}
