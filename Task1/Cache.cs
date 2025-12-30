using System;

namespace Task1;

 public static class Cache<T>
{
    public static List<T> caches = new List<T>();

    public static void Add(T item)
    {
        caches.Add(item);
    }

    public static T Get(int index)
    {
        return caches[index];
    }

    public static void Remove(T item)
    {
        caches.Remove(item);
    }


    
}
