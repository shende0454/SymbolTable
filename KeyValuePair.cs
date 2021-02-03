using System;

namespace SymTab
{
    public class KeyValuePair<KeyType, ValueType> : IKeyValuePair<KeyType, ValueType> 
        where KeyType : IComparable<KeyType>
    {
        public KeyValuePair(KeyType key, ValueType value)
        {
            Key = key;
            Value = value;
        }
        public KeyType Key { get; set; }
        public ValueType Value { get; set; }

        public int CompareTo(IKeyValuePair<KeyType, ValueType> other)
        {
            return Key.CompareTo(other.Key);
        }
    }
}