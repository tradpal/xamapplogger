using System;

public interface IFileManager
{
    string FileName { get; }

    void Flush();
    void Append(string message);
    void Save();
}
