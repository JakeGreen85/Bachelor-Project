using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject[] projectiles1;
    public GameObject[] projectiles2;
    public GameObject[] projectiles3;
    public GameObject[] projectiles4;
    public GameObject[] projectiles5;
    public GameObject[] projectiles;
    public AudioSource[] songs;
    public int song = 0;
    public float BPM;
    public float spawnTime;
    public float lastSpawn;
    public float offset;
    System.Random rnd = new System.Random();
    public AudioSource source;
    public bool playing;
    public float steps;
    public bool mute;

    private void Start() 
    {
        source = songs[song];
        projectiles = projectiles1;
        lastSpawn = source.time;
        spawnTime = 60f/(BPM*steps);
    }

    // Update is called once per frame
    void Update()
    {
        if(mute && !source.mute)
        {
            source.mute = true;
        }
        if(!source.isPlaying){
            return;
        }
        if(source.time >= source.clip.length)
        {
            PlayNext();
        }
        if(Mathf.FloorToInt(source.timeSamples) - (source.clip.frequency * spawnTime) > lastSpawn){
            // Instantiate all at the beginning and just enable and move the desired projectile (instead of instantiating every time)
            lastSpawn = Mathf.FloorToInt(source.timeSamples);
            int num = Random.Range(0, projectiles.Length);
            Instantiate(projectiles[num], transform.position, transform.rotation);
        }
    }

    public void StartPlaying(){
        playing = true;
        source.PlayScheduled(AudioSettings.dspTime + 2);
    }

    public void StopPlaying(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playing = false;
    }

    void PlayNext()
    {
        source.Pause();
        song++;
        source = songs[song];
        StartPlaying();
    }

}
