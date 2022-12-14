using UnityEngine;

public class UI_IngredientPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private CanvasGroup ingredients;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        ingredients.alpha = 0f;
        ingredients.blocksRaycasts = false;
        ingredients.interactable = false;
    }

    public void Show()
    {
        ingredients.alpha = 100f;
        ingredients.blocksRaycasts = true;
        ingredients.interactable = true;
    }
}
