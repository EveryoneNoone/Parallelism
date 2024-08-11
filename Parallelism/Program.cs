using Parallelism;
using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var path = @"c:\Temp\Files\";
        var workWithFiles = new WorkWithFiles();
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        var tasks = workWithFiles.GetDirectoryFiles(path);
        var whiteSpaceCount = await Task.WhenAll(tasks);
        Console.WriteLine(whiteSpaceCount.Sum());
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed.ToString());
    }
}