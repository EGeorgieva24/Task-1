class Test
{
    public static void Main()
    {
        string path = @"D:\Programming guysss";
        DirectoryInfo Directory = new DirectoryInfo(path);
        Directory.Create();

        var file = $@"{path}\ElitzaG.txt";

        Console.WriteLine("Write something");
        string write = Console.ReadLine();

        

        if (write.Contains("M"))
        {
            File.WriteAllText(file, write);
            Console.WriteLine($"Input '{write}' written to .");
        }
        else
        {
            Console.WriteLine($"Input does not contain 'M', file remains empty.");
        }
        Console.WriteLine(File.GetCreationTime(file));
        Console.WriteLine(File.GetLastAccessTime(file));
        Console.WriteLine(Path.GetFileName(file));

        Console.WriteLine(Path.GetDirectoryName(file));
    }
}
