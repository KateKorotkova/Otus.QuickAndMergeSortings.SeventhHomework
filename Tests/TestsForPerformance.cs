using System;
using NUnit.Framework;
using Otus.QuickAndMergeSortings.SeventhHomework.Logic;

namespace Tests
{
    public class TestsForPerformance
    {
        private Random _random = new Random();


        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        [TestCase(1000000)]
        public void Classic_Quick_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new QuickSortClassic(array).Run();
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        [TestCase(1000000)]
        public void Modern_Quick_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new QuickSortModern(array).Run();
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        [TestCase(1000000)]
        public void Merge_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new MergeSort(array).Run();
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }



        #region Helpers

        private int[] GenerateArray(int size)
        {
            var array = new int[size];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = _random.Next();
            }

            return array;
        }

        #endregion
    }
}