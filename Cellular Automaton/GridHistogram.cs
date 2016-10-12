using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular_Automaton
{
    class GridHistogram
    {
        public CustomStack<Grid> histogram { get; set; }
        public Grid GetPreviousGeneration()
        {
            return histogram.Pop();
        }

        public void AddToHistogram(Grid grid)
        {
            histogram.Push(grid);
            if (histogram.GetCount() == 11)
            {
                histogram.RemoveBottom();
            }
        }
    }

    public class CustomStack<T>
    {
        private List<T> items = new List<T>();

        public int GetCount()
        {
            return items.Count;
        }

        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (items.Count > 0)
            {
                T temp = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return temp;
            }
            else
                return default(T);
        }
        public void RemoveBottom()
        {
            items.RemoveAt(0);
        }
    }
}
