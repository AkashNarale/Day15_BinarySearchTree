using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_BinarySearchTree
{
    class binaryUC3<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public binaryUC3<T> leftTree { get; set; }
        public binaryUC3<T> rightTree { get; set; }

        public binaryUC3(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new binaryUC3<T>(item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new binaryUC3<T>(item);
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

        public bool IfExists(T element, binaryUC3<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Element is not present in Binary Search Tree");
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }
            return result;
        }
    }
}
