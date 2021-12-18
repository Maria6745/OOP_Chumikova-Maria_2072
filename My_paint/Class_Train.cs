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
    class Class_Train: Class_Figure
    {
        int x, y, width, height,count;
        Pen pen;
        public Class_Van van;
        public Class_Van van_p;
        public Class_Van van_y;
        List<Class_Van> count_van = new List<Class_Van>();
        public Class_Train(int x, int y, int width, int height, int count, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.pen = pen;
            this.count = count;
        }
        public override void Draw(Graphics gr)
        {
            Random rnd = new Random();
            int _x = x;
            for (int i = 0; i < count; i++)
            {
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        van = new Class_Van(_x, y, width, height, pen);
                        van.Draw(gr);
                        count_van.Add(van);
                        break;
                    case 2:
                        van_p = new Class_Van_p(_x, y, width, height, pen);
                        van_p.Draw(gr);
                        count_van.Add(van_p);
                        break;
                    case 3:
                        van_y = new Class_Van_y(_x, y, width, height, pen);
                        van_y.Draw(gr);
                        count_van.Add(van_y);
                        break;
                }
                _x = _x + width + 20;
            }
        }
        public override void Move(int shiftX, int shiftY)
        {
            x = shiftX;
            y = shiftY;
        }
        public override bool IsPointInside(int x, int y)
        {
            foreach (Class_Van fig in count_van) 
            {
                if (fig.IsPointInside(x, y))
                    return true;
            }
            return false;
        }
            
    }
}
