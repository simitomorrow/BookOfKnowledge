using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera mainC;

    void Start()
    {
        mainC = Camera.main;    
    }

    void Update()
    {
        //TODO is in viewrange???
        transform.rotation = Quaternion.Euler(0f, mainC.transform.eulerAngles.y, 0f);
    }
}
