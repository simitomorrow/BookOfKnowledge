using UnityEngine;

public class UI_ElixirPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private CanvasGroup elixirs;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        elixirs.alpha = 0f;
        elixirs.blocksRaycasts = false;
        elixirs.interactable = false;
    }

    public void Show()
    {
        elixirs.alpha = 100f;
        elixirs.blocksRaycasts = true;
        elixirs.interactable = true;
    }
}
