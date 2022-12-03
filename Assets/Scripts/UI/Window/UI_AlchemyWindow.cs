using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_AlchemyWindow : UI_Window
{
    [SerializeField] private BoolVariable isAlchemyVisible;
    [SerializeField] private GameObject alchemyUI;

    public override void ToggleWindowVisible()
    {
        if (isAlchemyVisible.value)
        {
            alchemyUI.SetActive(true);
            ToggleMouseCursorVisible();
        } 
        else
        {
            alchemyUI.SetActive(false);
        }
    }
}
