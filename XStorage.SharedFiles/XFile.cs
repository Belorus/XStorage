using System;
using System.IO;

namespace XStorage.NET
{
    public class XFile : IFile
    {
        private readonly FileInfo _fileInfo;

        internal XFile(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public XFile(string path)
        {
            _fileInfo = new FileInfo(path);
        }

        public bool Exists
        {
            get { return _fileInfo.Exists; }
        }

        public long Size
        {
            get { return _fileInfo.Length; }
        }

        public string Path
        {
            get { return _fileInfo.FullName; }
        }

        public DateTime LastWriteTime
        {
            get { return _fileInfo.LastWriteTime; }
        }

        public DateTime CreationTime
        {
            get { return _fileInfo.CreationTime; }
        }

        public Stream Open(XFileMode mode)
        {
            switch (mode)
            {
                case XFileMode.Read:
                    return _fileInfo.OpenRead();
                case XFileMode.Write:
                    var stream = _fileInfo.OpenWrite();
                    stream.SetLength(0);
                    return stream;
                case XFileMode.ReadWrite:
                    return _fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                default:
                    throw new NotSupportedException();
            }
        }

        public void Delete()
        {
            if (_fileInfo.Exists)
            {
                _fileInfo.Delete();
            }
        }

        public void DeleteSafe()
        {
            try
            {
                Delete();
            }
            catch
            {
            }
        }
    }
}