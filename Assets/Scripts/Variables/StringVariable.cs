using UnityEngine;

[CreateAssetMenu(fileName = "String Variable", menuName = "Primitives/String Variable", order = 3)]
public class StringVariable : ScriptableObject
{
    public string text;

#if UNITY_EDITOR
    [Multiline]
    public string description = "";
#endif
}
