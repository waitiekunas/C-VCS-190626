using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class GuiObject
    {
        protected int _height;
        protected int _width;
        protected int _x;
        protected int _y;

        public GuiObject(int _height, int _width, int _x, int _y) {
            this._height = _height;
            this._width = _width;
            this._x = _x;
            this._y = _y;
        }
    }
}
