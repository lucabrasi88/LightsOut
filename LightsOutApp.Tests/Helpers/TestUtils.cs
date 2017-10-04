using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOutApp.Tests.Helpers
{
    public static class TestUtils
    {
        /// <summary>
        /// Prepares the array of lights (all switched on)
        /// </summary>
        /// <returns></returns>
        public static Button[,] PrepareLightsAllYellow()
        {
            Button[,] lights = new Button[5, 5];

            for (int i = 0; i < lights.GetLength(0); i++)
            {
                for (int j = 0; j < lights.GetLength(1); j++)
                {
                    lights[i, j] = new Button();
                    lights[i, j].BackColor = Color.Yellow;
                }
            }

            return lights;
        }

        /// <summary>
        /// Prepares the array of lights (all switched off)
        /// </summary>
        /// <returns></returns>
        public static Button[,] PrepareLightsAllBlack()
        {
            Button[,] lights = new Button[5, 5];

            for (int i = 0; i < lights.GetLength(0); i++)
            {
                for (int j = 0; j < lights.GetLength(1); j++)
                {
                    lights[i, j] = new Button();
                    lights[i, j].BackColor = Color.Black;
                }
            }

            return lights;
        }

    }
}
