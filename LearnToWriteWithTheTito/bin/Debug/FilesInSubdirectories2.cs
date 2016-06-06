// Files in subdirectories
// V1: GetFiles + GetDirectories

using System;
using System.IO;

public class FilesInSubdirectories1
{
    public static void ShowDirectory(string name)
    {
        DirectoryInfo dir = new DirectoryInfo(name);
        FileInfo[] file = dir.GetFiles();
        for (int i = 0; i < file.Length; i++)
        {
            if(file[i].FullName.Substring(file[i].FullName.Length - 5) == 
                    ".meca")
                Console.WriteLine(file[i].FullName.Substring(
                        file[i].FullName.Length - 11));
        }
    }
    public static void Main()
    {
        ShowDirectory(".");
    }
}
