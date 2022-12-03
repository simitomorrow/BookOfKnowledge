using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Interactables List", menuName = "Lists/Interactables List", order = 0)]
public class InteractablesList : ScriptableObject
{
    public List<Interactable> list = new List<Interactable>();
}
