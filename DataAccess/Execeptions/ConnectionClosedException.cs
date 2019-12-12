using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [Serializable]
    public class ConnectionClosedException : Exception
    {
        public ConnectionClosedException()
        {

        }
        public ConnectionClosedException(string message) : base(message)
        {
        }
        public ConnectionClosedException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
        protected ConnectionClosedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }
    }
}
