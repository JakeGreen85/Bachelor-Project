using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Meta;
using Oculus.Interaction.Input;

public class GloveScript : MonoBehaviour
{
    public bool rightGlove;
    public SphereCollider handtracking;
    public SphereCollider controller;
    public ScoreManager scoreManager;
    public ProjectileSpawner projectileSpawner;
    private void Update() {
        print(OVRInput.GetActiveController());
        if(OVRInput.GetActiveController() == OVRInput.Controller.None && !handtracking.enabled){
            handtracking.enabled = true;
            controller.enabled = false;
        }
        else if(OVRInput.GetActiveController() == OVRInput.Controller.Touch && !controller.enabled){
            handtracking.enabled = false;
            controller.enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(rightGlove && other.tag == "Rprojectile"){
            other.GetComponent<JabProjectile>().explode();
            Destroy(other.gameObject);
            scoreManager.streak++;
            scoreManager.score += Mathf.FloorToInt(scoreManager.streak * GetComponent<VelocityCalculator>().velocity);
        }
        else if(!rightGlove && other.tag == "Lprojectile"){
            other.GetComponent<JabProjectile>().explode();
            Destroy(other.gameObject);
            scoreManager.streak++;
            scoreManager.score += Mathf.FloorToInt(scoreManager.streak * GetComponent<VelocityCalculator>().velocity);
        }
        else if(other.tag == "Mprojectile"){
            if(rightGlove){
                other.GetComponent<JabProjectile>().rightHit = true;
            }
            if(!rightGlove){
                other.GetComponent<JabProjectile>().leftHit = true;
            }
        }
        if(other.tag == "playbutton"){
            projectileSpawner.StartPlaying();
        }
        else if (other.tag == "stopbutton"){
            projectileSpawner.StopPlaying();
        }
        if(other.tag == "Glove Selector")
        {
            other.GetComponent<GloveCycle>().ChangeGlove();
        }
    }
}
