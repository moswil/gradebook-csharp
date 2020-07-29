using System;

namespace GradeBook
{
    public class InvalidGradeException: Exception {

        public InvalidGradeException (string message): base(message) {
            
        }

    }
}