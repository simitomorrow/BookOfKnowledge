using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Incidents : MonoBehaviour
{
    public List<IncidentData> incidents;

    public void openIncident(IncidentData incident)
    {
        Debug.Log(incident);
    }
}
