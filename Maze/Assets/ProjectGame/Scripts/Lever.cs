using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] private Quaternion deactivatedAngle;
    [SerializeField] private Quaternion activatedAngle;
    public override void OnInteract()
    {
        isActivated = !isActivated;
        Debug.Log(objectToInteract.isActivated);
        if (objectToInteract.isActivated == false)
            objectToInteract.Activate();
        else
            objectToInteract.Deactivate();
    }

    public void Update()
    {
        transform.rotation = 
            Quaternion.Slerp(transform.rotation, isActivated ? activatedAngle : deactivatedAngle, 2*Time.deltaTime);
    }
}
