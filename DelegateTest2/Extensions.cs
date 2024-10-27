using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest2
{
    static class Extensions
    {

        //public static IEnumerable<T> getElementsByCondition<T>(this IEnumerable<T> array, Func<T, bool> condition)
        //{
        //    foreach (T item in array)
        //    {
        //        if (condition(item))
        //        {
        //            yield return item;
        //        }
        //    }
        //}

        public static void MakeAction<T>(this IEnumerable<T> array,Action<T> action)
        {
            foreach (T item in array)
            {
                action(item);
            }
        }
            
    }
}
