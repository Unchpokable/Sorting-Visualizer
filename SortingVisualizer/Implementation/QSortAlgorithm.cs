using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal class QSortAlgorithm : VisualisableSortingAlgorithm
    {
        public QSortAlgorithm(Graphics graphics) : base(SortingAlgorithmType.QSort, graphics) { }

        public override string ToString()
        {
            return "QSort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            _collection = collection;    
            ReDraw();
            QuickSort(0, _collection.Count - 1);
            ReDraw(useDelay: true);
            return _collection;
        }

        private void QuickSort(int start, int end)
        {
            if (start >= end)
                return;
            var pivot = Partition(start, end);
            QuickSort(start, pivot - 1);
            QuickSort(pivot + 1, end);
        }

        private int Partition(int start, int end)
        {
            int temp;
            var partitionMarker = start;
            for (var i = start; i < end; i++)
            {
                if (_collection[i] < _collection[end])
                {
                    temp = _collection[partitionMarker];
                    _collection[partitionMarker] = _collection[i];
                    DrawBar(partitionMarker);
                    _collection[i] = temp;
                    DrawBar(i);
                    partitionMarker++;
                }
            }

            temp = _collection[partitionMarker];
            _collection[partitionMarker] = _collection[end];
            DrawBar(partitionMarker);
            _collection[end] = temp;
            DrawBar(end);
            return partitionMarker;
        }
    }
}
