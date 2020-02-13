using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour {

    public string levelToLoad;
    [SerializeField]

    public void Choose()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1;

    }
}
