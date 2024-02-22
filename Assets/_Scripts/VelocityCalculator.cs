using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class VelocityCalculator : MonoBehaviour
{
    [SerializeField] GameObject slider;
    [SerializeField] GameObject num;
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
            velocity = Mathf.Clamp((Vector3.Distance(lastPosition, transform.position) * 3) / interval, 1, 10);

            lastPosition = transform.position;
        }
    }

    public void setVelocity()
    {
        slider.GetComponent<Slider>().value = velocity;
        num.GetComponent<TextMeshProUGUI>().text = Mathf.FloorToInt(velocity).ToString();
    }
}
