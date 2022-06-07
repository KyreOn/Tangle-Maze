using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private Sprite chosenSlotSprite;
    [SerializeField] private Sprite notChosenSlotSprite;
    [SerializeField] private List<Image> icons = new List<Image>();
    [SerializeField] private List<Image> invCells = new List<Image>();
    private float timeToHide;
    public void UpdateUI(Inventory inventory)
    {
        var canvasGroup = gameObject.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        timeToHide = 0;
        Debug.Log(inventory.chosenItemSlot);
        for (var i = 0; i < 6; i++)
        {
            invCells[i].sprite = inventory.chosenItemSlot == i ? chosenSlotSprite : notChosenSlotSprite;
            if (inventory.GetItem(i) == null)
            {
                icons[i].sprite = null;
                icons[i].color = new Color(icons[i].color.r, icons[i].color.g, icons[i].color.b, 0);
            }
            else
            {
                icons[i].sprite = inventory.GetItem(i).icon;
                icons[i].color = new Color(icons[i].color.r, icons[i].color.g, icons[i].color.b, 255);
            }
        }
    }

    public void Update()
    {
        var canvasGroup = gameObject.GetComponent<CanvasGroup>();
        if (canvasGroup.alpha > 0)
        {
            timeToHide += Time.deltaTime;
            if (timeToHide >= 3)
                canvasGroup.alpha -= Time.deltaTime;
        }
        else
        {
            timeToHide = 0;
        }
    }
}
