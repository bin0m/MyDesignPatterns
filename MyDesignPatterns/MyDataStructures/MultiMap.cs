using System.Collections.Generic;

namespace MyDesignPatterns.MyDataStructures
{
    public class MultiMap<V>
    {
        // uses a Dictionary of string keys
        Dictionary<string, List<V>> _dictionary =
            new Dictionary<string, List<V>>();

        //  provides a simple Add method
        public void Add(string key, V value)
        {
            List<V> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                list.Add(value);
            }
            else
            {
                list = new List<V>();
                list.Add(value);
                this._dictionary[key] = list;
            }
        }

        // exposes Keys
        public IEnumerable<string> Keys
        {
            get
            {
                return this._dictionary.Keys;
            }
        }

        // provides an indexer
        public List<V> this[string key]
        {
            get
            {
                List<V> list;
                if (!this._dictionary.TryGetValue(key, out list))
                {
                    list = new List<V>();
                    this._dictionary[key] = list;
                }
                return list;
            }
        }
    }
}
