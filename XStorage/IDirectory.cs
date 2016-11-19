namespace XStorage
{
    public interface IDirectory
    {
        string Path { get; }

        bool Exists { get; }

        void Create();

        IDirectory Subdirectory(string name);

        IFile File(string name);

        IFile[] GetFiles(string pattern);

        IDirectory[] GetDirectories(string pattern);
    }
}