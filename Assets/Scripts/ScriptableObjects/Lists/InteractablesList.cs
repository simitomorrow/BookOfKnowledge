using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Interactables List", menuName = "Lists/Interactables List", order = 0)]
public class InteractablesList : ScriptableObject
{
    public List<I_Interactable> list = new List<I_Interactable>();
}
