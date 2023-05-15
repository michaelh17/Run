using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileController : MonoBehaviour
{
    public GameObject[] tile;
    private Transform PTrans;
    private float spawnZ = 0.0f;
    private float length = 2.0f;
    private int TOS = 15;

    // Start is called before the first frame update
    private void Start()
    {
        PTrans = GameObject.FindGameObjectWithTag("Player").transform;
        
        for (int i = 0; i < TOS; i++)
        {
            Spawn();
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (PTrans.position.z > (spawnZ - TOS * length))
        {
            Spawn();
        }
        
    }


    private void Spawn(int idx = -1)
    {
        GameObject game;
        game = Instantiate(tile[0] as GameObject);
        game.transform.SetParent(transform);
        game.transform.position = Vector3.forward * spawnZ;
        spawnZ += length;
    }
}
