using System.Collections.Generic;
using UnityEngine;

public abstract class A_ObjectList<T> : ScriptableObject
{
    public List<T> objects = new List<T>();

    public void Add(T thing)
    {
        if (!objects.Contains(thing))
            objects.Add(thing);
    }

    public void Remove(T thing)
    {
        if (objects.Contains(thing))
            objects.Remove(thing);
    }

    public int Count()
    {
        return objects.Count;
    }
}