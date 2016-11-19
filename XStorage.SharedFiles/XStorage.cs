using System.IO;

namespace XStorage.NET
{
    public class XStorage : IStorage
    {
        public IDirectory CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
            return OpenDirectory(path);
        }

        public IDirectory OpenDirectory(string path)
        {
            return new XDirectory(path);
        }

        public IFile OpenFile(string path)
        {
            return new XFile(path);
        }
    }
}