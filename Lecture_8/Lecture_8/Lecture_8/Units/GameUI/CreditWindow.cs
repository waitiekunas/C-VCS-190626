using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class CreditWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;
        public CreditWindow(int _height, int _width, int _x, int _y, char cha, string buttonText, List<string> textBlockText ) : base(_height, _width, _x, _y, cha) { }
        public void Render() { }
    }
}
