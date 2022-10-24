using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : ActivatableObject
{
    [SerializeField] public Vector3 deactivatedPos;
    [SerializeField] public Vector3 activatedPos;

    public override void ChangeState()
    {
        isActivated = !isActivated;
    }
    
    public void FixedUpdate()
    {
        Move(deactivatedPos, activatedPos);
    }
}
