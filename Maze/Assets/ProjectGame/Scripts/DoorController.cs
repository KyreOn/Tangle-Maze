using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorController : Interactable
{
    public TMP_Text attention;
    private float timeToHide;
    [SerializeField] private AudioSource doorOpenAudioSource;

    public override void OnInteract()
    {
        if (objectToInteract.isInteractable)
            if (objectToInteract.isActivated == false)
                objectToInteract.Activate();
            else
                objectToInteract.Deactivate();
    }
}
