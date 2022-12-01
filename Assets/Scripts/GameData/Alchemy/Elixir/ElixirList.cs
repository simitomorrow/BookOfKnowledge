using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Elixir List", menuName = "Lists/Elixir List", order = 0)]
public class ElixirList : ScriptableObject
{
    public List<ElixirData> list = new List<ElixirData>();
}
