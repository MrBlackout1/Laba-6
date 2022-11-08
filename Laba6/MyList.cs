using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Laba6
{
    internal class MyList<T>
    {
        int count = 0;
        public int Count { get => count; }
        T[] values;
        public T this[int i]
        {
            get => values[i];
            set => values[i] = value;
        }
        public void Add(T value)
        {
            T[] newValues = new T[count + 1];
            if (count > 0)
                values.CopyTo(newValues, 0);
            newValues[^1] = value;
            values = newValues;
            count++;
        }
        public T[] ToArray()
        {
            return values;
        }
    }
}
