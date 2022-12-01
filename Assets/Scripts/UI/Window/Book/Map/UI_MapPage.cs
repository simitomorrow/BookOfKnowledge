using UnityEngine;

public class UI_MapPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private GameObject map;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        map.SetActive(false);
    }

    public void Show()
    {
        map.SetActive(true);
    }
}
