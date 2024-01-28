using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class HeadScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "DuckProjectile"){
            other.GetComponent<JabProjectile>().Missed();
        }
    }
}
