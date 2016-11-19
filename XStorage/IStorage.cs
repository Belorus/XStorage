namespace XStorage
{
    public interface IStorage
    {
        IDirectory CreateDirectory(string path);

        IDirectory OpenDirectory(string path);

        IFile OpenFile(string path);
    }
}