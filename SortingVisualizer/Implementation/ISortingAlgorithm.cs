using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal interface ISortingAlgorithm<T>
        where T : IComparable<T>, IEquatable<T>
    {
        SortingAlgorithmType Type { get; }
        IList<T> Execute(IList<T> collection);
    }
}
