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
    class Class_Van : Class_Figure // - вагончик
    {
        int x, y, width, height;
        Pen pen;

        public Class_Van(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.pen = pen;
        }
        public override void Draw(Graphics gr)
        {
            //прямоугольник
            gr.DrawRectangle(pen, x, y, width, height);
            gr.FillRectangle(Brushes.DarkBlue, x, y, width, height);
            //круги
            gr.DrawEllipse(pen, x, y + height, (width/5) * 2, (width / 5) * 2);
            gr.FillEllipse(Brushes.DarkGray, x, y + height, (width / 5) * 2, (width / 5) * 2);

            gr.DrawEllipse(pen, x + width - (width / 5) * 2, y +height, (width / 5) * 2, (width / 5) * 2);
            gr.FillEllipse(Brushes.DarkGray, x + width - (width / 5) * 2, y + height, (width / 5) * 2, (width / 5) * 2);
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

    class Class_Van_p : Class_Van //- вагончик с песком
    {
        Pen pen;
        Point p1;
        Point p2;
        Point p3;
        int width, height;
        public Class_Van_p(int x, int y, int width, int height, Pen pen): base(x, y, width, height, pen)
        {
            this.height = height;
            this.width = width;
            this.pen = pen;
            p1 = new Point(x, y);
            p2 = new Point(x + width, y);
            p3 = new Point(x+ width / 2, y - height / 2);
        }
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);

            //треугольник
            Point[] points = {p1, p2, p3};
            gr.DrawPolygon(pen, points);
            gr.FillPolygon(Brushes.Moccasin, points);
        }
        public override bool IsPointInside(int x, int y)
        {
            int a = (p1.X - x) * (p2.Y - p1.Y) - (p2.X - p1.X) * (p1.Y - y);
            int b = (p2.X - x) * (p3.Y - p2.Y) - (p3.X - p2.X) * (p2.Y - y);
            int c = (p3.X - x) * (p1.Y - p3.Y) - (p1.X - p3.X) * (p3.Y - y);
            return base.IsPointInside(x, y) || a > 0 && b > 0 && c > 0 ||a < 0 && b < 0 && c < 0 ||a == 0 && b == 0 && c == 0;
        }
        public override void Move(int shiftX, int shiftY)
        {
            base.Move(shiftX, shiftY);
            p1 = new Point(shiftX, shiftY);
            p2 = new Point(shiftX + width, shiftY);
            p3 = new Point(shiftX + width / 2, shiftY - height / 2);
        }
    }
    class Class_Van_y : Class_Van //- вагончик с углём
    {
        Pen pen;
        Point p1;
        Point p2;
        Point p3;
        int width, height;
        public Class_Van_y(int x, int y, int width, int height, Pen pen) : base(x, y, width, height, pen)
        {
            this.height = height;
            this.width = width;
            this.pen = pen;
            p1 = new Point(x, y);
            p2 = new Point(x + width, y);
            p3 = new Point(x + width / 2, y - height / 2);
        }
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);

            //треугольник
            Point[] points = { p1, p2, p3 };
            gr.DrawPolygon(pen, points);
            gr.FillPolygon(Brushes.LightGray, points);
        }
        public override bool IsPointInside(int x, int y)
        {
            int a = (p1.X - x) * (p2.Y - p1.Y) - (p2.X - p1.X) * (p1.Y - y);
            int b = (p2.X - x) * (p3.Y - p2.Y) - (p3.X - p2.X) * (p2.Y - y);
            int c = (p3.X - x) * (p1.Y - p3.Y) - (p1.X - p3.X) * (p3.Y - y);
            return base.IsPointInside(x, y) || a > 0 && b > 0 && c > 0 || a < 0 && b < 0 && c < 0 || a == 0 && b == 0 && c == 0;
        }
        public override void Move(int shiftX, int shiftY)
        {
            base.Move(shiftX, shiftY);
            p1 = new Point(shiftX, shiftY);
            p2 = new Point(shiftX + width, shiftY);
            p3 = new Point(shiftX + width / 2, shiftY - height / 2);
        }
    }
}

