using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Демонстрация Facade ---
        Console.WriteLine("=== Facade demo ===");
        AudioSystem audio = new AudioSystem();
        VideoProjector video = new VideoProjector();
        LightingSystem lights = new LightingSystem();
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(audio, video, lights);
        homeTheater.StartMovie();
        Console.WriteLine();
        homeTheater.EndMovie();

        Console.WriteLine();
        // --- Демонстрация Composite ---
        Console.WriteLine("=== Composite demo ===");
        DirectoryItem root = new DirectoryItem("Root");
        FileItem file1 = new FileItem("File1.txt");
        FileItem file2 = new FileItem("File2.txt");
        DirectoryItem subDir = new DirectoryItem("SubDirectory");
        FileItem subFile1 = new FileItem("SubFile1.txt");

        root.Add(file1);
        root.Add(file2);
        subDir.Add(subFile1);
        root.Add(subDir);

        root.Display(1);
    }
}
