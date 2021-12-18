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
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Blue, 10);
        List<Class_Figure> figures = new List<Class_Figure>();
        public int x, y,x_end, y_end,i;
        public bool drawing, move, fig_move;
        public IEnumerator GetEnumerator()
        {
            return new FigEnumerator(figures);
        }
        public enum Figure
        {
            circle,
            rect,
            van,
            van_p,
            van_y,
            train
        }
        public Figure fig_name;
        public void But_cir_Click(object sender, EventArgs e)
        {
            fig_name = Figure.circle;
            move = false;
        }
        public void But_rec_Click(object sender, EventArgs e)
        {
            fig_name = Figure.rect;
            move = false;
        }
        public void button_van_Click(object sender, EventArgs e)
        {
            fig_name = Figure.van;
            move = false;
        }
        public void button_van_p_Click(object sender, EventArgs e)
        {
            fig_name = Figure.van_p;
            move = false;
        }
        public void button_van_y_Click(object sender, EventArgs e)
        {
            fig_name = Figure.van_y;
            move = false;
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel.CreateGraphics();
            foreach (var fig in figures)
            {
                fig.Draw(gr);
            }
        }

        private void button_train_Click(object sender, EventArgs e)
        {
            fig_name = Figure.train;
            move = false;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            figures.Clear();
            panel.Invalidate();
            panel.Update();
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            move = true;
            drawing = false;
        }

        public void panel_MouseDown(object sender, MouseEventArgs e)
        {
            x =  e.X;
            y =  e.Y;
            drawing = true;
            if (move == true)
            {
                drawing = false;
                foreach (var fig in figures)
                {
                    i = figures.IndexOf(fig);
                    if (fig.IsPointInside(x, y))
                    {
                        fig_move = true;
                        break;
                    }
                }
            }
        }
        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            x_end = e.X;
            y_end = e.Y;
            Graphics gr = panel.CreateGraphics();
            if (drawing)
                switch (fig_name)
                {
                    case Figure.circle:
                        Class_Circle circle = new Class_Circle(x, y, x_end - x, y_end - y, pen);
                        figures.Add(circle);
                        circle.Draw(gr);
                        break;
                    case Figure.rect:
                        Class_Rect rect = new Class_Rect(x, y, y_end - y, x_end - x, pen);
                        figures.Add(rect);
                        rect.Draw(gr);
                        break;
                    case Figure.van:
                        Class_Van van = new Class_Van(x, y, x_end - x,y_end - y,  pen);
                        figures.Add(van);
                        van.Draw(gr);
                        break;
                    case Figure.van_p:
                        Class_Van_p van_p = new Class_Van_p(x, y, x_end - x, y_end - y, pen);
                        figures.Add(van_p);
                        van_p.Draw(gr);
                        break;
                    case Figure.van_y:
                        Class_Van_y van_y = new Class_Van_y(x, y,  x_end - x, y_end - y, pen);
                        figures.Add(van_y);
                        van_y.Draw(gr);
                        break;
                    case Figure.train:
                        int count = Convert.ToInt32(count_van.Text);
                        Class_Train train = new Class_Train(x, y, x_end - x, y_end - y, count, pen);
                        figures.Add(train);
                        train.Draw(gr);
                        break;
                }
            drawing = false;
            if (fig_move)
            {
                figures[i].Move(x_end, y_end);
                panel.Refresh();
            }
            fig_move = false;
        }

        //избавиться от лишних полей в вагонах + 
        //сделать класс поезд с случайными вагонами +
        //метод move для поезда +
        //добавить интефейсы +?

    }
}
