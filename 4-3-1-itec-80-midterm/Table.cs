using System.Collections;

namespace _4_3_1_itec_80_midterm
{
    public class Table<RowType> : IList<RowType>
    {
        protected readonly List<RowType> _rows = new();

        public int Count => _rows.Count;

        public bool IsReadOnly => false;

        public RowType this[int index]
        {
            get => _rows[index];
            set => _rows[index] = value;
        }

        public int IndexOf(RowType item)
        {
            return _rows.IndexOf(item);
        }

        public void Insert(int index, RowType item)
        {
            _rows.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _rows.RemoveAt(index);
        }

        public void Add(RowType item)
        {
            _rows.Add(item);
        }

        public void Clear()
        {
            _rows.Clear();
        }

        public bool Contains(RowType item)
        {
            return _rows.Contains(item);
        }

        public void CopyTo(RowType[] array, int arrayIndex)
        {
            _rows.CopyTo(array, arrayIndex);
        }

        public bool Remove(RowType item)
        {
            return _rows.Remove(item);
        }

        public IEnumerator<RowType> GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (_rows as IEnumerable).GetEnumerator();
        }
    }

    public class Row<T>
    {
        protected T _id;
        public virtual T id
        {
            get => _id;
        }

        public Row() { }

        public Row(T id)
        {
            _id = id;
            var table = new Table<string>();
        }
    }

    public class Rock : Row<string> { }
}
