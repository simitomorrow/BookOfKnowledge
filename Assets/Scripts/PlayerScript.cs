using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private BoolVariable canInteract;
    [SerializeField] private InteractablesList interactables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, collectRadius);
        //Debug.Log(hitColliders.Length);
        //Transform nearest = null;
        //float nearDist = float.PositiveInfinity;
        //for (int i = 0; i < hitColliders.Length; i++)
        //{
        //    if (hitColliders[i].gameObject.GetComponent<I_Interactable>() != null)
        //    {

        //        Vector3 offset = transform.position - hitColliders[i].transform.position;
        //        float thisDist = offset.sqrMagnitude;
        //        if (thisDist < nearDist)
        //        {
        //            nearDist = thisDist;
        //            nearest = hitColliders[i].transform;
        //        }
        //    }
        //}
        //if (nearest != null)
        //{
        //    nearest.GetComponent<I_Interactable>().Interact();
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        I_Interactable interactable = other.gameObject.GetComponent<I_Interactable>();
        if (interactable != null)
        {
            interactables.Add(interactable);
            Debug.Log(interactables.Count());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        I_Interactable interactable = other.gameObject.GetComponent<I_Interactable>();
        if (interactable != null)
        {
            interactables.Remove(interactable);
        }
    }
}
