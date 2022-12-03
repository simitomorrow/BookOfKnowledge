using UnityEngine;

public class UI_ElixirPage : MonoBehaviour, BookPage 
{
    [SerializeField] private PageKeyword keyword;
    [SerializeField] private GameObject elixirs;

    public PageKeyword GetKeyword()
    {
        return keyword;
    }

    public void Hide()
    {
        elixirs.SetActive(false);
    }

    public void Show()
    {
        elixirs.SetActive(true);
    }
}
