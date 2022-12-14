using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_IncidentButton : MonoBehaviour
{
    public Image thumbnail;
    public TextMeshProUGUI title;
    public IntVariable selectedIncident;
    public GameEvent updateUIEvent;
    private int ID;

    public void Initialize(Sprite image, string text, int id)
    {
        thumbnail.sprite = image;
        title.text = text;
        ID = id;
    }

    public void SelectIncidentInUI()
    {
        selectedIncident.value = ID;
        updateUIEvent.Raise();
    }
}
