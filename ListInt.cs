namespace NullAbleStructEnumİndexer
{
    internal class ListInt
    {
        private int[] _array;
        public int Length
        {

            get { return _array.Length; }
        }
        public int this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }




        public ListInt()
        {
            _array = new int[0];
        }
        public ListInt(int length)
        {
            _array = new int[length];
        }

        public void Add(int value)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = value;
        }
        public void AddRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }

        }
        public bool Contanins(int num)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                sum += _array[i];
            }
            return sum;
        }
        public void Remove(int num)
        {
            int findIndex = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == num)
                {
                    findIndex = i;
                    break;
                }
            }
            for (int i = findIndex; i < _array.Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            Array.Resize(ref _array, _array.Length - 1);
        }
        public void RemoveRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Remove(nums[i]);
            }
        }
        public override string ToString()
        {
            string arrString = "";
            for (int i = 0; i < _array.Length - 1; i++)
            {
                arrString += $"{_array[i]},";
            }
            arrString += _array[_array.Length - 1];
            return arrString;
        }
    }
}
