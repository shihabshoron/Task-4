using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccess
{
    [Serializable]
    public class AuthenticationExeption : Exception
    {
        public AuthenticationExeption()
        {

        }
        public AuthenticationExeption(string message) : base(message)
        {
        }
        public AuthenticationExeption(string message, Exception innerException)
        : base(message, innerException)
        {
        }
        protected AuthenticationExeption(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }
    }
}
