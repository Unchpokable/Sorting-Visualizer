using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal class InsertionSortAlgorithm: VisualisableSortingAlgorithm
    {
        public InsertionSortAlgorithm(Graphics graphics) : base(SortingAlgorithmType.InsertionSort, graphics) { }

        public override string ToString()
        {
            return "Insertion sort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            _collection = collection;
            ReDraw();
            InsertionSort();
            ReDraw(useDelay: true);
            return _collection;
        }

        private void InsertionSort()
        {
            for (var i = 0; i < _collection.Count - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (_collection[j - 1] > _collection[j])
                    {
                        var temp = _collection[j - 1];
                        _collection[j - 1] = _collection[j];
                        DrawBar(j - 1);
                        _collection[j] = temp;
                        DrawBar(j);
                    }
                }
            }
        }
    }
}
