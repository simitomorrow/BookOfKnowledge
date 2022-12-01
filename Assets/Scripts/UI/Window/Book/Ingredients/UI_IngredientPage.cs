using UnityEngine;

public class UI_IngredientPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private GameObject ingredients;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        ingredients.SetActive(false);
    }

    public void Show()
    {
        ingredients.SetActive(true);
    }
}
