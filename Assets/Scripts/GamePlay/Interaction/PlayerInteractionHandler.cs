using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionHandler : MonoBehaviour
{
    [SerializeField] private InteractablesList interactables;
    [SerializeField] private BoolVariable canInteract;
    [SerializeField] private GameEvent interactEvent;

    private Inputs inputs;
    private InputAction interact;

    private void Awake()
    {
        inputs = new Inputs();
        inputs.Book.Disable();
        inputs.Book.Enable();
    }

    private void OnEnable()
    {
        interact = inputs.Player.Interact;
        interact.Enable();
        interact.performed += Interacting;
    }

    private void OnDisable()
    {
        interact.Disable();
    }

    private void Interacting(InputAction.CallbackContext context)
    {
        if (interactables.list.Count > 0)
        {
            interactables.list[0].Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Interactable interactable = other.gameObject.GetComponent<Interactable>();
        if (interactable != null)
        {
            interactables.list.Add(interactable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Interactable interactable = other.gameObject.GetComponent<Interactable>();
        if (interactable != null)
        {
            interactables.list.Remove(interactable);
        }
    }
}
