using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public float distance = 20f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            if (!Physics.Raycast(ray, out var hit, distance)) return;
            if (!hit.collider.CompareTag("Interactable")) return;
            var interactable = hit.collider.GetComponent<Interactable>();
            interactable.OnInteract();
        }
    }
}
