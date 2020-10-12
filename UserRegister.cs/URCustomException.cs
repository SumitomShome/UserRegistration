using System;
using System.Collections.Generic;
using System.Text;
namespace RegexUserValidation
{
    public class URCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        };
        private readonly ExceptionType type;
        public URCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
