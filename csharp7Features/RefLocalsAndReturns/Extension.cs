using System;

namespace csharp7Features.RefLocalsAndReturns
{
    class Extension
    {
        public void Example()
        {
            var array = new int[] { 1, 4, 56, 7, 787, 877 };
            ref var valItem = ref ArraySearch.Find(array, (val) => val == 56);

            Console.WriteLine(valItem);
            valItem = 24;
            Console.WriteLine(array[2]);
        }
    }

    internal class ArraySearch
    {
        public static ref int Find(int[] array, Func<int, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return ref array[i];
                }
            }

            throw new InvalidOperationException("Not found");
        }
    }
}
