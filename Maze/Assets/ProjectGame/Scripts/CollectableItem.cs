using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField] private Item item;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        var inventory = other.GetComponent<Inventory>();
        if (inventory)
        {
            sound.Play();
            if (inventory.AddItem(item))
                Destroy(gameObject);
        }
    }
}
