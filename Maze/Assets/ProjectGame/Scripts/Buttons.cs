using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttons : MonoBehaviour
{
	[SerializeField] private TMP_Text startButton;
	public void Start()
	{
		if (PlayerPrefs.HasKey("MaxLevel") && PlayerPrefs.GetInt("MaxLevel") != 1)
			startButton.SetText("Продолжить");
	}	
    public void StartGame()
    {
	    SceneManager.LoadScene(PlayerPrefs.HasKey("LastLevel") ? PlayerPrefs.GetInt("LastLevel") : 1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowPanel(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void HidePanel(GameObject obj)
    {
        obj.SetActive(false);
    }
}
