using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameEvent))]
public class EventsTriggerButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameEvent gevent = (GameEvent)target;
        if (GUILayout.Button("Send Event"))
        {
            gevent.Raise();
        }
    }
}
