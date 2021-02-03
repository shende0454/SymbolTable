using System;
using System.Collections.Generic;

namespace SymTab
{
    // The ISynmbolTable definition states that
    // Keys can be of a specified type. (KeyType)
    // Value stored with keys can be a specified type (ValueType)
    // The interface implements the IEmurable interface
    // Allows us to do a foreach loop
    // THE "WHERE" CLAUSE PLACES A RESTRICTION ON THE kEYtYPE
    // The keytype must implement the Icomparable interface.
    // CompareTo(thingToCompareTo) returns 0 if equal
    // A negative value if thingToCompare is greater
    // A positive value if thingToCompare is less
    public interface ISymbolTable<KeyType, ValueType> : IEnumerable<KeyType>
        where KeyType : IComparable<KeyType>
    {
        // Add or replace an existig entry.
        void Put(KeyType key, ValueType value);

        // Get the value of the specified key.
        // If the specified key does not exist, throw an exception
        ValueType Get(KeyType key);

        // Delete the key
        void Delete(KeyType key);

        // Does an entry with the specifed key exisit in the 
        // symbol table?
        bool Contains(KeyType key);

        // Is the symbol table empty.
        bool IsEmpty();

        // Return the smallest key in the symbol table.
        // Throws if table is empty.
        KeyType Min();

        // Return the largest key in the symbol table.
        // Throws if table is empty.
        KeyType Max();

        // Return the closest key in the symbol table that is
        // equal to or less than the specified key.
        // Throws if table is empty.
        // Throw if no key is less or equal
        KeyType Floor(KeyType key);

        // Return the closest key in the symbol table that is
        // equal to or less than the specified key.
        // Throws if table is empty.
        KeyType Ceiling(KeyType key);

        // Find the number of keys less than the
        // specified key.
        int Rank(KeyType key);

        // Find the key with a specified Rank
        // Throw if specified rank is larger or
        // equal to the size of the table.
        KeyType SelectWithRankOf(int rank);

        // Delete the smallest key
        // Throws on empty table.
        void DeleteMin();

        // Delete the largest key
        // Throws on empty table.
        void DeleteMax();

        // How many entries are in the symbol table.
        int Size();
    }
}