using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tileController : MonoBehaviour
{

    public GameObject[] tile;
    private Transform PTrans;
    private float spawnZ = 0.0f;
    private float length = 14.0f;
    private int TOS = 25;
    private int tempPref = 0;
    private float safe = 20.0f;
    private List<GameObject> activeTiles;

    // Start is called before the first frame update
    private void Start()
    {
        activeTiles = new List<GameObject>();
        PTrans = GameObject.FindGameObjectWithTag("Player").transform;
        
        for (int i = 0; i < TOS; i++)
        {
            if (i < 2)
                Spawn(0);
            else
            Spawn();
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (PTrans.position.z - safe > (spawnZ - TOS * length))
        {
            Spawn();
            RemoveTiles();
        }
        
    }


    private void Spawn(int idx = -1)
    {
        GameObject game;

        if (idx == -1)
            game = Instantiate(tile[showRandomTiles()]) as GameObject;

        else
            game = Instantiate(tile[idx]) as GameObject;



        game.transform.SetParent(transform);
        game.transform.position = Vector3.forward * spawnZ;
        spawnZ += length;
        activeTiles.Add(game);
    }

    private void RemoveTiles()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int showRandomTiles()
    {
        if (tile.Length <= 1)
            return 0;

        int randomIndex = tempPref;
        while (randomIndex == tempPref){
            randomIndex = Random.Range(0, tile.Length);
        }

        tempPref = randomIndex;
        return randomIndex;
    }
}
