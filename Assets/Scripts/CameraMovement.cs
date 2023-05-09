using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Transform move;
    private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
       move = GameObject.FindGameObjectWithTag ("Player").transform;
        start = transform.position - move.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = move.position + start;
    }
}
