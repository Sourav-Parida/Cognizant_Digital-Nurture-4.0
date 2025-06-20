using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Singleton Logger:");

        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("This is the first log message.");
        logger2.Log("This is the second log message.");

        // Check if both references point to the same instance
        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger1 and logger2 are the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances detected (not a singleton).");
        }
    }
}
