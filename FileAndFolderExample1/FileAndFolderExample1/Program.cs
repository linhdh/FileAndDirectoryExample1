namespace FileAndFolderExample1
{
    internal class Program
    {
        static readonly string _file = "C:\\Windows\\Temp\\Updater_v1.3.21.zip";
        static void Main(string[] args)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(_file));
            Console.WriteLine(Path.GetFullPath(_file));
            Console.WriteLine(Path.GetFileName(_file));
            Console.WriteLine(Path.GetDirectoryName(_file));
            Console.WriteLine(Path.Combine(Path.GetDirectoryName(_file), Path.GetFileNameWithoutExtension(_file)));
        }
    }
}