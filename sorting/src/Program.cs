using System;
using System.Text;
using System.Collections.Generic;
using Sorting.Sorters;

namespace Sorting {
    public static class Program {
        public static void Main(string [] args) {
            Sorter sorter = new QuickSortSorter();

            List<int> items = new List<int> {
                5, 9, 1, 12, 7, 9, 2, 3, 99, 0
            };

            Program.PrintList(items);

            IList<int> sorted = sorter.Sort(items);

            Program.PrintList(sorted);
        }

        public static void PrintList<T>(IList<T> items) {
            StringBuilder str = new StringBuilder();
            str.Append("[");

            bool firstItem = true;

            foreach (T item in items) {
                if (!firstItem) {
                    str.Append(", ");
                } else {
                    firstItem = false;
                }

                str.Append(item);
            }

            str.Append("]");

            Console.WriteLine(str);
        }
    }
}
