using System.IO;
using System.Linq;

namespace XStorage.NET
{
    public class XDirectory : IDirectory
    {
        private readonly DirectoryInfo _dirInfo;

        internal XDirectory(DirectoryInfo dirInfo)
        {
            _dirInfo = dirInfo;
        }

        public XDirectory(string path)
        {
            _dirInfo = new DirectoryInfo(path);
        }

        public string Path
        {
            get { return _dirInfo.FullName; }
        }

        public bool Exists
        {
            get { return _dirInfo.Exists; }
        }

        public void Create()
        {
            _dirInfo.Create();
        }

        public IDirectory Subdirectory(string path)
        {
            return new XDirectory(System.IO.Path.Combine(Path, path));
        }

        public IFile File(string path)
        {
            return new XFile(System.IO.Path.Combine(Path, path));
        }

        public IFile[] GetFiles(string pattern)
        {
            return _dirInfo.GetFiles(pattern).Select(fi => (IFile)new XFile(fi)).ToArray();
        }

        public IDirectory[] GetDirectories(string pattern)
        {
            return _dirInfo.GetDirectories(pattern).Select(di => (IDirectory)new XDirectory(di)).ToArray();
        }
    }
}