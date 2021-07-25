using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    namespace System
    {
        public class DirectoryNotFound : ExceptionType
        {
            #region Private Value
            private const string type = "DirectoryNotFound";
            private const string code = "System1000";
            private const string description
                = "The exception that is thrown when part of a file or directory cannot be found.";
            private string target = null;
            #endregion

            #region Public Value
            public static string Type { get { return type; } }
            public static string Code { get { return code; } }
            public static string Description { get { return description; } }
            public string Target { get { return target; } }
            public string Analysis
            {
                get
                {
                    string str = "Could not find a path of the path '" + target + "'.";
                    return str;
                }
            }
            #endregion

            public DirectoryNotFound(string ExceptionTarget = null)
            {
                target = ExceptionTarget;
            }
        }
        public class FileNotFound : ExceptionType
        {
            #region Private Value
            private const string type = "FileNotFound";
            private const string code = "System1001";
            private const string description
                = "The exception that is thrown when an attempt to access a file that does not exist "
                + "on disk fails.";
            private string target = null;
            #endregion

            #region Public Value
            public static string Type { get { return type; } }
            public static string Code { get { return code; } }
            public static string Description { get { return description; } }
            public string Target { get { return target; } }
            public string Analysis
            {
                get
                {
                    string str = "Could not find file '" + target + "'.";
                    return str;
                }
            }
            #endregion

            public FileNotFound(string ExceptionTarget = null)
            {
                target = ExceptionTarget;
            }
        }
    }
    namespace Json
    {
        public class JsonReader : ExceptionType
        {
            #region
            private const string type = "JsonReader";
            private const string code = "";
            private const string description
                = "The exception thrown when an error occurs while reading JSON text.";
            // private string target = null;
            #endregion

            #region
            public static string Type { get { return type; } }
            public static string Code { get { return code; } }
            public static string Description { get { return description; } }
            // public string Target { get { return target; } }
            public static string Analysis
            {
                get
                {
                    string str = "After parsing a value an unexpected character was encountered.";
                    return str;
                }
            }
            #endregion
        }
    }
    public class ExceptionType
    {
        public static string DirectoryNotFound { get { return System.DirectoryNotFound.Type; } }
        public static string FileNotFound { get { return System.FileNotFound.Type; } }
        public static string JsonReader { get { return Json.JsonReader.Type; } }
        
        public static ExceptionType ThrowException(string type, string target = null)
        {
            ExceptionType exceptionType = new ExceptionType();
            if (type == DirectoryNotFound)
            {
                exceptionType = new System.DirectoryNotFound(target);
                goto Break;
            }
            else if (type == FileNotFound)
            {
                exceptionType = new System.FileNotFound(target);
                goto Break;
            }
            else if (type == JsonReader)
            {
                exceptionType = new Json.JsonReader();
                goto Break;
            }
            else
            {
                exceptionType = null;
            }
            Break: return exceptionType;
        }
    }
}
