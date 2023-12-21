using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject[] projectiles;
    public float BPM;
    public float spawnTime;
    public float lastSpawn;
    public float offset;
    System.Random rnd = new System.Random();
    public AudioSource clip;
    public bool playing;

    private void Start() 
    {
        lastSpawn = Time.time;
        spawnTime = 60f/(BPM/2);
    }

    // Update is called once per frame
    void Update()
    {
        if(!playing){
            return;
        }
        if(Time.time - lastSpawn > spawnTime){
            lastSpawn = Time.time;
            int num = rnd.Next(projectiles.Length);
            if(num == 0){
                Instantiate(projectiles[0], new Vector3(transform.position.x + 0.15f, transform.position.y, transform.position.z), transform.rotation);
            }
            else if(num == 1){
                Instantiate(projectiles[1], new Vector3(transform.position.x - 0.15f, transform.position.y, transform.position.z), transform.rotation);
            }
            else if(num == 2){
                Instantiate(projectiles[2], new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z), transform.rotation);
            }
        }
    }

    public void StartPlaying(){
        playing = true;
        clip.Play();
    }

    public void StopPlaying(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
