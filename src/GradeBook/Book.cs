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
            if (grade <= 100 && grade >= 0) {
                this.grades.Add(grade);
            } else {
                throw new InvalidGradeException($"Invalid Grade {grade}");
            }
            
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

            switch (result.Average)
            {   
                case var d when d >= 90:
                    result.LetterGrade = 'A';
                    break;

                case var d when d >= 80:
                    result.LetterGrade = 'B';
                    break;

                case var d when d >= 70:
                    result.LetterGrade = 'C';
                    break;

                case var d when d >= 60:
                    result.LetterGrade = 'D';
                    break;                
                
                default:
                    result.LetterGrade = 'F';
                    break;

            }
            return result;
        }

        public void ShowStatistics() {
            var result = this.ComputeStatistics();

            Console.WriteLine($"The average is {result.Average}");
            Console.WriteLine($"The minimum grade is {result.Low}");
            Console.WriteLine($"The maximum grade is {result.High}");
            Console.WriteLine($"The average grade is {result.LetterGrade}");
        }
    }
}