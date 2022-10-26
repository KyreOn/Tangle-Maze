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

    public void Update()
    {
        progressBar.transform.localScale = new Vector3(1 - curTime / time, 1, 1);
        if (isActivated)
        {
            if (curTime <= time)
            {
                Debug.Log(curTime);
                curTime += Time.deltaTime;
            }
            else
            {
                isActivated = false;
                //objectToInteract.Deactivate();
            }
        }
        
        transform.rotation = 
            Quaternion.Slerp(transform.rotation, isActivated ? activatedAngle : deactivatedAngle, 2*Time.deltaTime);
    }
}
