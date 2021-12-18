using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_paint
{
    class Class_Rect: Class_Figure
    {
        int x, y, width, height;
        Pen pen;
        public Class_Rect(int x, int y, int height, int width, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.pen = pen;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(pen, x, y, width, height);
        }
        public override bool IsPointInside(int x, int y)
        {
            if (x <= this.x + width && y <= this.y + height && x >= this.x && y >= this.y)
                return true;
            return false;
        }
        public override void Move(int shiftX, int shiftY)
        {
            base.Move(shiftX, shiftY);
            x = shiftX;
            y = shiftY;
        }
    }
}
