using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Exceptions
{
    internal class LibraryFilepathNotFoundException : Exception
    {
        public LibraryFilepathNotFoundException()
        {
        }

        public LibraryFilepathNotFoundException(string? message) : base(message)
        {
        }

        public LibraryFilepathNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
