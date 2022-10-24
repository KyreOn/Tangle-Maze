using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Interactable : MoveableObjects
{
    [SerializeField] public int id;
    [SerializeField] public UnityEvent onInteracted;
    public bool isInteractable;
    public abstract void OnInteract();
}
