using System.Net.NetworkInformation;

namespace Otus.QuickAndMergeSortings.SeventhHomework.Logic
{
    public class MergeSort
    {
        private int[] _array;

        public MergeSort(int[] array)
        {
            _array = array;
        }


        public int[] Run()
        {
            MergeSortInternal(0, _array.Length - 1);

            return _array;
        }


        #region Support methods

        private void MergeSortInternal(int l, int r)
        {
            if (l >= r)
                return;

            var middle = (l + r) / 2;

            MergeSortInternal(l, middle);
            MergeSortInternal(middle + 1, r);
            Merge(l, r, middle);
        }

        public void Merge(int l, int r, int x)
        {
            var firstArrayIndex = l;
            var secondArrayIndex = x + 1;

            var mergedArray = new int[r - l + 1];
            
            for (var i = 0; i < mergedArray.Length; i++)
            {
                if (firstArrayIndex == x + 1)
                {
                    mergedArray[i] = _array[secondArrayIndex];
                    secondArrayIndex++;
                    continue;
                }

                if (secondArrayIndex == r + 1)
                {
                    mergedArray[i] = _array[firstArrayIndex];
                    firstArrayIndex++;
                    continue;
                }

                int min;
                if (_array[firstArrayIndex] > _array[secondArrayIndex])
                {
                    min = _array[secondArrayIndex];
                    secondArrayIndex++;
                }
                else
                {
                    min = _array[firstArrayIndex];
                    firstArrayIndex++;
                }

                mergedArray[i] = min;
            }

            for (var i = l; i <= r; i++)
            {
                _array[i] = mergedArray[i - l];
            }
        }

        #endregion
    }
}
