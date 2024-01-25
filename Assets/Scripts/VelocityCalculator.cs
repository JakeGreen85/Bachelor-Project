using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityCalculator : MonoBehaviour
{
    float interval = 0.05f;
    public float velocity;
    float lastTime;
    Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > interval + lastTime)
        {
            lastTime = Time.time;

            // Calculate velocity in m/s
            velocity = Vector3.Distance(lastPosition, transform.position) / interval;

            lastPosition = transform.position;
        }
    }
}
