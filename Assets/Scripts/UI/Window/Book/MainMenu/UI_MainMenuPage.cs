using UnityEngine;

public class UI_MainMenuPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private CanvasGroup mainMenu;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        mainMenu.alpha = 0f;
        mainMenu.blocksRaycasts = false;
        mainMenu.interactable = false;
    }

    public void Show()
    {
        mainMenu.alpha = 100f;
        mainMenu.blocksRaycasts = true;
        mainMenu.interactable = true;
    }
}
