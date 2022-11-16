using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLever : Interactable
{
    [SerializeField] private Quaternion deactivatedAngle;
    [SerializeField] private Quaternion activatedAngle;
    [SerializeField] private GameObject progressBar;
    [SerializeField] private float time;
    private float curTime;

    public override void OnInteract(int _)
    {
        if (!isActivated)
        {
            isActivated = true;
            progressBar.SetActive(true);
        }
        else
        {
            isActivated = false;
            progressBar.SetActive(false);
        }
        curTime = 0;
        //if (objectToInteract.isActivated == false)
        //    objectToInteract.Activate();
        //else
        //    objectToInteract.Deactivate();
    }

    public void FixedUpdate()
    {
        Rotate(deactivatedAngle.eulerAngles, activatedAngle.eulerAngles);
        progressBar.transform.localScale = new Vector3(1 - curTime / time, 1, 1);
        if (isActivated)
        {
            if (curTime <= time)
            {
                curTime += Time.deltaTime;
            }
            else
            {
                onInteracted.Invoke(id);
            }
        }
    }
}
