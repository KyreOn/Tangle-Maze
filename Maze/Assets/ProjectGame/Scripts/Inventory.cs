using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class InventoryCell
{
    public Item item;
}

public class Inventory : MonoBehaviour
{
    [SerializeField] public List<Item> items = new List<Item>();
    [SerializeField] private int maxSize = 6;
    [SerializeField] public UnityEvent OnInventoryChanged;
    public int chosenItemSlot;
    public bool AddItem(Item item)
    {
        if (items.Count >= maxSize) return false;
        items.Add(item);
        OnInventoryChanged.Invoke();
        return true;
    }

    public bool RemoveItem(int id)
    {
        for (var i = 0; i < GetSize(); i++)
        {
            if (items[i].id == id)
            {
                items[i] = null;
                RearrangeInventory();
                OnInventoryChanged.Invoke();
                return true;
            }
        }
        return false;
    }

    public Item GetItem(int i)
    {
        return i < items.Count ? items[i] : null;
    }

    private int GetSize()
    {
        return items.Count;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            chosenItemSlot = 0;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            chosenItemSlot = 1;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            chosenItemSlot = 2;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            chosenItemSlot = 3;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            chosenItemSlot = 4;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            chosenItemSlot = 5;
            OnInventoryChanged.Invoke();
        }

        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            chosenItemSlot = chosenItemSlot != 5 ? chosenItemSlot + 1 : chosenItemSlot;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
        {
            chosenItemSlot = chosenItemSlot != 0 ? chosenItemSlot - 1 : chosenItemSlot;
            OnInventoryChanged.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (items[chosenItemSlot] != null)
            {
                items[chosenItemSlot].Action();
            }
        }
    }

    private void RearrangeInventory()
    {
        for (var i = 0; i < items.Count-1; i++)
        {
            if (items[i] == null && items[i + 1] != null)
            {
                items[i] = items[i + 1];
                items[i + 1] = null;
            }
        }
    }
}
