using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    private float score = 0.0f;
    private bool isDead = false;
    public Text scoreboard;
    public EndgameScreen screen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead)
            return;
        
        score += 1000 * Time.deltaTime;
        scoreboard.text = ((int)score).ToString();
    }

    public void OnDeath()
    {
        isDead = true;
        screen.TriggerEndMenu(score);
    }

    

}
