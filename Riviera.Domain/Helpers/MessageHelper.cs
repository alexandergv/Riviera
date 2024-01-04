
namespace Riviera.Domain.Helpers
{
    public static class MessageHelper
    {
        public static void Msg(string msg, bool wait = false)
        {
            if (string.IsNullOrWhiteSpace(msg))
                throw new Exception("The message to log was Empty");

            Console.WriteLine($"    {msg}");
            if (wait)
            {
                Console.WriteLine("Press enter to Continue |>");
                Console.WriteLine("");
                Console.WriteLine("");


                while (!KeyPressed(ConsoleKey.Enter))
                {
                    Console.WriteLine("Key pressed is not Enter");
                }
                Console.Clear();

            }

        }

        public static bool KeyPressed(ConsoleKey key)
        {
            bool wasPressed = false;
            if (Console.ReadKey(true).Key == key)
            {
                wasPressed = true;
            }

           return wasPressed;
        }
    }
}
