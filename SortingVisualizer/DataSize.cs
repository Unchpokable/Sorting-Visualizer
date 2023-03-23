using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class DataSize<T>
        where T : struct
    {
        public DataSize(int count)
        {
            _count = count;
        }

        public int ItemsCount => _count;
        public int TotalDataSetSize => _count * SizeOfType(typeof(T));

        private int _count;

        public override string ToString()
        {
            var size = SizeOfType(typeof(T)) * _count;
            var sizeString = size.ToString() + " B";
            if (size > 1024)
                sizeString = (size / 1024).ToString() + " KiB";
            return $"{_count} items, {sizeString}";
        }

        private static int SizeOfType(Type type)
        {
            var dm = new DynamicMethod("SizeOfType", typeof(int), new Type[] { });
            ILGenerator il = dm.GetILGenerator();
            il.Emit(OpCodes.Sizeof, type);
            il.Emit(OpCodes.Ret);
            return (int)dm.Invoke(null, null);
        }
    }
}
