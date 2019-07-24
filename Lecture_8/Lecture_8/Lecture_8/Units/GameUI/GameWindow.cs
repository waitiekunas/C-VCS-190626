using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class GameWindow : Window
    {
        private Button creditButton;
        private Button quitButton;
        private Button startButton;
        private TextBlock titleTextBlock;
        public void Render() { }
        public GameWindow(int _height, int _width, int _x, int _y, char cha, List<string> textString, string buttonText) : base(_height, _width, _x, _y, cha) { }


    }
}
