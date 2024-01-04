using Riviera.Domain;
using static Riviera.Domain.Helpers.MessageHelper;

namespace Riviera
{
    public static class Renderer
    {
        public static void RenderLocation(LocationBase location, Player player)
        {
            char delimiter = '#';
            char playerChar = '@';
            bool buffer = true;

            while (buffer)
            {
                Console.Clear();
                Console.WriteLine(new string(delimiter, location.Width));
                for (int i = 0; i < location.Height - 2; i++)
                {
                    var locationSpaceX = new string(' ', location.Width - 2);

                    // If current player vertical position its the same as the one we are rendering, render char based on horizontal position
                    if (player.PosY == i)
                        locationSpaceX = RenderPlayer(player.PosX, locationSpaceX);

                    Console.WriteLine(delimiter + locationSpaceX + delimiter);
                }
                Console.WriteLine(new string(delimiter, location.Width));

                ConsoleKey key = Console.ReadKey().Key;

                // Implemented keys
                switch (key)
                {
                    case ConsoleKey.X:
                        buffer = false;
                        break;

                    case ConsoleKey.RightArrow:
                        player.PosX++;
                        break;

                    case ConsoleKey.LeftArrow:
                        player.PosX--;
                        break;

                    case ConsoleKey.UpArrow:
                        player.PosY--;
                        break;

                    case ConsoleKey.DownArrow:
                        player.PosY++;
                        break;

                    default:
                        break;
                }
            }


        }

        public static void RenderMovement() 
        {
        
        }

        public static string RenderPlayer(int index, string ogString)
        {
            string originalString = ogString;
            int indexToReplace = index;  // Replace with the index you want to replace
            char newChar = '@';      // Replace with the new character
            string modifiedString;

            if (indexToReplace >= 0 && indexToReplace < originalString.Length)
            {
                char[] charArray = originalString.ToCharArray();
                charArray[indexToReplace] = newChar;

                modifiedString = new string(charArray);
            }
            else
            {
                throw new Exception($"Index {indexToReplace} is out of bounds.");
            }

            return modifiedString;

        }
    }
}
