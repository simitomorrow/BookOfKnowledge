using UnityEngine;

[CreateAssetMenu(fileName = "Incident", menuName = "Data/Incident", order = 0)]

public class IncidentData : ScriptableObject
{
    public bool questTriggered;
    public string title;
    [Multiline]
    public string description;
    public Sprite thumbnail;
    public Sprite caseImage;
}
