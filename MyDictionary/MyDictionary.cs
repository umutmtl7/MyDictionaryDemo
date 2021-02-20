using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnDictionary
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = _keys;
            _keys = new TKey[_keys.Length + 1];

            TValue[] tempValues = _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];

            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public int Count => _keys.Length;

        public void List()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine("KEY is : " + _keys[i] + " VALUE is : " + _values[i]);
            }
        }
    }
}

