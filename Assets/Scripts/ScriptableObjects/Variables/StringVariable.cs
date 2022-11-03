using UnityEngine;

[CreateAssetMenu(fileName = "String Variable", menuName = "Variables/String Variable", order = 3)]
public class StringVariable : ScriptableObject
{
    [Multiline]
    public string text;

#if UNITY_EDITOR
    [Multiline]
    public string description = "";
#endif
}
