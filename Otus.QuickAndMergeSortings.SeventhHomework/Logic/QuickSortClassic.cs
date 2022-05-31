namespace Otus.QuickAndMergeSortings.SeventhHomework.Logic
{
    public class QuickSortClassic
    {
        private int[] _array;

        public QuickSortClassic(int[] array)
        {
            _array = array;
        }


        public int[] Run()
        {
            QuickSort(0, _array.Length - 1);

            return _array;
        }


        #region Support methods

        private void QuickSort(int l, int r)
        {
            if (l >= r)
                return;

            var pivotIndex = Split(l, r);
            
            QuickSort(l, pivotIndex);
            QuickSort(pivotIndex + 1, r);
        }

        private int Split(int l, int r)
        {
            var pivot = _array[r];

            var i = l;
            var j = r;
            while (i <= j)
            {
                while (_array[i] < pivot)
                {
                    i++;
                }

                while (_array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
            }

            return j;
        }

        private void Swap(int x, int y)
        {
            var tmp = _array[x];
            _array[x] = _array[y];
            _array[y] = tmp;
        }

        #endregion
    }
}
