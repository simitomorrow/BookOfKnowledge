using UnityEngine;

[CreateAssetMenu(fileName = "Integer Variable", menuName = "Variables/Integer Variable", order = 1)]
public class IntVariable : ScriptableObject
{
    public int value;

#if UNITY_EDITOR
    [Multiline]
    public string description = "";
#endif
}
