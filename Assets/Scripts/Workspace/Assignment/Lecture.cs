using UnityEngine;
using System.Collections.Generic;
using Unity.GraphToolkit.Editor;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            //string[]
            LinkedList<string> linkedlist  = new LinkedList<string>();

            //[Node1,2,0] -> null
            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddLast("Node 0");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            //Debug.Log(node1.Next.Next.Value);
            Debug.Log(node1.Previous.Value);

            var firsNode = linkedlist.First;
            var lastNode = linkedlist.Last;
            Debug.Log(firsNode.Previous);
            Debug.Log(lastNode.Next);

            //[Node 0.5] -> [Node 1]->[Node 1.5] ->[Node 2]-> null
            linkedlist.AddAfter(node1, "Node 1.5");
            //[Node 0] -> [Node 0.5] -> [Node 1]->[Node 1.5] ->[Node 2]-> null
            linkedlist.AddBefore(node1, "Node 0.5");

            //[Node 0.5] -> [Node 1]->[Node 1.5] ->[Node 2]-> null
            linkedlist.RemoveFirst();
            //[Node 0.5] -> [Node 1]->[Node 1.5] -> null
            linkedlist.RemoveLast();
            linkedlist.Remove("Node 1.5");
            
            //->null
            linkedlist.Clear();

            Debug.Log("-----");
            foreach (var item in linkedlist)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 5);
            table.Add(5, "Potion");

            foreach (var item in table)
            {
                Debug.Log($"item{item}");
            }
        }

        public void LCT04_SyntaxDictionary()
        {
            //เขียนสั้นลงอีกเเบบ var inv = new Dictionary<string, int>();
            Dictionary<string, int> inv = new Dictionary<string, int>();

            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            //potion : 5
            //banana : 1
            //apple : 0
            inv["Apple"] = 0;
            inv["Apple1"] = 1;

            int potion = inv["Potion"];
            Debug.Log("potion:" + potion);
            
            /*int apple2 = inv["Potion"];
            Debug.Log("apple2:" + apple2);*/

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log("hasPotion:" + hasPotion);

            inv.Remove("Banana");

            foreach (KeyValuePair<string, int> kvp in inv)
            {
                var key = kvp.Key;
                var value = kvp.Value;
                Debug.Log($"{key} => {value}");
                //inv.Add("mm", 1);
            }
            inv.Clear();
        }

        #endregion
    }
}
