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
    class Class_Circle: Class_Figure
    {
        int width, height, x,y;
        Pen pen;
        public Class_Circle(int x,int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(pen, x, y, width, height);
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
