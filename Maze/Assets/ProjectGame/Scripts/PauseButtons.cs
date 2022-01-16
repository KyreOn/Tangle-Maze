using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour
{
	[SerializeField] public GameObject PauseManager;
    public void ResumeGame(GameObject obj)
    {
        obj.GetComponent<Pause>().isPaused = false;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
    
    public void OpenNextLevel()
    {
		if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 1)
		{
			PauseManager.GetComponent<Pause>().isPaused = false;
			SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);	
		}
		else
			ExitGame();
    }
}
