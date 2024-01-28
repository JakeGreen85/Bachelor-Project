using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JabProjectile : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject particle;
    public bool leftHit;
    public bool rightHit;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameObject.transform.forward * Time.deltaTime * speed, Space.World);
        if (tag == "DuckProjectile"){
            if (transform.position.z < 0){
                scoreManager.streak++;
                scoreManager.score += scoreManager.streak * scoreManager.combo;
                Destroy(gameObject);
            }
        }
        else{
            if (transform.position.z < 0){
                Missed();
            }
            if(leftHit && rightHit){
                explode();
                scoreManager.streak++;
                scoreManager.score += scoreManager.streak * scoreManager.combo;
                Destroy(gameObject);
            }
        }
    }

    public void explode(){
        Instantiate(particle, transform.position, transform.rotation);
    }

    public void Missed(){
        scoreManager.streak = 0;
        Destroy(gameObject);
    }

}
