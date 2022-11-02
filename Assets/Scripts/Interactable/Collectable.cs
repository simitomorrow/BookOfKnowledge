using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Collectable : MonoBehaviour, I_Interactable
{
    public InteractablesList interactables;
    public void Interact()
    {
        Debug.Log("TODO: add to inventory and play a sound");
        interactables.Remove(this);
        Destroy(this.gameObject);
    }
}
