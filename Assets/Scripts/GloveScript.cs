using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "projectile"){
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "projectile"){
            Destroy(other.gameObject);
        }
    }
}
