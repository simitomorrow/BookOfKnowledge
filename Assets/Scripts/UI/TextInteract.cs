using TMPro;
using UnityEngine;

public class TextInteract : MonoBehaviour
{
    public InteractablesList interactables;
    public TextMeshProUGUI text;
    private int previousCount;

    private void Start()
    {
        previousCount = interactables.Count();
        UpdateText();
    }

    private void Update()
    {
        if (interactables.Count() != previousCount)
        {
            UpdateText();
        }
    }

    public void UpdateText()
    {
        if (interactables.Count() > 0)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }

        previousCount = interactables.Count();
    }
}
