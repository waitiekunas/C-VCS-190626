using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class Frame : GuiObject
    {
        private char _renderChar;
        public Frame(int _height, int _width, int _x, int _y, char render):base(_height, _width, _x, _y) {
            _renderChar = render;
        }
        public void Render() {
            for (int i = 0; i < _height; i++)
            {
                Console.SetCursorPosition(_x, _y + i);

            }
        }
    }
}
