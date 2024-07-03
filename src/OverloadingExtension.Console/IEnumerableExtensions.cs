using System;
using System.Collections.Generic;

namespace OverloagingExtension.Console
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Find<T>(this IEnumerable<T> source, Func<T, bool> isMatch)
        {
            foreach (var item in source)
            {
                if(isMatch(item))
                    yield return item;
            }
        }
    }
}