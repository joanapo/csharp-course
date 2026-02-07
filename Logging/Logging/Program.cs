namespace Logging
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"D:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, $"{message}\n");
        }
    }

    public class DatabaseLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database. {message}");
        }
    }
    
    public class Applicatiob
    {
        private readonly ILogger _logger;
        public Applicatiob(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started");
            // DO ALL THE WORK
            _logger.Log("Work done!");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
