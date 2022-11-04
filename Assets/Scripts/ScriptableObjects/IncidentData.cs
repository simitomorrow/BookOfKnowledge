using UnityEngine;

[CreateAssetMenu(fileName = "Incident", menuName = "Data/Incident", order = 0)]

public class IncidentData : ScriptableObject
{
    public bool questTriggered;
    public bool questFinished;
    public string title;
    [TextArea(3,10)]
    public string description;
    public Sprite thumbnail;
    public Sprite caseImage;
}
