using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
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
            Assert.Equal('D', result.LetterGrade);
        }

        [Fact]
        public void AddGradeThrowsExceptionWhenGradeOutOfRange() {
            var book = new Book("Book 1");
            var grade = 105;
            var ex = Assert.Throws<InvalidGradeException>(() => book.AddGrade(grade));
            Assert.Equal($"Invalid Grade {grade}", ex.Message);
        }
    }
}
