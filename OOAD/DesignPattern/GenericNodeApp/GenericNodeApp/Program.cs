using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> node1 = new Node<string>();
            node1.Data = "mumbai";

            Node<string> node2 = new Node<string>();
            node2.Data = "pune";

            Node<string> node3 = new Node<string>();
            node3.Data = "ahmednagar";

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = null;

            printDetails(node1);
        }

        private static void printDetails(Node<string> node1)
        {
            Console.WriteLine(node1.Data);
            Console.WriteLine(node1.Next);
        }

        
    }
}
