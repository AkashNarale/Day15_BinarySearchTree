using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_BinarySearchTree
{
    internal class binaryUC1<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public binaryUC1<T> leftTree { get; set; }
        public binaryUC1<T> rightTree { get; set; }

        public binaryUC1(T nodedata)
        {
            this.NodeData = nodedata;
            this.rightTree = null;
            this.leftTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new binaryUC1<T>(item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new binaryUC1<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }
        public void display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.display();    
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.display();
            }
        }
    }
}
