using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    internal class MyDictionary<TKey, TValue>
    {
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();
        public TValue this[int i]
        {
            get => values[i];
            set => values[i] = value;
        }
        int count = 0;
        public int Count { get => count; }
        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
            count++;
        }
    }
}
