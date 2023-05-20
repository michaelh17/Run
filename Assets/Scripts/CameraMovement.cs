using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Transform move;
    private Vector3 start;
    private Vector3 moveCam;

    private float transition = 0.0f;
    private float duration = 2.0f;
    private Vector3 offset = new Vector3(0, 5, 5);

    // Start is called before the first frame update
    void Start()
    {
       move = GameObject.FindGameObjectWithTag ("Player").transform;
       start = transform.position - move.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveCam = move.position + start;

        moveCam.x = 0;
        moveCam.y = Mathf.Clamp(moveCam.y, 3, 5);

        if(transition > 1.0f){
            transform.position = moveCam;
        }
        else{
            transform.position = Vector3.Lerp(moveCam + offset, moveCam, transition);
            transition += Time.deltaTime * 1 / duration;
            transform.LookAt(move.position + Vector3.up);
        }

        transform.position = moveCam;
    }
}
