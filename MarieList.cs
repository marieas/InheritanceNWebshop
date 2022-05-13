using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIntro
{
    public class MarieList<T> : List<T>
    {
        public void AddThreeItems(T item1, T item2, T item3)
        {
            this.Add(item1);
            this.Add(item2);
            this.Add(item3);
        }
    }
}
