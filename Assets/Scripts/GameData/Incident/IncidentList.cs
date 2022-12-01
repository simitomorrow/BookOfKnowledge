using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Incident List", menuName = "Lists/Incident List", order = 0)]
public class IncidentList : ScriptableObject
{
    public List<IncidentData> list = new List<IncidentData>();
}