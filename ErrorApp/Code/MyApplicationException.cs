using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorApp.Code
{
    [Serializable]
    public class MyApplicationException : Exception
    {
        public MyApplicationException()
            : base("This is our exception, there are many like it but this one is ours.  And that makes it special: ") { }
        public MyApplicationException(string message)
            : base("This is our exception, there are many like it but this one is ours.  And that makes it special: " + message) { }
        public MyApplicationException(string message, Exception innerException)
            : base("This is our exception, there are many like it but this one is ours.  And that makes it special: " + message, innerException) { }
    }
}