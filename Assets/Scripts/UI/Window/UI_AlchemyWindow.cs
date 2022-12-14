using UnityEngine;

public class UI_AlchemyWindow : UI_Window
{
    [SerializeField] private BoolVariable isAlchemyVisible;
    [SerializeField] private CanvasGroup alchemyUI;

    public override void ToggleWindowVisible()
    {
        if (isAlchemyVisible.value)
        {
            alchemyUI.alpha = 100f;
            alchemyUI.blocksRaycasts = true;
            alchemyUI.interactable = true;
            ToggleMouseCursorVisible();
        } 
        else
        {
            alchemyUI.alpha = 0f;
            alchemyUI.blocksRaycasts = false;
            alchemyUI.interactable = false;
        }
    }
}
