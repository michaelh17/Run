using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pauseController : MonoBehaviour
{
    public Button PauseButton;
    public GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
        PauseButton.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseButtonTrigger()
    {
        pauseMenu.gameObject.SetActive(true);
    }

    public void Resume()
    {
        Debug.Log("RESUME");
    }

    public void Restart()
    {
        Debug.Log("Restart");
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
