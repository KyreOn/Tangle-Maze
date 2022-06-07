using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public abstract class aItem : ScriptableObject
{
    public int id;
    public Sprite icon;
    public abstract void Action();
}