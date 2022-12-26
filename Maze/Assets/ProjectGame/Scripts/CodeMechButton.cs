using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CodeMechButton : Interactable
{
    [SerializeField] public Vector3 deactivatedPos;
    [SerializeField] public Vector3 activatedPos;

    public override void OnInteract(int _)
    {
        isActivated = !isActivated;
        isInteractable = false;
    }

    public void ResetPos()
    {
        isActivated = !isActivated;
        isInteractable = true;
    }

    private void FixedUpdate()
    {
        Move(deactivatedPos, activatedPos);
    }
}
