using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActivatableObject : MonoBehaviour
{
    public int id;
    public bool isActivated;
    public bool isInteractable;
    public abstract void Activate();
    public abstract void Deactivate();
}
