using UnityEngine;

[CreateAssetMenu(fileName = "Float Variable", menuName = "Variables/Float Variable", order = 2)]
public class FloatVariable : ScriptableObject
{
    public float value;

#if UNITY_EDITOR
    [Multiline]
    public string description = "";
#endif
}
