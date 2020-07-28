using System;
using Xunit;

using GradeBook;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(60.3);
            book.AddGrade(70.5);
            book.AddGrade(77.6);

            // act
            var result = book.ComputeStatistics();

            // assert
            Assert.Equal(60.3, result.Low);
            Assert.Equal(77.6, result.High);
            Assert.Equal(69.5, result.Average, 1);
        }
    }
}
