namespace LightsOutApp.Consts
{
    public static class Constants
    {

        #region Numbers

        /// <summary>
        /// The amount of buttons in each row
        /// </summary>
        public const int BoardWeight = 5;

        /// <summary>
        /// The amount of buttons in each column
        /// </summary>
        public const int BoardHeight = 5;

        /// <summary>
        /// Number for random object
        /// </summary>
        public const int RandomNumber = 1000;

        #endregion

        #region Strings and content
        /// <summary>
        /// The name prefix of button control
        /// </summary>
        public const string ButtonNamePrefix = "btnLight";

        /// <summary>
        /// The text of giving up-button control
        /// </summary>
        public const string ButtonNewGameText = "New game";

        /// <summary>
        /// Separates row number from column number
        /// </summary>
        public const string ButtonNumberSeparator = "-";

        /// <summary>
        /// Message for the winner
        /// </summary>
        public const string WinMessage = "You have won!";

        /// <summary>
        /// Message for the looser
        /// </summary>
        public const string GiveUpMessage = "You have lost!";

        #endregion

        #region Exceptions

        /// <summary>
        /// Message for null reference exception
        /// </summary>
        public const string NullReferenceException = "Null reference exception!";

        /// <summary>
        /// Message for exception
        /// </summary>
        public const string Exception = "Unexpected error occured!";

        #endregion
    }
}
