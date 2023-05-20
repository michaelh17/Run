using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftBuildingController : MonoBehaviour
{
    public GameObject[] leftBuilding;
    private double spawnZ = -65;
    private int TOS = 20;
    private double x = -2.535533;
    private double y = 2.9125;
    private List<GameObject> active = new List<GameObject> ();


    // Start is called before the first frame update
    void Start()
    {
        active = new List<GameObject> ();
         for (int i = 0; i < TOS; i++)
        {
            showBuilding();
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void showBuilding(int idx = 1)
    {
        GameObject go;
        transform.position = Vector3.forward * (float)spawnZ;
    
        spawnZ = spawnZ + 61.5;
        
        go = Instantiate(leftBuilding[0], new Vector3((float)x, (float)y, (float)spawnZ), Quaternion.identity);
    }

 
}   
