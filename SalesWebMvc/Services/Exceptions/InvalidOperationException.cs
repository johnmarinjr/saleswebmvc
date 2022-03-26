using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class InvalidOperationException : ApplicationException
    {
        public InvalidOperationException(string message) : base(message)
        {

        }
    }
}