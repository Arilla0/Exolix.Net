using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolix.API.Exceptions
{

    public class ExolixApiException : Exception
    {
        public ExolixApiException(string message) : base(message)
        {
        }
    }
}
