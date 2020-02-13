using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour {

    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private GameObject splash;

    public AudioClip MusicClip;
    public AudioSource MusicSource;

    private void Start()
    {
        MusicSource.clip = MusicClip;
    }

    public void Die ()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MusicSource.Play();
        Debug.Log("Game over");
        Destroy(gameObject);
        
        Instantiate(splash, transform.position, Quaternion.identity);

        
        gameOverUI.SetActive(true);
        //Time.timeScale = 0;
         
       
        
    }
}
