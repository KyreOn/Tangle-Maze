using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SampleActive : ActiveItem
{
    public override void Action()
    {
        Debug.Log("you're using item in first slot");
    }
}