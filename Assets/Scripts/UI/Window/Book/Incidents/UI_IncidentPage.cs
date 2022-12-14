using UnityEngine;

public class UI_IncidentPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private CanvasGroup incidents;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        incidents.alpha = 0f;
        incidents.blocksRaycasts = false;
        incidents.interactable = false;
    }

    public void Show()
    {
        incidents.alpha = 100f;
        incidents.blocksRaycasts = true;
        incidents.interactable = true;
    }
}
