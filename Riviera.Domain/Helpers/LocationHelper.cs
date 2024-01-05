using System.Text;
using static Riviera.Domain.Helpers.MessageHelper;

namespace Riviera.Domain.Helpers
{
    public class LocationHelper
    {
        /// <summary>
        /// Checks if the key pressed belongs to a location choice index
        /// </summary>
        /// <param name="location"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int CheckLocationSelected(LocationBase location, ConsoleKeyInfo key)
        {
            int result = -1;

            if (!int.TryParse(key.KeyChar.ToString(), out int keyNumber))
                return result;

            if ((location.Choices.Count - 1) >= keyNumber && location.Choices[keyNumber] != null)
                result = keyNumber;

            return result;
        }
        /// <summary>
        /// Shows the location choices in console
        /// </summary>
        /// <param name="choices"></param>
        public static void ShowLocationChoices(List<LocationBase> choices)
        {
            if (choices.Count < 1)
                return;

            Msg("where will you go?");
            var choicesText = new StringBuilder();

            for (int i = 0; i < choices.Count; i++)
            {
                choicesText.Append($"{choices[i].GotoMessage} [{i}] ");
            }

            Msg(choicesText.ToString());
        }

        /// <summary>
        /// Check if enemy was encountered based on enemyRate of a location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool DidEncounterEnemy(LocationBase location)
        {
            bool encounteredEnemy;

            if (location.EnemyRate < 0 || location.EnemyRate > 100)
            {
                throw new ArgumentException("Percentage should be between 0 and 100 inclusive.");
            }

            var random = new Random();
            // Generates a random integer between 0 (inclusive) and 100 (exclusive)
            int randomNumber = random.Next(0, 100);

            // Then the random number has a (100 minus <<EnemyRate number>> ) probabilities of being greater than EnemyRate
            encounteredEnemy = randomNumber < location.EnemyRate;

            return encounteredEnemy;
        }
    }
}
