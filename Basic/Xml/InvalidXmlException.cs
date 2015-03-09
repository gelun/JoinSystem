using System;
using System.Text;

namespace Basic.Xml
{
    public class InvalidXmlException : ExceptionHelper
    {
        public InvalidXmlException(string message)
            : base(message)
        {
        }
    }
}
