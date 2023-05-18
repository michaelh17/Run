using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    private float score = 0.0f;
    public Text scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        score += 1000 * Time.deltaTime;
        scoreboard.text = ((int)score).ToString();
    }
}
