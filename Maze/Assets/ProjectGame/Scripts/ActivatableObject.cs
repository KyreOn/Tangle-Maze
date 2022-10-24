using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActivatableObject : MoveableObjects
{
    [SerializeField] public int id;
    public bool isInteractable;
    public abstract void ChangeState();
}
