using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField] private Item item;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource sound;
    public float distance = 2f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!item) return;
        var inventory = other.GetComponent<Inventory>();
        if (inventory)
        {
            sound.Play();
            inventory.AddItem(item);
            Destroy(gameObject);
        }
    }
}
