using System;

namespace SupervisionApp.CommonModel.Exceptions
{
    public class InsufficientFactoryPermissionException : Exception
    {
        public string Username { get; set; }

        public string Factoryname { get; set; }

        public InsufficientFactoryPermissionException(string username, string factoryname)
        {
            Username = username;
            Factoryname = factoryname;
        }

        public InsufficientFactoryPermissionException(string message, string username, string factoryname) : base(message)
        {
            Username = username;
            Factoryname = factoryname;
        }

        public InsufficientFactoryPermissionException(string message, Exception innerException, string username, string factoryname) : base(message, innerException)
        {
            Username = username;
            Factoryname = factoryname;
        }
    }
}
