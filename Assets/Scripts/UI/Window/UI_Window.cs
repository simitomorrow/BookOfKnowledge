using UnityEngine;

[RequireComponent(typeof(GameEventListener))]
public abstract class UI_Window: MonoBehaviour
{
    public abstract void ToggleWindowVisible();
    public void ToggleMouseCursorVisible()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
