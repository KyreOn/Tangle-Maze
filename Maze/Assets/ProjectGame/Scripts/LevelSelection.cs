using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private int levelId;
    [SerializeField] private Button button;
    void Start()
    {
        if (PlayerPrefs.GetInt("MaxLevel") < levelId)
            button.interactable = false;
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelId);
    }
}
