using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
            string filecontent = File.ReadAllText(fileName);
            Console.WriteLine(filecontent);
        }
        File.WriteAllText(fileName, "I am cosmic");
    }
    public void LearnFileinfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createData = fileInfo.CreationTime;

        Console.WriteLine($"File Size {size} bytes ");
        Console.WriteLine($"Created {createData}");
    }

    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }

    //Q: create a folder "Parent", create 10 subfolders in "Parent".
    //Each subfolder should contain a c# hello world program.
}