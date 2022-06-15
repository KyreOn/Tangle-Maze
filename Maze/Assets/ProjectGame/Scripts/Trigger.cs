using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private GameObject levelEndPanel;

    [SerializeField] private GameObject PauseManager;
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private GameObject player;
    private PlayerLook playerLook;

    private void Start()
    {
        playerLook = player.GetComponent<PlayerLook>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PauseManager.GetComponent<Pause>().isPaused = true;
            PauseManager.GetComponent<Pause>().pausePanel.GetComponent<CanvasGroup>().alpha = 0;
            levelEndPanel.SetActive(true);
            playerLook.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }
}
