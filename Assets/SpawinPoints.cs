using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawinPoints : MonoBehaviour
{
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool respawn=false;
    public bool lastToggle = false;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lastToggle)
        {
            Respawn();
            respawn = false;
            transform.position = spawnPoints[i].transform.position;
        }
        else
        {
            lastToggle = respawn;
        }
    }
    public void Respawn()
    {
         i = Random.Range(1, spawnPoints.Length);
       
    }
}
