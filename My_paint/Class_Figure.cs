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
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    public interface IEnumerator
    {
        bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
        object Current { get; }  // текущий элемент в контейнере
        void Reset(); // перемещение в начало контейнера
    }
    //IEnumerator IEnumerable.GetEnumerator()
    //{
    //    return object.GetEnumerator();
    //}
    //public IEnumerator GetEnumerator()
    //{
    //    return figures.GetEnumerator();
    //}

    class FigEnumerator : IEnumerator
    {
        List<Class_Figure> figures = new List<Class_Figure>();
        int position = -1;
        public FigEnumerator(List<Class_Figure> figures)
        {
            this.figures = figures;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= figures.Count)
                    throw new InvalidOperationException();
                return figures[position];
            }
        }

        public bool MoveNext()
        {
            if (position < figures.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
