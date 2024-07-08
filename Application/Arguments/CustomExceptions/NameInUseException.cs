using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public class NameInUseException : Exception
    {
        public NameInUseException(string message) : base(message)
        { }
    }
}
