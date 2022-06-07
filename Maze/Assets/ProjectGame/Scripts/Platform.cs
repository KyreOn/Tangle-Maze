using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : ActivatableObject
{
    [SerializeField] public Vector3 deactivatedPos;
    [SerializeField] public Vector3 activatedPos;
    public override void Activate()
    {
        isActivated = true;

    }

    public override void Deactivate()
    {
        isActivated = false;
    }

    public void Update()
    {
        if (isActivated) 
            transform.position = Vector3.Lerp(transform.position, activatedPos, 
                Time.deltaTime*0.5f*transform.position.y/activatedPos.y);
        if (!isActivated) 
            transform.position = Vector3.Lerp(transform.position, deactivatedPos, 
                Time.deltaTime*0.5f*transform.position.y/deactivatedPos.y);
    }
}
