using UnityEngine;
using UnityEngine.UI;

public class BookMark : MonoBehaviour
{
    public PageKeyword keyword;
    public ActivePage currentPage;
    public GameEvent openPageEvent;

    public Image activeBookMark;

    public void OpenPage()
    {
        currentPage.keyword = keyword;
        openPageEvent.Raise();
    }

    public void ShowActiveBookMark()
    {
        activeBookMark.enabled = false;
        if (keyword == currentPage.keyword)
        {
            activeBookMark.enabled = true;
        }
    }
}
