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
    public ScoreManager scoreManager;
    public ProjectileSpawner projectileSpawner;
    private void Start() 
    {
        scoreManager = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if(rightGlove && other.tag == "Rprojectile"){
            other.GetComponentInParent<JabProjectile>().explode();
            Destroy(other.transform.parent.gameObject);
            scoreManager.streak++;
            scoreManager.score += Mathf.FloorToInt(scoreManager.streak * GetComponent<VelocityCalculator>().velocity * scoreManager.combo);
        }
        else if(!rightGlove && other.tag == "Lprojectile"){
            other.GetComponentInParent<JabProjectile>().explode();
            Destroy(other.transform.parent.gameObject);
            scoreManager.streak++;
            scoreManager.score += Mathf.FloorToInt(scoreManager.streak * GetComponent<VelocityCalculator>().velocity * scoreManager.combo);
        }
        else if(other.tag == "Mprojectile"){
            if(rightGlove){
                other.GetComponentInParent<JabProjectile>().rightHit = true;
            }
            if(!rightGlove){
                other.GetComponentInParent<JabProjectile>().leftHit = true;
            }
        }
        if(other.tag == "playbutton"){
            projectileSpawner.StartPlaying();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "stopbutton"){
            projectileSpawner.StopPlaying();
        }
        if(other.tag == "Glove Selector")
        {
            other.GetComponent<GloveCycle>().ChangeGlove();
        }
        if (other.tag == "Projectile Selector")
        {
            other.GetComponent<ProjectileCycle>().CycleProjectiles();
        }
        if (other.tag == "GameManager")
        {
            other.GetComponent<GameManager>().ChangeVariation();
        }
    }
}