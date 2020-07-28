using System;
using System.Collections.Generic;

namespace GradeBook {

    public class Book {
        List<double> grades;
        string name;
        
        public Book (string name) {
            this.grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) {
            this.grades.Add(grade);
        }

        public Statistics ComputeStatistics() {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in this.grades) {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= this.grades.Count;
            return result;
        }

        public void ShowStatistics() {
            var result = this.ComputeStatistics();

            Console.WriteLine($"The average is {result.Average}");
            Console.WriteLine($"The minimum grade is {result.Low}");
            Console.WriteLine($"The maximum grade is {result.High}");
        }
    }
}