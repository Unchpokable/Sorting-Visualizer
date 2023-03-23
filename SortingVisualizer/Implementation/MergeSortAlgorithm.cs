using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal class MergeSortAlgorithm : VisualisableSortingAlgorithm
    {
        public MergeSortAlgorithm(Graphics graphics) : base(SortingAlgorithmType.MergeSort, graphics) { }

        public override string ToString()
        {
            return "Merge sort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            _collection = collection;
            ReDraw();
            MergeSort(0, _collection.Count - 1);
            ReDraw(useDelay: true);
            return _collection;
        }

        private void MergeSort(int left, int right)
        {
            if (left >= right) return;

            var middle = left + (right - left) / 2;
            MergeSort(left, middle);
            MergeSort(middle + 1, right);
            MergeArrays(left, middle, right);
        }

        private void MergeArrays(int left, int middle, int right)
        {
            var leftLength = middle - left + 1;
            var rightLength = right - middle;
            var leftTempArray = new int[leftLength];
            var rightTempArray = new int[rightLength];

            int i, j;

            for (i = 0; i < leftLength; ++i)
                leftTempArray[i] = _collection[left + i];
            for (j = 0; j < rightLength; ++j)
                rightTempArray[j] = _collection[middle + 1 + j];

            i = 0;
            j = 0;
            var k = left;

            while (i < leftLength && j < rightLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                    _collection[k++] = leftTempArray[i++];
                else
                    _collection[k++] = rightTempArray[j++];
                DrawBar(k);
            }

            while (i < leftLength)
            {
                _collection[k++] = leftTempArray[i++];
                if (k < _collection.Count)
                    DrawBar(k);
            }

            while (j < rightLength)
            {
                _collection[k++] = rightTempArray[j++];
                if (k < _collection.Count)
                    DrawBar(k);
            }
        }
    }
}
