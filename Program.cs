using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ollama",
                Arguments = "run llama3 'What is artificial intelligence?'",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        string result = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        Console.WriteLine(result);
    }
}