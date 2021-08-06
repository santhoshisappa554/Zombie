using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SpawinPoints : MonoBehaviour
{
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool respawn=false;
    bool lastToggle = false;
    FirstPersonController temp;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length);
        temp = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastToggle!=respawn)
        {
            temp.enabled = false;
            Respawn();
            respawn = false;
           
        }
        else
        {
            lastToggle = respawn;
            temp.enabled = true;
        }
    }
    public void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }
}
