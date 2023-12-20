using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JabProjectile : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameObject.transform.forward * Time.deltaTime * speed, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "gloves"){
            Destroy(gameObject);
        }
    }
}
