using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation.DataStructures
{
    internal class RedBlackTree<TElem> 
        where TElem : IComparable<TElem>
    {
        public RedBlackTree()
        {
            _freshNode = new RedBlackNode(null);
            _freshNode.Left = _freshNode.Right = _freshNode;
            _root = new RedBlackNode(null);
        }

        private RedBlackNode _root;
        private RedBlackNode _freshNode;
        private RedBlackNode _currentNode;
    }
}
