using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "Data/Effect", order = 0)]
public class EffectData : ScriptableObject
{
    public string effectName;
    public Sprite icon;
    [TextArea(3,10)]
    public string description;
}
