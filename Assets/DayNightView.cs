using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightView : MonoBehaviour
{
    [Tooltip("Number of minutes per second that pass")]
    public float minutesPersceond;
    public Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float anglePerFrame = Time.deltaTime / 360 * minutesPersceond;
        transform.RotateAround(transform.position, Vector3.forward, anglePerFrame);
    }
}
