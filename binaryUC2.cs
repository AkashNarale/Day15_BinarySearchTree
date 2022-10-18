using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day15_BinarySearchTree
{
    internal class binaryUC2<T> where T : IComparable
    {
        public T NodeData
        {
            get; set;
        }
        public binaryUC2<T> leftTree { get; set; }
        public binaryUC2<T> rightTree { get; set; }

        public binaryUC2(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new binaryUC2<T>(item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new binaryUC2<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }
        public void display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.display();
            }
        }
        public void size()
        {
            Console.WriteLine("\nSize of Binary Search Tree is" + " " + (1+ this.leftCount + this.rightCount));
        }
    }
}
