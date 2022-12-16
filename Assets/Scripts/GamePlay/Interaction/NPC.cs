using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class NPC : MonoBehaviour, Interactable
{
    public IncidentData quest;
    public IncidentList allQuest;
    public PageKeyword incidentUIPage;
    public ActivePage currentUIPage;
    public IntVariable selectedQuestIDInUI;
    public BoolVariable isBookOpen;
    public GameEvent openIncidentsEvent;

    public void Interact()
    {
        if (quest.questTriggered == true && quest.questFinished == false)
        {
            Debug.Log("Required hand in quest item check :I");
        }
        if (quest.questFinished == false)
        {
            quest.questTriggered = true;
            selectedQuestIDInUI.value = GetQuestID();
            isBookOpen.value = true;
            currentUIPage.keyword = incidentUIPage;
            openIncidentsEvent.Raise();
        }
    }

    private int GetQuestID()
    {
        return allQuest.list.IndexOf(quest);
    }
}
