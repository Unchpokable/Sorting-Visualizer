using System;
using System.Collections.Generic;
using System.Drawing;
using Sorting.Implementation.DataStructures;

namespace Sorting.Implementation
{
    internal class SortTreeAlgorithm : VisualisableSortingAlgorithm
    {
        public SortTreeAlgorithm(Graphics graphics) : base(SortingAlgorithmType.SortTree, graphics) { }

        public override string ToString()
        {
            return "SortTree sort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            _collection = collection;
            ReDraw(useDelay: true);
            TreeSort();
            ReDraw(useDelay: true); 
            return _collection;
        }

        private void TreeSort()
        {
            if (_collection == null || _collection.Count == 0) return;

            var node = new BinaryTreeNode<int>(_collection[0]);
            foreach (var item in _collection)
                node.Insert(new BinaryTreeNode<int>(item));
            _collection = node.ToList();
        }
    }
}
