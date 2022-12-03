using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Incidents : MonoBehaviour
{
    public IncidentList incidents;
    public IntVariable selectedIncident;
    public Button buttonPrefab;
    public GameObject buttonParent;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public Image mainImage;

    private List<Button> buttons = new List<Button>();

    private void Start()
    {
        CultivateButtons();
        SelectIncident();
    }

    private void CultivateButtons()
    {
        int id = 0;
        foreach (IncidentData incident in incidents.list)
        {
            Button button = Instantiate(buttonPrefab, buttonParent.transform);
            UI_IncidentButton thumbnailButton = button.GetComponentInChildren<UI_IncidentButton>();
            thumbnailButton.Initialize(incident.thumbnail, incident.title, id);
            buttons.Add(button);
            id++;
        }
    }

    public void SelectIncident()
    {
        if (selectedIncident.value >= incidents.list.Count || selectedIncident.value < 0)
        {
            Debug.LogError("Incident selection out of range. Incident count: " + incidents.list.Count + "  - selected incident number: " + (selectedIncident.value+1));
            selectedIncident.value = 0;
        } 
        int index = selectedIncident.value;
        buttons[index].Select();
        description.text = incidents.list[index].description;
        title.text = incidents.list[index].title;
        mainImage.sprite = incidents.list[index].caseImage;
    }
}
