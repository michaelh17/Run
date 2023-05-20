using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightBuildingController : MonoBehaviour
{
    public GameObject[] leftBuilding;
    private double spawnZ = -65;
    private int TOS = 20;
    private double x = -14.9;
    private double y = -5.182549;

    // Start is called before the first frame update
    void Start()
    {
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
        transform.position = Vector3.forward * (float)spawnZ;

        spawnZ = spawnZ + 61.5;
        Instantiate(leftBuilding[0], new Vector3((float)x, (float)y, (float)spawnZ), Quaternion.identity);
    }
}
