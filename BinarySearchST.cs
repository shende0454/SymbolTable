using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymTab
{
   public class BinarySearchST<KeyType, ValueType> : ISymbolTable<KeyType, ValueType>
        where KeyType: IComparable<KeyType>
    {
        private List<IKeyValuePair<KeyType, ValueType>> _theTable = new List<IKeyValuePair<KeyType, ValueType>>();

        public KeyType Ceiling(KeyType key)
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyType key)
        {
            throw new NotImplementedException();
        }

        public void Delete(KeyType key)
        {
            throw new NotImplementedException();
        }

        public void DeleteMax()
        {
            throw new NotImplementedException();
        }

        public void DeleteMin()
        {
            throw new NotImplementedException();
        }

        public KeyType Floor(KeyType key)
        {
            throw new NotImplementedException();
        }

        public ValueType Get(KeyType key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyType> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public KeyType Max()
        {
            throw new NotImplementedException();
        }

        public KeyType Min()
        {
            throw new NotImplementedException();
        }

        public void Put(KeyType key, ValueType value)
        {
            throw new NotImplementedException();
        }
        //Provide  us the number of elements inn the table that are less than the key 
        // If the value is in the table tht is also the idecx od that item
        // in the table
        public int Rank(KeyType key)
        {
            //Implement a binary search 
            int lowerBound = 0;
            int upperBound = Size() - 1;
            int middleElementIndex = lowerBound + (upperBound - lowerBound) / 2;

            // While we havent found where the item or where it goes
            //While we havent eliminated all possibilities and
            // we havent found what we are looking for
            while (lowerBound <= upperBound && key.CompareTo(_theTable[middleElementIndex].Key) != 0)
            {
                //We havent found what we are looking for

                // See if the key we are looking for is higher or lower than the target

                //if the thing we are looking for is less than 
                if (key.CompareTo(_theTable[middleElementIndex].Key) < 0)
                {
                    upperBound = middleElementIndex - 1;
                }
                else
                {
                    lowerBound = middleElementIndex + 1;
                }
                //recompute the index of the middle element 
                middleElementIndex = lowerBound + (upperBound - lowerBound) / 2;
            }
            // if lowerBound <= upperBound I found what I was looking for
            return (lowerBound <= upperBound) ? middleElementIndex : lowerBound;
        }

        public KeyType SelectWithRankOf(int rank)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return _theTable.Count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
