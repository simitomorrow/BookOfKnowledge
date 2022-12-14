using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BookWindow : UI_Window
{
    [SerializeField] private BoolVariable isBookVisible;
    [SerializeField] private CanvasGroup bookUI;
    [SerializeField] private ActivePage activePage;

    [SerializeField] private UI_MainMenuPage mainMenuPage;
    [SerializeField] private UI_IngredientPage ingredientPage;
    [SerializeField] private UI_ElixirPage elixirPage;
    [SerializeField] private UI_IncidentPage incidentPage;

    private Dictionary<PageKeyword, BookPage> dictionary = new Dictionary<PageKeyword, BookPage>();

    void Start()
    {
        dictionary.Add(mainMenuPage.GetKeyword(), mainMenuPage);
        dictionary.Add(ingredientPage.GetKeyword(), ingredientPage);
        dictionary.Add(elixirPage.GetKeyword(), elixirPage);
        dictionary.Add(incidentPage.GetKeyword(), incidentPage);
    }

    public override void ToggleWindowVisible()
    {
        if (isBookVisible.value)
        {
            bookUI.alpha = 100f;
            bookUI.blocksRaycasts = true;
            bookUI.interactable = true;
            ToggleMouseCursorVisible();
            ShowBookPage();
        }
        else
        {
            bookUI.alpha = 0f;
            bookUI.blocksRaycasts = false;
            bookUI.interactable = false;
        }
    }

    private void ShowBookPage()
    {
        foreach (BookPage page in dictionary.Values)
        {
            page.Hide();
        }
        dictionary[activePage.keyword].Show();
    }
}
