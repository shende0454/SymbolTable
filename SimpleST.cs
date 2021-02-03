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
            /*
            int index = FindIndex(key);
            if (index == _theTable.Count)
            {
                throw new Exception("Get: key not found");
            }
                //Return value associate with key
                return _theTable[index].Value;
            */
            throw new NotImplementedException();
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

            int index = FindIndex(key);
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            _theTable.Sort();
           if(index !=)
            

        }
        //Sort ceiling and floor methods
        public KeyType Ceiling(KeyType key)
        {
           
            int index = FindIndex(key);
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
               _theTable.Sort();
            if (index != 0)
            {
                return _theTable[index - 1].Key;
            }
            else
            {
                return _theTable[index].Key;
             }
            
          
        }

        public int Rank(KeyType key)
        {
            throw new NotImplementedException();
        }

        public KeyType SelectWithRankOf(int rank)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
