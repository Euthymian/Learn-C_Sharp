static class File_n_Directory
{
    public static void Run()
    {
        string srcPath = @"TextFile\source.txt";
        string destPath = @"TextFile\destination.txt";
        bool overwrite = true;
        // The '@' symbol is used to make compiler take the string as it is

        // ------------------------------------------------

        // File class provides static methods for creating, copying, deleting, moving, and opening files

        File.Copy(srcPath, destPath, overwrite);
        // If destination file doesnt exist, it will be created automatically
        // If we dont allow overwrite, an exception will be thrown if the destination file already exists

        File.Delete(destPath);
        // Wont throw exception if the file doesnt exist

        System.Console.WriteLine(File.Exists(destPath));

        // ------------------------------------------------

        // FileInfo class allows us to create an instance of a file
        FileInfo srcFile = new FileInfo(srcPath);
        srcFile.CopyTo(destPath, overwrite);
        System.Console.WriteLine("Source file extension: " + srcFile.Extension);
        System.Console.WriteLine("Size of source file: " + srcFile.Length + " bytes");

        FileInfo destFile = new FileInfo(destPath);
        destFile.Delete();
        System.Console.WriteLine(destFile.Exists);

        // ------------------------------------------------

        // Directory class provides static methods for creating, moving, and deleting directories
        string sourcePath = @"..\HTML";
        string destinationPath = @"TextFile\HTML";
        Directory.CreateDirectory(destinationPath);
        // Folder wont be created if it already exists
        System.Console.WriteLine(Directory.GetDirectories(sourcePath)[0]);
        System.Console.WriteLine(Directory.GetFiles(sourcePath).Length);

        string s = @"TextFile\haha\";
        bool recursive = true;
        Directory.Delete(s, recursive);
        // If we dont provide recursive, an exception will be thrown when the folder is not empty

        // ------------------------------------------------

        // DirectoryInfo class allows us to create an instance of a directory

        // ------------------------------------------------  
    }
}