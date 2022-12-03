using UnityEngine;

public class UI_IncidentPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private GameObject incidents;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        incidents.SetActive(false);
    }

    public void Show()
    {
        incidents.SetActive(true);
    }
}
