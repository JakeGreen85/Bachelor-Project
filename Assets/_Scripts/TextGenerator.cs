using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextGenerator : MonoBehaviour
{
    [SerializeField] string[] text;
    float spawnTime;
    float duration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time;
        this.GetComponent<TextMeshPro>().text = text[Random.Range(0, text.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime + duration)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
