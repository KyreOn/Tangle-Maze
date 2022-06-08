using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] public int id;
    [SerializeField] public ActivatableObject objectToInteract;
    public bool isActivated;
    public bool isInteractable;
    public abstract void OnInteract();
}
