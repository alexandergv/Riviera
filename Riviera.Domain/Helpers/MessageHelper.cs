
using Riviera.Domain.Menu;

namespace Riviera.Domain.Helpers
{
    public static class MessageHelper
    {
        public static void Msg(string msg, bool wait = false, MenuOptions options = null)
        {

            if (string.IsNullOrWhiteSpace(msg))
                throw new Exception("The message to log was Empty");

            if (options?.MarginTop > 0)
            {
                for (int i = 0; i < options.MarginTop; i++)
                {
                    Console.WriteLine($"    ");
                }
            } else
            {
                Console.WriteLine($"    ");
            }

            if(options?.TextColor != null)
            {
                Console.ForegroundColor = (ConsoleColor)options.TextColor;
            }


            Console.WriteLine($"    {msg}");

            if (options?.TextColor != null)
                Console.ResetColor();    

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
