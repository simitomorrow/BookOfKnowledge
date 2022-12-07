using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class NPC : MonoBehaviour, Interactable
{
    public void Interact()
    {
        Debug.Log("TODO: DialogueWindow?");
    }
}
