using System;
using System.Collections;
using System.Collections.Generic;

namespace SymTab
{
    public class SimpleST<KeyType, ValueType> : ISymbolTable<KeyType, ValueType>
        where KeyType : IComparable<KeyType>
    {
        public SimpleST()
        { 
        }

        // _theTable is a list of key / value types
        List<KeyValuePair<KeyType, ValueType>> _theTable = 
            new List<KeyValuePair<KeyType, ValueType>>();
        public int Size()
        {
            return _theTable.Count;
        }

        // Return the index of the key
        //
        private int FindIndex(KeyType key)
        {
            int index = 0;
            // While I have more things to look at and I havent found the key
            while (index < _theTable.Count && _theTable[index].Key.CompareTo(key) != 0)
            {
                ++index;
            }
            return index;
        }
        public void Put(KeyType key, ValueType value)
        {
            int index = FindIndex(key);
            // If it wasnt in the table
            if (index == _theTable.Count)
            { 
                KeyValuePair<KeyType, ValueType> newEntry = new KeyValuePair<KeyType, ValueType>(key, value);
                _theTable.Add(newEntry);
             }
             else
             {
                 _theTable[index].Value = value;
             }
        }

        public ValueType Get(KeyType key)
        {
            
            int index = FindIndex(key);
            if (index == _theTable.Count)
            {
                throw new Exception("Get: key not found");
            }
                //Return value associate with key
                return _theTable[index].Value;
        }

        public void Delete(KeyType key)
        {
            int index = FindIndex(key);
            if (index == _theTable.Count)
            {
                throw new Exception("Get: key not found");
            }
  
                _theTable.RemoveAt(index);   
        }
       public bool Contains(KeyType key)
        {
            Boolean isContained = true;
            int index = FindIndex(key);
            if (index == _theTable.Count)
            {
                isContained = false;
            }
            return isContained;
           
        }

        public bool IsEmpty()
        {
           return Size() == 0;
        }

        public KeyType Min()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
            return _theTable[0].Key;
        }

        public KeyType Max()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
            return _theTable[Size()-1].Key;
        }

        public KeyType Floor(KeyType key)
        {
            int index = 0;
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
            while (index < _theTable.Count && _theTable[index].Key.CompareTo(key) != 0 && _theTable[index].Key.CompareTo(key) != -1)
            {
                ++index;
            }
            return _theTable[index].Key;
        }
        
        public KeyType Ceiling(KeyType key)
        {
            int index = FindIndex(key);
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
               _theTable.Sort();
           
            return (index != 0) ? _theTable[index - 1].Key :_theTable[index].Key; 
        }
        
        public int Rank(KeyType key)
        {
            int cmpVal;
            int rank = 0;
            _theTable.Sort();
            for (int i = 0; i < Size(); i++)
            {
                cmpVal = _theTable[i].Key.CompareTo(key);
                if (cmpVal == - 1)
                {
                    rank += 1;
                }
            }
            return rank;
        }
      
        public KeyType SelectWithRankOf(int rank)
        {
            _theTable.Sort();
            int rankToCmp= 0;
            int index = 0;
            Boolean notE = true;
            while (index < Size() && notE != false)
            {
               rankToCmp  = Rank(_theTable[index].Key);
                
                if (rankToCmp == rank)
                {
                   notE = false;
                   index -= 1;
                }
                
                ++index;
             }
            if (rank >= Size())
            {
                throw new Exception("List is empty");
            }
            
            return _theTable[index].Key;
        }

        public void DeleteMin()
        {
            if (Size() == 0)
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
            _theTable.RemoveAt(Size() - Size());
        }

        public void DeleteMax()
        {
            if (Size() == 0)
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
           
            _theTable.RemoveAt(Size () - 1);
        }

        public IEnumerator<KeyType> GetEnumerator()
        {
            foreach (KeyValuePair<KeyType, ValueType> keys in _theTable)
            {
                yield return keys.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }
    }
}
