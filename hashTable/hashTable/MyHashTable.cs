using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    public class MyHashTable<Tkey, TValue> : IEnumerable<HashItem<Tkey, TValue>>
    {
        private HashItem<Tkey, TValue>[] hashItemArr;
        int counter;
        Queue<int> sizes;
        private static int[] sizesArr = {5, 11, 23, 47, 97, 193, 389,
        1769, 1543, 3072, 3079, 12289, 24593, 49157, 98317, 19613,
        393241, 786433, 1572869, 3145739, 6291469, 12582917,
        25165843, 50331653, 100663319, 201326611, 402653189,
        805306457, 1610612736, 2147483629};
        private static int fillFactor = 75;

        public TValue this[Tkey key]
        {
            get
            {
                return Find(key);
            }
            private set { }
        }
        public MyHashTable()
        {
            counter = 0;
            sizes = new Queue<int>(sizesArr);
            hashItemArr = new HashItem<Tkey, TValue>[sizes.Dequeue()];
        }
        public void Add(Tkey key, TValue value)
        {
            int hash = HashFunction(key);
            HashItem<Tkey, TValue> newItem = new HashItem<Tkey, TValue> { Key = key, Value = value, Hash = hash };

            if ((double)hashItemArr.Length / 100 * fillFactor <= counter)
                ResizeHashTable();

            if (hashItemArr[hash] == null)
            {
                hashItemArr[hash] = newItem;
                counter++;
            }
            else
            {
                Add(hashItemArr[hash], newItem);
            }
        }
        private void Add(HashItem<Tkey, TValue> root, HashItem<Tkey, TValue> newItem)
        {
            if (root.Child == null)
                root.Child = newItem;
            else
                Add(root.Child, newItem);
        }
        public TValue Find(Tkey key)
        {
            int hash = HashFunction(key);
            if (hashItemArr[hash] == null) { throw new Exception("Item not found"); }
            if (hashItemArr[hash].Key.Equals(key))
                return hashItemArr[hash].Value;
            else
                return Find(hashItemArr[hash].Child, key);
        }
        private TValue Find(HashItem<Tkey, TValue> root, Tkey key)
        {
            if (root == null) { throw new Exception("Item not found"); }
            if (root.Key.Equals(key))
                return root.Value;
            else
                return Find(root.Child, key);
        }
        public void Delete(Tkey key)
        {
            int hash = HashFunction(key);
            if (hashItemArr[hash].Key.Equals(key))
            {
                if (hashItemArr[hash].Child == null)
                {
                    hashItemArr[hash] = null;
                    counter--;
                }
                else
                {
                    hashItemArr[hash] = hashItemArr[hash].Child;
                }
            }
            else
            {
                Delete(hashItemArr[hash], key);
            }
        }
        private void Delete(HashItem<Tkey, TValue> root, Tkey key)
        {
            HashItem<Tkey, TValue> temp = root.Child;
            if (temp.Key.Equals(key))
            {
                if (root.Child == null)
                {
                    root.Child = null;
                }
                else
                {
                    root.Child = temp.Child;
                }
            }
            else
            {
                Delete(temp, key);
            }
        }
        private void ResizeHashTable()
        {
            List<HashItem<Tkey, TValue>> temp = ToList();
            hashItemArr = new HashItem<Tkey, TValue>[sizes.Dequeue()];
            counter = 0;
            foreach (var item in temp)
            {
                Add(item.Key, item.Value);
            }
        }
        private int HashFunction(Tkey key)
        {
            return Math.Abs(key.GetHashCode() % hashItemArr.Length);
        }
        public List<HashItem<Tkey, TValue>> ToList()
        {
            List<HashItem<Tkey, TValue>> list = new List<HashItem<Tkey, TValue>>();
            foreach (var item in hashItemArr)
            {
                if (item != null)
                {
                    HashItem<Tkey, TValue> root = item;
                    while (root != null)
                    {
                        list.Add(root);
                        root = root.Child;
                    }
                }
            }
            return list;
        }
        public IEnumerator<HashItem<Tkey, TValue>> GetEnumerator()
        {
            foreach (var item in ToList())
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class HashItem<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public int Hash { get; set; }
        public HashItem<TKey, TValue> Child { get; set; }
    }
}
