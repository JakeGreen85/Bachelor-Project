using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Rendering;
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
    public GameObject playerHeadPosition;
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
    public bool manager = false;
    public int lastNum;
    public float speed = 0.5f;


    private void Start() 
    {
        playerHeadPosition = GameObject.Find("CenterEyeAnchor").gameObject;
        source = songs[song];
        projectiles = projectiles1;
        lastSpawn = source.time;
        spawnTime = 60f/(BPM*steps);
        transform.position = new Vector3(transform.position.x, playerHeadPosition.transform.position.y, transform.position.z);
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
        if(source.time >= source.clip.length - 1 && !manager)
        {
            StartCoroutine(toggleManager(5));
            manager = true;
            // PlayNext();
        }
        transform.Translate(new Vector3(transform.position.x - playerHeadPosition.transform.position.x, 0, 0) * Time.deltaTime * speed, Space.Self);
        if (Mathf.FloorToInt(source.timeSamples) - (source.clip.frequency * spawnTime) > lastSpawn){
            // Instantiate all at the beginning and just enable and move the desired projectile (instead of instantiating every time)
            lastSpawn = Mathf.FloorToInt(source.timeSamples);
            int num = Random.Range(0, projectiles.Length);
            if(lastNum >= 3){
                num = Random.Range(0, 3);
            }
            lastNum = num;
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

    IEnumerator toggleManager(int secs)
    {
        yield return new WaitForSeconds(secs);
        GameObject.Find("Game Manager").GetComponent<GameManager>().ToggleManager();
    }
}
