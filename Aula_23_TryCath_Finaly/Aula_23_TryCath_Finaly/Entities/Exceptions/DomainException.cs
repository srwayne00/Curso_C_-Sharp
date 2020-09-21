using System;

namespace Aula_23_TryCath_Finaly.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }

    }

}
