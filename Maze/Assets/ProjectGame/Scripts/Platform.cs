using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : ActivatableObject
{
    [SerializeField] public Vector3 deactivatedPos;
    [SerializeField] public Vector3 activatedPos;
    [SerializeField] public float speed;
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
        transform.position = isActivated ? Vector3.Lerp(transform.position, activatedPos, Time.deltaTime*0.5f*speed*transform.position.y/activatedPos.y) : Vector3.Lerp(transform.position, deactivatedPos, Time.deltaTime*0.5f*speed*transform.position.y/deactivatedPos.y);
    }
}
