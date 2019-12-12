using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [Serializable]
    public class ConnectionAlreadyOpendException : Exception
    {
        public ConnectionAlreadyOpendException()
        {

        }
        public ConnectionAlreadyOpendException(string message) : base(message)
        {
        }
        public ConnectionAlreadyOpendException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
        protected ConnectionAlreadyOpendException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }
    }
}
