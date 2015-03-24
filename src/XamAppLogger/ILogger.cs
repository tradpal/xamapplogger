using System;

public interface ILogger
{
    IFileManager fileManager { get; }

    void Log(string message, string memberName = "", string memberFile = "", int lineNumber = 0, LogSeverity severity = LogSeverity.Normal);
    void Log(Exception exception, string memberName = "", string memberFile = "", int lineNumber = 0, LogSeverity severity = LogSeverity.Normal);
}