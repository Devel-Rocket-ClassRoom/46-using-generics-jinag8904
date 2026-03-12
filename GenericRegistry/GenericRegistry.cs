using System;

class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    TKey[] keys;
    TValue[] values;
    public int Count { get; set; }

    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
    }

    public void Register(TKey key, TValue value)
    {
        if (!Contains(key))
        {
            keys[Count] = key;
            values[Count++] = value;
        }

        else
        {
            values[Array.IndexOf(keys, key)] = value;
        }
    }

    public TValue Find(TKey key)
    {
        int index = Array.IndexOf(keys, key);
        if (index < 0) return default(TValue);
        return values[index];
    }

    public bool Contains(TKey key)
    {
        return Array.IndexOf(keys, key) != -1 ? true : false;
    }

    public void PrintAll()
    {
        for (int i = 0;  i < Count; i++)
        {
            Console.WriteLine($"[{keys[i]}] {Find(keys[i])}");
        }
    }
}