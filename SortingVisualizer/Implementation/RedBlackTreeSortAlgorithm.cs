using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal class RedBlackTreeSortAlgorithm : VisualisableSortingAlgorithm
    {
        public RedBlackTreeSortAlgorithm(Graphics graphics) : base(SortingAlgorithmType.RedBlackTreeSort, graphics) { }

        public override string ToString()
        {
            return "Red-Black tree sort";
        }

        public override IList<int> Execute(IList<int> collection)
        {
            throw new IncompatiableRuntimeEnvironment("Unable to run 'red-black tree' sorting. Dynamic Library not found: RedBlackTree.dll");
        }

        private class IncompatiableRuntimeEnvironment : Exception
        {
            public IncompatiableRuntimeEnvironment(string message) : base(message) { }
        }
    }
}
