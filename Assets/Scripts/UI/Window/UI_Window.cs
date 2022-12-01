using UnityEngine;

[RequireComponent(typeof(GameEventListener))]
public abstract class UI_Window: MonoBehaviour
{
    public abstract void CheckWindowOpen();
}
