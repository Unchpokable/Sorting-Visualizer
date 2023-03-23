using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal sealed class BubbleSortAlgorithm: VisualisableSortingAlgorithm
    {
        public BubbleSortAlgorithm(Graphics graphics) : base(SortingAlgorithmType.Bubble, graphics) { }

        public override string ToString()
        {
            return "Bubble sort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            _collection = collection;
            ReDraw();
            BubbleSort();
            ReDraw(useDelay: true);
            return collection;
        }

        private void BubbleSort()
        {
            for (int i = 0; i < _collection.Count - 1; i++)
                for (int k = 0; k < _collection.Count - i - 1; k++)
                {
                    if (_collection[k] > _collection[k + 1])
                    {
                        var temp = _collection[k];
                        _collection[k] = _collection[k + 1];
                        _collection[k + 1] = temp;
                        DrawBar(k + 1);
                        DrawBar(k);
                    }
                }
        }
    }
}
