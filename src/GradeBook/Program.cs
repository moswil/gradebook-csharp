using System;

namespace GradeBook
{
    class Program 
    {
        static void Main(string[] args)
        {
            Book book = new Book("Moses' Grade Book");
            
            while(true) {
                Console.WriteLine("Please enter a grade, enter 'Q' to quit");
                var grade = Console.ReadLine();
                if (grade == "Q") {
                    break;
                } else {
                    try
                    {
                        book.AddGrade(double.Parse(grade));
                    }
                    catch (InvalidGradeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }

            book.ShowStatistics();
        }
    }
}
