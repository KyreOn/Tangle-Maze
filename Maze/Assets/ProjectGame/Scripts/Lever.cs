using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] private Quaternion deactivatedAngle;
    [SerializeField] private Quaternion activatedAngle;
    public override void OnInteract(int _)
    {
        isActivated = !isActivated;
    }

    public void FixedUpdate()
    {
        Rotate(deactivatedAngle.eulerAngles, activatedAngle.eulerAngles);
        //var curRot = transform.localRotation.eulerAngles;
        //var newRot = isActivated
        //        ? new Vector3(
        //            Mathf.Clamp(curRot.x + speed * Time.deltaTime, deactivatedAngle.eulerAngles.x, activatedAngle.eulerAngles.x),
        //            Mathf.Clamp(curRot.y + speed * Time.deltaTime, deactivatedAngle.eulerAngles.y, activatedAngle.eulerAngles.y),
        //            Mathf.Clamp(curRot.z + speed * Time.deltaTime, deactivatedAngle.eulerAngles.z, activatedAngle.eulerAngles.z)
        //        )
        //        : new Vector3(
        //            Mathf.Clamp(curRot.x - speed * Time.deltaTime, deactivatedAngle.eulerAngles.x, activatedAngle.eulerAngles.x),
        //            Mathf.Clamp(curRot.y - speed * Time.deltaTime, deactivatedAngle.eulerAngles.y, activatedAngle.eulerAngles.y),
        //            Mathf.Clamp(curRot.z - speed * Time.deltaTime, deactivatedAngle.eulerAngles.z, activatedAngle.eulerAngles.z)
        //        );
        //transform.localRotation = Quaternion.Euler(newRot);
    }
}
