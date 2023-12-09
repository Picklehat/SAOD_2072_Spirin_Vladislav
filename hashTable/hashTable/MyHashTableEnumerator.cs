using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    public class MyHashTableEnumerator<Tkey, TValue> : IEnumerator<HashItem<Tkey, TValue>>
    {
        private HashItem<Tkey, TValue>[] hashItemArr;
        private HashItem<Tkey, TValue> currentItem;
        private TValue currentValue;
        private int currentIndex;
        private bool collisionFlag;

        public MyHashTableEnumerator(HashItem<Tkey, TValue>[] hashItemArr)
        {
            this.hashItemArr = hashItemArr;
            currentIndex = -1;
            collisionFlag = false;
        }

        public bool MoveNext()
        {
            while (true)
            {
                if (currentIndex >= (hashItemArr.Length - 1))
                {
                    return false;
                }
                if (collisionFlag)
                {
                    currentItem = currentItem.Child;
                    if(currentItem != null)
                    {
                        return true;
                    }
                    else
                    {
                        collisionFlag = false;
                    }
                }
                else
                {
                    currentIndex++;
                    if (hashItemArr[currentIndex] != null)
                    {
                        currentItem = hashItemArr[currentIndex];
                        if(currentItem.Child != null)
                        {
                            collisionFlag = true;
                        }
                        return true;
                    }
                }
            }
        }

        public void Reset()
        {
            currentIndex = -1;
            collisionFlag = false;
        }

        public void Dispose()
        {

        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public HashItem<Tkey, TValue> Current
        {
            get
            {
                return currentItem;
            }
        }

    }
}
