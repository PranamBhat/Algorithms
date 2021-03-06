﻿using Algorithms.SortAlgorithms;

namespace AlgorithmsTests.SortAlgorithms
{
    class SorterStringTester : ISorterTester<string>
    {
        public void TestSortedSequence(ISorter<string> sorter)
        {
            var input = new string[] { "a", "b", "c", "d", "e" };
            var expected = new string[] { "a", "b", "c", "d", "e" };
            SorterTestsHelper.TestSorter(input, expected, sorter);
        }

        public void TestReverseSortedSequence(ISorter<string> sorter)
        {
            var input = new string[] { "e", "d", "c", "b", "a" };
            var expected = new string[] { "a", "b", "c", "d", "e" };
            SorterTestsHelper.TestSorter(input, expected, sorter);
        }

        public void TestRandomSequence(ISorter<string> sorter)
        {
            var input = new string[] { "e", "d", "c", "bd", "abc", "ab" };
            var expected = new string[] { "ab", "abc", "bd", "c", "d", "e" };
            SorterTestsHelper.TestSorter(input, expected, sorter);
        }
    }
}
