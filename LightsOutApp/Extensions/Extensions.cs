using LightsOutApp.Classes;
using LightsOutApp.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LightsOutApp.Extensions
{
    public static class Extensions
    {
        #region String

        /// <summary>
        /// Gets positions of buttons to switch on/off
        /// </summary>
        /// <param name="clickedButtonName">Name of button clicked by the player</param>
        /// <returns></returns>
        public static List<Light> AdjacentLights(this string clickedButtonName, int boardHeight, int boardWidth)
        {
            string[] clickedButtonNumber = clickedButtonName.Substring(clickedButtonName.Length - (clickedButtonName.Length - Constants.ButtonNamePrefix.Length)).Split('-');
            List<Light> adjacentLights = new List<Light>(); 

            int buttonRowNumber;
            int buttonColumnNumber;

            var validRowNumber = Int32.TryParse(clickedButtonNumber[0], out buttonRowNumber);
            var validColumnNumber = Int32.TryParse(clickedButtonNumber[1], out buttonColumnNumber);
            if (validRowNumber && validColumnNumber)
            {
                adjacentLights.Add(new Light(buttonRowNumber, buttonColumnNumber));
                if(buttonRowNumber > 0)
                    adjacentLights.Add(new Light(buttonRowNumber - 1, buttonColumnNumber));
                if(buttonRowNumber < boardHeight - 1)
                    adjacentLights.Add(new Light(buttonRowNumber + 1, buttonColumnNumber));
                if(buttonColumnNumber > 0)
                    adjacentLights.Add(new Light(buttonRowNumber, buttonColumnNumber - 1));
                if(buttonColumnNumber < boardWidth - 1)
                    adjacentLights.Add(new Light(buttonRowNumber, buttonColumnNumber + 1));
            }

            return adjacentLights;
        }

        #endregion

        #region int

        /// <summary>
        /// Checks if the number is divisible by two
        /// </summary>
        /// <param name="number">Given number</param>
        /// <returns>True - is divisible by 2
        /// False - is not divisible by 2</returns>
        public static bool DivisibleByTwo(this int number)
        {
            return number % 2 == 0 ? true : false;
        }

        #endregion

    }
}
