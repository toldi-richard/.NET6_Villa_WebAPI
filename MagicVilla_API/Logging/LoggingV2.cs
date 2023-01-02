namespace MagicVilla_API.Logging;

public class LoggingV2 : ILogging
{
    public void Log(string message, string type)
    {
        if (type == "error")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR - " + message);
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            if (type == "warning")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}