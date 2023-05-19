using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndgameScreen : MonoBehaviour
{

    public Text scoreText;
    public Image EndGame;
    private bool isShowed = false;
    private float transition = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShowed)
            return;

        transition += Time.deltaTime;
        EndGame.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);
    }

    public void TriggerEndMenu(float score)
    {
        gameObject.SetActive(true);
        scoreText.text = ((int)score).ToString();
        isShowed = true;
    }


    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void backMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



}
