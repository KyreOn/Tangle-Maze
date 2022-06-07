using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActivatableObject : MonoBehaviour
{
    public bool isActivated;
    public abstract void Activate();
    public abstract void Deactivate();
}
