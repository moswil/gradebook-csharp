using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Moses' Grade Book");
            book.AddGrade(78);
            book.AddGrade(85);
            book.AddGrade(65);
            book.ShowStatistics();
        }
    }
}
