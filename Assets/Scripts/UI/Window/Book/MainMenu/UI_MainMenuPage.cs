using UnityEngine;

public class UI_MainMenuPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private GameObject mainMenu;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        mainMenu.SetActive(false);
    }

    public void Show()
    {
        mainMenu.SetActive(true);
    }
}
