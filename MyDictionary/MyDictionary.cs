using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TK, TV>
    {
        TK[] _keyArray;
        TV[] _valueArray;

        TK[] _tempKeyArray;
        TV[] _tempValueArray;

        public MyDictionary()
        {
            _keyArray = new TK[0];
            _valueArray = new TV[0];
        }

        public void Add(TK key, TV value)
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;

            _keyArray = new TK[_keyArray.Length + 1];
            _valueArray = new TV[_valueArray.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
            }
            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _valueArray[i] = _tempValueArray[i];
            }

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;
        }
        public int Count
        {
            get { return _keyArray.Length; }
        }

        public TK[] Keys
        {
            get { return _keyArray; }
        }
        public TV[] Values
        {
            get { return _valueArray; }
        }
    }
}