using UnityEngine;

[CreateAssetMenu(fileName = "Boolean Variable", menuName = "Primitives/Boolean Variable", order = 0)]
public class BoolVariable : ScriptableObject
{
    public bool status;

#if UNITY_EDITOR
    [Multiline]
    public string description = "";
#endif
}
