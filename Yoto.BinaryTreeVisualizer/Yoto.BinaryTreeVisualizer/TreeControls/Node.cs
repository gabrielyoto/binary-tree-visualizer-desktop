using System;
using System.Collections.Generic;
using System.Text;

namespace Yoto.BinaryTreeVisualizer.TreeControls
{
    public class Node
    {
        public enum Balance
        {
            Left,
            Right,
            Center
        }

        public int Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public Balance Bal { get; set; }
        public Node(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
