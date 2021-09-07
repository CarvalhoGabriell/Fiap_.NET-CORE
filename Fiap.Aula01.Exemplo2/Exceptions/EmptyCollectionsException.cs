using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo2.Exceptions
{
    // digitar exception + tab +tab  para gerar os contrutors do formato de Exceptions
    [Serializable]
    public class EmptyCollectionException : Exception
    {
        public EmptyCollectionException() { }
        public EmptyCollectionException(string message) : base(message) { }
        public EmptyCollectionException(string message, Exception inner) : base(message, inner) { }
        protected EmptyCollectionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
