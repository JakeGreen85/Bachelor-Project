using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopbuttonscript : MonoBehaviour
{
    public ProjectileSpawner projectileSpawner;
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "gloves"){
            projectileSpawner.StopPlaying();
        }
    }
}
