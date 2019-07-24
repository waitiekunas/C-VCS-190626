using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units.GameUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private bool isActive = false;
        private Frame notActiveFrame;
        private TextLine textLine;

        public Button(int _height, int _width, int _x, int _y, string text) : base(_height, _width, _x, _y) { }
        public void Render() { }
        public void SetActive() { }
    }
}
