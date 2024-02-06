using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongProgress : MonoBehaviour
{
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>().maxValue = source.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = source.time;
    }
}
