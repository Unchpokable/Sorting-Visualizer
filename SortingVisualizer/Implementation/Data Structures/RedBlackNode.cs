
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation.DataStructures
{
    internal sealed class RedBlackNode : IComparable<RedBlackNode>
    {
        public RedBlackNode(IComparable data) : this(data, null, null) { }

        public RedBlackNode(IComparable data, RedBlackNode left, RedBlackNode right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public IComparable Data { get; set; }
        public RedBlackNode Left { get; set; }
        public RedBlackNode Right { get; set; }
        public RedBlackColor Color { get; set; } = RedBlackColor.Black;

        public int CompareTo(RedBlackNode other)
        {
            return Data.CompareTo(other.Data);
        }
    }
}
