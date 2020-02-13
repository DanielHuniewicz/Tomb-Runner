using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public string levelToLoad;
    [SerializeField]
    private GameObject settings;
    [SerializeField]
    private GameObject areYouSure;
    [SerializeField]
    private GameObject selectLevel;

    public void Settings()
    {
        settings.SetActive(true);
    }
    public void QuitSettings()
    {
        settings.SetActive(false);
    }
    public void selectLevelPanel()
    {
        selectLevel.SetActive(true);
    }
    public void selectLevelPanelQuit()
    {
        selectLevel.SetActive(false);
    }

    public void Exit()
    {
        areYouSure.SetActive(true);
    }
    public void NotExit()
    {
        areYouSure.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("zamykanie aplikacji");
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1;

    }

  
}
