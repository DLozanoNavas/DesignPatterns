

namespace Composite
{
    public interface IFileSystemItem
    {
        string Name { get; set; }
        long GetSize();
    }

    public abstract class FileSystemItem : IFileSystemItem
    {
        public string Name { get; set; }

        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract long GetSize();
    }

    public class Folder : FileSystemItem
    {
        private readonly List<FileSystemItem> _fileSystemItems = new();
        public Folder(string name) : base(name)
        {
        }

        public void Remove(FileSystemItem file)
        {
            _fileSystemItems.Remove(file);
        }
        
        public void Add(FileSystemItem file)
        {
            _fileSystemItems.Add(file);
        }

        public override long GetSize()
        {
            return GetSize(_fileSystemItems);
        }

        long GetSize(List<FileSystemItem> fileSystemItems)
        {
            return fileSystemItems.Sum(c => c.GetSize());
        }


    }

    public class File :  FileSystemItem
    {
        private long _size { get; }
        public File(string name, long size) : base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            return _size;
        }
    }

}
