using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Incidents : MonoBehaviour
{
    public List<IncidentData> incidents;
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
        foreach (IncidentData incident in incidents)
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
        if (selectedIncident.value > incidents.Count)
        {
            selectedIncident.value = 0;
            Debug.LogError("Incident selection went wrong");
        }
        int index = selectedIncident.value;
        buttons[index].Select();
        description.text = incidents[index].description;
        title.text = incidents[index].title;
        mainImage.sprite = incidents[index].caseImage;
    }
}
