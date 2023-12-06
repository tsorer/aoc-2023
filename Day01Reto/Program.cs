using System;
using System.IO;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanz von CalibrationChecker erstellen
            CalibrationChecker checker = new CalibrationChecker();
            
           //Pfad setzen und alle Lines einlesen
            string currentDirectory = Directory.GetCurrentDirectory();

            string path = currentDirectory+"\\data\\data.txt";
            string[] lines = File.ReadAllLines(path);
           
            int sum = checker.CalculateSum(lines);


             Console.WriteLine("Die Summe der Calibration-Werte lautet:"+sum);

        } 
    }
    
} 