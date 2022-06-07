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
        if (isActivated)
            transform.rotation = Quaternion.Slerp(transform.rotation, activatedAngle, 2*Time.deltaTime);
        if (!isActivated)
            transform.rotation = Quaternion.Slerp(transform.rotation, deactivatedAngle, 2*Time.deltaTime);
    }
}
