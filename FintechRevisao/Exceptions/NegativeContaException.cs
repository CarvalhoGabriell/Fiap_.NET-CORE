using System;
using System.Collections.Generic;
using System.Text;

namespace FintechRevisao.Exceptions
{

    [Serializable]
    public class NegativeContaException : Exception
    {
        public NegativeContaException() { }
        public NegativeContaException(string message) : base(message) { }
        public NegativeContaException(string message, Exception inner) : base(message, inner) { }
        protected NegativeContaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
