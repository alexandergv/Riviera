
namespace Riviera.Domain.Helpers
{
    public static class MessageHelper
    {
        public static void Msg(string msg, bool wait = false)
        {
            if (string.IsNullOrWhiteSpace(msg))
                throw new Exception("The message to log was Empty");

            Console.WriteLine($"    ");


            Console.WriteLine($"    {msg}");
            if (wait)
            {
                Console.WriteLine("     Press enter to Continue |>");
                Console.WriteLine("");
                Console.WriteLine("");


                while (!KeyPressed(ConsoleKey.Enter))
                {
                    Console.WriteLine("     Key pressed is not Enter");
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

        public static void ShowCenteredMsg(string msg, ConsoleColor bgColor = ConsoleColor.Black, ConsoleColor txtColor = ConsoleColor.White)
        {

            Console.Clear();
            Console.BackgroundColor = bgColor;

            // Clear console so background color takes effect
            Console.Clear();
            Console.ForegroundColor = txtColor;


            if (string.IsNullOrWhiteSpace(msg))
                throw new Exception("The message to log was Empty");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"    ");
                if( i == 8)
                     Console.WriteLine(new string(' ', 40)+msg);
            }

            Thread.Sleep(1500);
            Console.ResetColor();

            Console.Clear();
        }
    }
}
