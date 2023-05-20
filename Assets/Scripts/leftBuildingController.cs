using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftBuildingController : MonoBehaviour
{
    public GameObject[] leftBuilding;
    private Vector2 spawn;
    private double spawnZ = 1.139912;
    private float tileLength = 15.0f;
    private int TOS = 800;

    double x = -2.535533;
    double y = 2.9125;
    // Start is called before the first frame update
    void Start()
    {


        Instantiate(leftBuilding[0], new Vector3((float)x, (float)y, (float)spawnZ), Quaternion.identity);
        // for (int i = 0; i < TOS; i++)
        //    showBuilding();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void showBuilding(int idx = 1)
    //{
    //
    //    //  
    //
    //    // GameObject go;
    //    // go = Instantiate(leftBuilding[0], new Vector3((float)x, (float)y , (float)spawnZ), Quaternion.identity);
    //    // go = Instantiate(leftBuilding[0]) as GameObject;
    //    // go.transform.SetParent(transform);
    //    // 
    //    // go.transform.position = Vector3.forward * (float)spawnZ;
    //    // spawnZ += tileLength;
    //    //
    //    GameObject go;
    //    Vector3 newPosition = new Vector3((float)x, (float)y, (float)spawnZ);
    //    transform.position = Vector3.forward * (float)spawnZ;
    //
    //    spawnZ += tileLength;
    //
    //    //go = 
    //}
}   
