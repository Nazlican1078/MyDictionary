using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> kisiyas = new MyDictionary<string, int>();
            kisiyas.Add("Nazlı", 23);
            kisiyas.Add("Hilal", 23);
            kisiyas.Add("Cemal", 21);
            Console.WriteLine(kisiyas.Count);
        }
    }

    class MyDictionary<TKey, TValue>
    {

        TKey[] _keys;
        TKey[] tempKeys;

        TValue[] _values;
        TValue[] tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
            tempKeys = _keys;
            tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];



        }

        public int Count
        {
            get { return (_keys.Length + _values.Length); }

        }


    }
}
