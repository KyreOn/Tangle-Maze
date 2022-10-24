using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    [SerializeField] private GameObject interactCursor;
    public float distance = 20f;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        var ray = mainCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out var hit, distance))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                interactCursor.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    var interactable = hit.collider.GetComponent<Interactable>();
                    interactable.onInteracted.Invoke();
                }
            }
        }
        else
            interactCursor.SetActive(false);
    }
}
