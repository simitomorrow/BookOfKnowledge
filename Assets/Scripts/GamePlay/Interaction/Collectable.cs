using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Collectable : MonoBehaviour, Interactable
{
    public InteractablesList interactables;
    public IngredientData ingredient;
    public GameEvent event_UI_updateOwnedAmount;

    public void Interact()
    {
        if (!ingredient.hasBeenDiscovered)
        {
            Debug.Log("TODO: new object discovered message?");
            ingredient.hasBeenDiscovered = true;
        }
        ingredient.amountOwned++;
        event_UI_updateOwnedAmount.Raise();
        Debug.Log("TODO: play a sound");
        interactables.list.Remove(this);
        Destroy(this.gameObject);
    }
}
