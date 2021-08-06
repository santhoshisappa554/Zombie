using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Helicopter : MonoBehaviour
{
    public AudioClip calledhelicopterSound;
    private AudioSource audioSource;
    private bool isCalledHelicopter = false;
    public Transform HelicopterPos;
    public Transform LandingPos;
    public float distanceToreachHelicopter;
    Transform[] landingpoints;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        landingpoints = LandingPos.GetComponentsInChildren<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Helicopter")&& !isCalledHelicopter)
        {
            isCalledHelicopter = true;
            Debug.Log("Helicopter Called");
            audioSource.clip = calledhelicopterSound;
            audioSource.Play();
            landing();
            print("Helicopter arrived");
            audioSource.Stop();
           
        }
        if (isCalledHelicopter)
        {
            distanceToreachHelicopter = Vector3.Distance(FirstPersonController.player.transform.position, HelicopterPosition.pos.transform.position);
            print("Distance to reach: " + Mathf.RoundToInt(distanceToreachHelicopter));
        }
    }
    public void landing()
    {
        int l = Random.Range(1, landingpoints.Length);
        transform.position = landingpoints[l].transform.position + new Vector3(0, 3.0f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("GameOver");
        }
    }
}
