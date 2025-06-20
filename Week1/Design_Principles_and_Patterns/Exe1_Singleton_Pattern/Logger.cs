using System;

public class Logger
{
    // Private static instance of Logger
    private static Logger? instance = null;

    // Object for locking to make thread-safe
    private static readonly object padlock = new object();

    // Private constructor to prevent external instantiation
    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }

    // Public static method to get the singleton instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    // Example logging method
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
