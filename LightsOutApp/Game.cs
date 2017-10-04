using LightsOutApp.Classes;
using LightsOutApp.Consts;
using LightsOutApp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOutApp
{
    public partial class Game : Form
    {
        private Button[,] _lights;

        public Game()
        {          
            InitializeComponent();
            GameProcess.InitGameBoard(_lights, lightsPanel);
        }

    }
}
