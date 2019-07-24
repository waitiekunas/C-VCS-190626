using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class TextBlock : GuiObject
    {
        public TextBlock(int _height, int _width, int _x, int _y, List<string> text) : base(_height, _width, _x, _y) { }
        public void Render() { }

        private List<TextLine> textBlocks = new List<TextLine>();
    }
}
