using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation.DataStructures
{
    internal class BinaryTreeNode<TElem> : IComparable<BinaryTreeNode<TElem>>
        where TElem : IComparable<TElem>
    {
        public BinaryTreeNode(TElem data)
        {
            _data = data;
        }

        private TElem _data;
        private BinaryTreeNode<TElem> _left;
        private BinaryTreeNode<TElem> _right;

        public void Insert(BinaryTreeNode<TElem> node)
        {
            if (_data.CompareTo(node._data) > 0)
            {
                if (_left == null)
                    _left = node;
                else
                    _left.Insert(node);
            }
            else
            {
                if (_right == null)
                    _right = node;
                else
                    _right.Insert(node);
            }
        }

        public int CompareTo(BinaryTreeNode<TElem> other)
        {
            return _data.CompareTo(other._data);
        }

        public IList<TElem> ToList(IList<TElem> elements = null)
        {
            if (elements == null)
                elements = new List<TElem>();
            if (_left != null)
                _left.ToList(elements);

            elements.Add(_data);

            if (_right != null)
                _right.ToList(elements);

            return elements;
        }
    }
}
