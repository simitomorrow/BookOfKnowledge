using TMPro;
using UnityEngine;

public class UI_TextInteract : MonoBehaviour
{
    public InteractablesList interactables;
    public CanvasGroup textGroup;
    private int previousCount;

    private void Start()
    {
        previousCount = interactables.list.Count;
        UpdateText();
    }

    private void Update()
    {
        if (interactables.list.Count != previousCount)
        {
            UpdateText();
        }
    }

    public void UpdateText()
    {
        if (interactables.list.Count > 0)
        {
            textGroup.alpha = 1;
        }
        else
        {
            textGroup.alpha = 0;
        }

        previousCount = interactables.list.Count;
    }
}
