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
    public float steps;

    private void Start() 
    {
        lastSpawn = clip.time;
        spawnTime = 60f/(BPM*steps);
    }

    // Update is called once per frame
    void Update()
    {
        if(!playing){
            return;
        }
        print(clip.clip.frequency);
        print(clip.timeSamples);
        if(Mathf.FloorToInt(clip.timeSamples) - (clip.clip.frequency * spawnTime) > lastSpawn){
            // Instantiate all at the beginning and just enable and move the desired projectile (instead of instantiating every time)
            lastSpawn = Mathf.FloorToInt(clip.timeSamples);
            int num = rnd.Next(projectiles.Length);
            if(num == 0){
                Instantiate(projectiles[0], new Vector3(transform.position.x + 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation); ;
            }
            else if(num == 1){
                Instantiate(projectiles[1], new Vector3(transform.position.x - 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation);
            }
            else if(num == 2){
                Instantiate(projectiles[2], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            }
            else if(num == 3){
                Instantiate(projectiles[3], new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z), transform.rotation);
            }
            else if(num == 4){
                Instantiate(projectiles[4], new Vector3(transform.position.x + 0.15f, transform.position.y + 0.1f, transform.position.z), projectiles[4].transform.rotation);
            }
            else if(num == 5){
                Instantiate(projectiles[5], new Vector3(transform.position.x - 0.15f, transform.position.y + 0.1f, transform.position.z), projectiles[5].transform.rotation);
            }
            else if(num == 6){
                Instantiate(projectiles[6], new Vector3(transform.position.x - 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation);
            }
            else if(num == 7){
                Instantiate(projectiles[7], new Vector3(transform.position.x + 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation);
            }
            else if(num == 8){
                Instantiate(projectiles[8], new Vector3(transform.position.x + 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation);
            }
            else if(num == 9){
                Instantiate(projectiles[9], new Vector3(transform.position.x - 0.15f, transform.position.y - 0.1f, transform.position.z), transform.rotation);
            }
        }
    }

    public void StartPlaying(){
        playing = true;
        clip.Play();
    }

    public void StopPlaying(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playing = false;
    }
}
