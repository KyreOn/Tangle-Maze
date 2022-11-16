using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Interactable : MoveableObjects
{
    [SerializeField] public int id;
    [SerializeField] public UnityEvent<int> onInteracted;
    [SerializeField] public bool isInteractable = true;
    public abstract void OnInteract(int id);

    private void Awake()
    {
        onInteracted.AddListener(OnInteract);
    }
}
