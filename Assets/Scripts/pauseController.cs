using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pauseController : MonoBehaviour
{
    public Button PauseButton;
    public GameObject pauseMenu;
    public float temp = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PauseButton.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseButtonTrigger()
    {
        temp = Time.timeScale;
        Time.timeScale = 0;
        pauseMenu.gameObject.SetActive(true);


    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.gameObject.SetActive(false);
    }

    public void Restart()
    {
        //GetComponent<StartScreen>().Play();
         SceneManager.LoadScene("GameStart");
        

    }

    public void backtoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
