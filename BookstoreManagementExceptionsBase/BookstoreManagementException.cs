using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public abstract class BookstoreManagementException : SystemException
    {
        public BookstoreManagementException(string errorMessage) : base(errorMessage)
        {
        }

        public abstract List<string> GetErros();

        public abstract HttpStatusCode GetHttpStatusCode();

    }
}
