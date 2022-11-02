using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private BoolVariable canInteract;
    [SerializeField] private InteractablesList interactables;
    [SerializeField] private GameEvent interactEvent;

    private Inputs inputs;
    private InputAction interact;

    private void Awake()
    {
        inputs = new Inputs();
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

    private void OnTriggerEnter(Collider other)
    {
        I_Interactable interactable = other.gameObject.GetComponent<I_Interactable>();
        if (interactable != null)
        {
            interactables.Add(interactable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        I_Interactable interactable = other.gameObject.GetComponent<I_Interactable>();
        if (interactable != null)
        {
            interactables.Remove(interactable);
        }
    }

    private void Interacting(InputAction.CallbackContext context)
    {
        if(interactables.Count() > 0)
        {
            interactables.objects[0].Interact();
        }
    }
}
