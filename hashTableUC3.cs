using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    public class hashTableUC3<K, V>
    {

        private readonly int size;
        //passing the key value pair to the linked list
        private readonly LinkedList<KeyValue3<K, V>>[] iteams;

        /// <summary>
        /// constructor to initialize
        /// </summary>
        /// <param name="size"></param>
        public hashTableUC3(int size)
        {
            this.size = size;
            this.iteams = new LinkedList<KeyValue3<K, V>>[size];
        }
        /// <summary>
        /// method to fing the postion of the hash(creating hash code)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected int getArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        /// <summary>
        /// method to get a value stored in particular key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V Get(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue3<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue3<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }

            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue3<K, V>> linkedList = GetLinkedList(position);
            //object of keyvalue
            //object initialization(declaration and initialiation at a one time)
            //It doesnot invoke constructor
            KeyValue3<K, V> item = new KeyValue3<K, V>() { key = key, value = value };
            //assign values to Key and Value
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue3<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue3<K, V> foundItem = default(KeyValue3<K, V>);
            foreach (KeyValue3<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }


        }
        //method getlinkedlist, has  a return type linkist as a key value pair
        //parameter is position it will be an index
        protected LinkedList<KeyValue3<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue3<K, V>> linkedList = iteams[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue3<K, V>>();
                iteams[position] = linkedList;
            }
            return linkedList;

        }



    }
    /// <summary>
    /// this method is for passing Keyvales in linkedlist
    /// where k,v are data types
    /// </summary>
    /// <typeparam name="k"></typeparam>
    /// <typeparam name="v"></typeparam>
    public struct KeyValue3<k, v>
    {
        public k key { get; set; }
        public v value { get; set; }
    }
}
