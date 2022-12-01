using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Collectable : MonoBehaviour, Interactable
{
    public InteractablesList interactables;
    public void Interact()
    {
        Debug.Log("TODO: add to inventory and play a sound");
        interactables.list.Remove(this);
        Destroy(this.gameObject);
    }
}
