
namespace ObjectOrientedProgramming.Business
{
    public class Collection<T>
    {
        private T[] _elements;
        private int _index;
        private int _limit;

        public Collection(int limit)
        {
            _limit = limit;
            _elements = new T[_limit];
            _index = 0;
        }

        public void Add(T element)
        {
            if (_index < _limit)
            {
                _elements[_index] = element;
                _index++;
            }
        }

        public T[] Get() => _elements;

    }
}
