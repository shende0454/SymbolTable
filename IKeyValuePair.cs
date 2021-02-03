using System;

namespace SymTab
{
    public interface IKeyValuePair<KeyType, ValueType> : 
        IComparable<IKeyValuePair<KeyType, ValueType>>
        where KeyType : IComparable<KeyType>
    {
        KeyType Key { get; }
        ValueType Value { get; }
    }
}