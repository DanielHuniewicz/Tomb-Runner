﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeatGame : MonoBehaviour {

    public string levelToLoad;

    public void NextLvl()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1;
    }
}
