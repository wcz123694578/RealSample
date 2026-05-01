using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Shared {
    public static class EnumerableExtentions {
        public static List<T> ToList<T>(IEnumerable<T> source) {
            List<T> list = new List<T>();

            foreach (T item in source) {
                list.Add(item);
            }

            return list;
        }
    }
}
