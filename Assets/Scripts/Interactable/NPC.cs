using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class NPC : MonoBehaviour, I_Interactable
{
    public void Interact()
    {
        Debug.Log("You talked to me.");
    }
}
