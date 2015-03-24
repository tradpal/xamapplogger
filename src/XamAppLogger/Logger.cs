using System;
using System.Runtime.CompilerServices;

public class Logger : ILogger
{
    private static Logger _current;
    public static Logger Current
    {
        get
        {
            if (_current == null)
                _current = new Logger();
            return _current;
        }
    }

    private IFileManager _fileManager;
    public IFileManager fileManager
    {
        get { return _fileManager; }
    }

    private Logger()
	{
       
	}

    public void Log(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string memberFile = "", [CallerLineNumber] int lineNumber = 0, LogSeverity severity = LogSeverity.Normal)
    {
        
    }

    public void Log(Exception exception, [CallerMemberName] string memberName = "", [CallerFilePath] string memberFile = "", [CallerLineNumber] int lineNumber = 0, LogSeverity severity = LogSeverity.Normal)
    {
        
    }


}
