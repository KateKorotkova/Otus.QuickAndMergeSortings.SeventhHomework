namespace Otus.QuickAndMergeSortings.SeventhHomework.Logic
{
    public class QuickSortModern
    {
        private int[] _array;

        public QuickSortModern(int[] array)
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
            
            QuickSort(l, pivotIndex - 1);
            QuickSort(pivotIndex + 1, r);
        }

        private int Split(int l, int r)
        {
            var pivot = _array[r];
            var m = l - 1;

            for (var i = l; i <= r; i++)
            {
                if (_array[i] <= pivot && i != m)
                {
                    m++;
                    Swap(m, i);
                }
            }

            return m;
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
