using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyTree
{
    internal class MyTree<T>: IEnumerable<T> where T : IComparable<T>
    {
        private MyTreeNode<T>? root;

        public void Insert(T value)
        {
            MyTreeNode<T> newNode = new MyTreeNode<T>(value);
            if (root == null)
                root = new MyTreeNode<T>(value);
            else
                Insert(root, newNode);
        }
        private void Insert(MyTreeNode<T> parent, MyTreeNode<T> newNode)
        {
            if (newNode.value.CompareTo(parent.value) == -1)
            {
                if (parent.left == null)
                {
                    parent.left = newNode;
                    newNode.parent = parent;
                }
                else Insert(parent.left, newNode);
            }
            else if (newNode.value.CompareTo(parent.value) == 1)
            {
                if (parent.right == null)
                {
                    parent.right = newNode;
                    newNode.parent = parent;
                }
                else Insert(parent.right, newNode);
            }
        }
        public bool Contains(T value)
        {
            if (root == null) { throw new Exception("tree is not created"); }
            return Contains(root, value);
        }

        private bool Contains(MyTreeNode<T> node, T value)
        {
            if (node.value.CompareTo(value) == 1)
            {
                if (node.left == null) 
                    return false;
                else 
                    return Contains(node.left, value);
            }
            else if (node.value.CompareTo(value) == -1)
            {
                if (node.right == null) 
                    return false;
                else 
                    return Contains(node.right, value);
            }
            else 
            { 
                return true; 
            }
        }
        //----------------------------------------------------------Проходы-----------------------------------------------------
        public List<MyTreeNode<T>> CLR()
        {
            if (root == null) { throw new Exception("tree is not created"); }
            return CLR(root);
        }
        private List<MyTreeNode<T>> CLR(MyTreeNode<T> node)
        {
            List<MyTreeNode<T>> tempList = new List<MyTreeNode<T>> { node };
            if (node.left != null)
                tempList.AddRange(CLR(node.left));
            if (node.right != null)
                tempList.AddRange(CLR(node.right));
            return tempList;
        }
        public List<MyTreeNode<T>> LCR()
        {
            if (root == null) { throw new Exception("tree is not created"); }
            return LCR(root);
        }
        private List<MyTreeNode<T>> LCR(MyTreeNode<T> node)
        {
            List<MyTreeNode<T>> tempList = new List<MyTreeNode<T>>();
            if (node.left != null)
                tempList.AddRange(LCR(node.left));
            tempList.Add(node);
            if (node.right != null)
                tempList.AddRange(LCR(node.right));
            return tempList;
        }

        public List<MyTreeNode<T>> RCL()
        {
            if (root == null) { throw new Exception("tree is not created"); }
            return RCL(root);
        }
        private List<MyTreeNode<T>> RCL(MyTreeNode<T> node)
        {
            List<MyTreeNode<T>> tempList = new List<MyTreeNode<T>>();
            if (node.right != null)
                tempList.AddRange(RCL(node.right));
            tempList.Add(node);
            if (node.left != null)
                tempList.AddRange(RCL(node.left));
            return tempList;
        }
        public List<MyTreeNode<T>> Across()
        {
            if (root == null) { throw new Exception("tree is not created"); }
            List<MyTreeNode<T>> resultingList = new List<MyTreeNode<T>>();
            Queue<MyTreeNode<T>> queue = new Queue<MyTreeNode<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                MyTreeNode<T> node = queue.Dequeue();
                resultingList.Add(node);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            return resultingList;
        }
        public List<MyTreeNode<T>> LRC()
        {
            if (root == null) { throw new Exception("tree is not created"); }
            return LRC(root);
        }
        private List<MyTreeNode<T>> LRC(MyTreeNode<T> node)//обход по возрастанию
        {
            List<MyTreeNode<T>> tempList = new List<MyTreeNode<T>>();
            if (node.left != null)
                tempList.AddRange(LRC(node.left));
            if (node.right != null)
                tempList.AddRange(LRC(node.right));
            tempList.Add(node);
            return tempList;
        }
        //--------------------------------------------------------------------------------------------------------------------
        public void Delete(T value)
        {
            if (root == null) { throw new Exception("tree is not created"); }
            Delete(root, value);
        }
        private void Delete(MyTreeNode<T> node, T value)
        {
            if (node.value.CompareTo(value) == 1)
            {
                if (node.left == null) 
                    throw new Exception("Element not found");
                else 
                    Delete(node.left, value);
            }
            else if (node.value.CompareTo(value) == -1)
            {
                if (node.right == null) 
                    throw new Exception("Element not found");
                else
                    Delete(node.right, value);
            }
            else
            {
                if (node.left == null && node.right == null)
                {
                    if (node.parent.value.CompareTo(node.value) == 1)
                        node.parent.left = null;
                    if (node.parent.value.CompareTo(node.value) == -1)
                        node.parent.right = null;
                    node.parent = null;
                }
                else if (node.left == null || node.right == null)
                {
                    if (node.parent.value.CompareTo(node.value) == 1)
                    {
                        if (node.left == null)
                        {
                            node.parent.left = node.right;
                            node.right.parent = node.parent;
                        }
                        else
                        {
                            node.parent.left = node.left;
                            node.left.parent = node.parent;
                        }
                    }
                    if (node.parent.value.CompareTo(node.value) == -1)
                    {
                        if (node.left == null)
                        {
                            node.parent.right = node.right;
                            node.right.parent = node.parent;
                        }
                        else
                        {
                            node.parent.right = node.left;
                            node.left.parent = node.parent;
                        }
                    }
                }
                else
                {
                    MyTreeNode<T> max_node = node.left;
                    while (max_node.right != null)
                    {
                        max_node = max_node.right;
                    }
                    if (max_node.parent.value.CompareTo(max_node.value) == 1)
                        max_node.parent.left = null;
                    if (max_node.parent.value.CompareTo(max_node.value) == -1)
                        max_node.parent.right = null;
                    max_node.parent = null;
                    node.value = max_node.value;
                }
                return;
            }
        }
        public List<T> ToList()
        {
            List<T> list = new List<T>();
            foreach (var item in LCR())
            {
                list.Add(item.value);
            }
            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in LRC())
            {
                yield return item.value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public class MyTreeNode<TValue> //пришлось из за проходов сделать public, т.к "возвращает последовательность ЭЛЕМЕНТОВ".
        {
            public MyTreeNode(TValue value)
            {
                this.value = value;
            }
            public TValue value;
            public MyTreeNode<TValue>? left;
            public MyTreeNode<TValue>? right;
            public MyTreeNode<TValue>? parent;
        }
    }
}
