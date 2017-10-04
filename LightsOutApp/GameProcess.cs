using LightsOutApp.Classes;
using LightsOutApp.Consts;
using LightsOutApp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOutApp
{
    public class GameProcess
    {
        #region private

        private static Random random;

        /// <summary>
        /// Checks if player won
        /// </summary>
        /// <param name="lights">All the buttons</param>
        /// <returns></returns>
        public static bool CheckSuccess(Button[,] lights)
        {
            bool success = true;

            for (int i = 0; i < lights.GetLength(0); i++)
            {
                for (int j = 0; j < lights.GetLength(1); j++)
                {
                    if (lights[i, j].BackColor == Color.Black)
                        success = false;
                }

            }

            return success;
        }

        /// <summary>
        /// Event handler for light button clicking
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">EventArgs</param>
        /// <param name="lights">All the buttons</param>
        private static void Light_Click(object sender, EventArgs e, Button[,] lights)
        {
            AffectAdjacentLights((Button)sender, lights);
        }

        /// <summary>
        /// Event handler for new game-button clicking
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">EventArgs</param>
        /// <param name="lights">All the buttons</param
        private static void NewGame_Click(object sender, EventArgs e, Button[,] lights)
        {
            RefreshLights(lights);
        }

        /// <summary>
        /// Refreshes lights' board to create new game
        /// </summary>
        /// <param name="lights">Array of buttons(lights)</param>
        private static void RefreshLights(Button[,] lights)
        {
            for (int i = 0; i < lights.GetLength(0); i++)
            {
                for (int j = 0; j < lights.GetLength(1); j++)
                {
                    int randomNumber = random.Next();
                    lights[i, j].BackColor = randomNumber.DivisibleByTwo() ? Color.Black : Color.Yellow;
                }
            }
        }

        #endregion

        /// <summary>
        /// Inits the game board
        /// </summary>
        /// <param name="lights">All the buttons</param>
        /// <param name="lightsPanel">Panel which contains the buttons</param>
        public static void InitGameBoard(Button[,] lights, Panel lightsPanel)
        {
            lights = new Button[Constants.BoardHeight, Constants.BoardWeight];

            random = new Random(Constants.RandomNumber);

            try
            {
                for (int i = 0; i < lights.GetLength(0); i++)
                {
                    for (int j = 0; j < lights.GetLength(1); j++)
                    {
                        int randomNumber = random.Next(5, 20);
                        lights[i, j] = new Button();
                        lights[i, j].Size = new Size(50, 50);
                        lights[i, j].Name = Constants.ButtonNamePrefix + i.ToString() + Constants.ButtonNumberSeparator + j.ToString(); // set name like this
                        lights[i, j].Click += (sender, e) => Light_Click(sender, e, lights);
                        lights[i, j].Location = new Point(40 + (j * 70), 20 + (i * 70));
                        lights[i, j].BackColor = randomNumber.DivisibleByTwo() ? Color.Black : Color.Yellow;
                        lightsPanel.Controls.Add(lights[i, j]);
                    }
                }

                Button newGameButton = new Button()
                {
                    Size = new Size(100, 50),
                    Text = Constants.ButtonNewGameText,
                    Location = new Point(40, 20 + (Constants.BoardHeight * 70)),
                };

                newGameButton.Click += (sender, e) => NewGame_Click(sender, e, lights);

                lightsPanel.Controls.Add(newGameButton);
                lightsPanel.Size = new Size(40 + lights.GetLength(0) * 70, 20 + (lights.GetLength(1) * 70));
                lightsPanel.AutoSize = true;
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(Constants.NullReferenceException + Environment.NewLine + e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.Exception + Environment.NewLine + e.ToString());
            }
            
            
        }

        /// <summary>
        /// Switch the lights around and the clicked one
        /// </summary>
        /// <param name="clickedButton">The clicked button</param>
        /// <param name="lights">All the buttons</param>
        public static void AffectAdjacentLights(Button clickedButton, Button[,] lights)
        {
            List<Light> buttonsToSwitch = clickedButton.Name.AdjacentLights(lights.GetLength(0), lights.GetLength(1));

            foreach (var button in buttonsToSwitch)
            {
                var buttonToSwitch = lights[button.RowNumber, button.ColumnNumber];
                if (buttonToSwitch.BackColor == Color.Yellow)
                {
                    buttonToSwitch.BackColor = Color.Black;
                }
                else buttonToSwitch.BackColor = Color.Yellow;
            }

            if (CheckSuccess(lights))
            {
                MessageBox.Show(Constants.WinMessage);
                RefreshLights(lights);
            }
                
        }

    }
}
