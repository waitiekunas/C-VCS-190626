using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class TextLine : GuiObject
    {
        private string _data;
        public void Render() { }
        public TextLine(int _height, int _width, int _x, int _y, string _data) :base(_height, _width, _x, _y) { }
    }
}
