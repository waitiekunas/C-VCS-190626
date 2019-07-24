using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class Window : GuiObject
    {
        private Frame border;
        public Window(int _height, int _width, int _x, int _y, char cha) : base(_height, _width, _x, _y) { }
        public void Render() { }
    }
}
