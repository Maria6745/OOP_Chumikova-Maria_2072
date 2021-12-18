using System;
using System.Collections;
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
    abstract class Class_Figure
    {
        public abstract void Draw(Graphics gr);
        public virtual void Move(int shiftX, int shiftY)
        {

        }
        public virtual bool IsPointInside(int x, int y)
        {
            return false;
        }
    }
   

  
    class FigContainer : IEnumerable // список-контейнер фигур
    {
        protected List<Class_Figure> figures = new List<Class_Figure>();


        public IEnumerator GetEnumerator()
        {

            return figures.GetEnumerator();

        }

        public void Add(Class_Figure figure)
        {
            figures.Add(figure);

        }


        public void Clear()
        {
            figures.Clear();
        }
    }
}
