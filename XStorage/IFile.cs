using System;
using System.IO;

namespace XStorage
{
    public interface IFile
    {
        bool Exists { get; }

        long Size { get; }

        Stream Open(XFileMode mode);

        void Delete();

        string Path { get; }

        DateTime LastWriteTime { get; }

        DateTime CreationTime { get; }

        void DeleteSafe();
    }
}