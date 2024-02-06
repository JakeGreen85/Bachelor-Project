using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrainerScript : MonoBehaviour
{
    [SerializeField] List<AudioClip> usedVoiceLines;
    [SerializeField] AudioClip[] voicelines;
    [SerializeField] AudioClip FirstLine;
    [SerializeField] AudioClip LastLine;
    [SerializeField] AudioSource source;
    [SerializeField] ProjectileSpawner projectileSpawner;
    float lastLine;
    float spread = 10f;
    // Start is called before the first frame update
    void Start()
    {
        source.clip = FirstLine;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(usedVoiceLines.Count == voicelines.Length)
        {
            usedVoiceLines.Clear();
        }
        if (projectileSpawner.GetComponent<AudioSource>().isPlaying)
        {
            if(projectileSpawner.GetComponent<AudioSource>().time > lastLine + spread)
            {
                lastLine = projectileSpawner.GetComponent<AudioSource>().time;
                PlayVoiceLine();
                print("hello");
            }
        }
        if(projectileSpawner.source.time >= projectileSpawner.source.clip.length - 1){
            source.clip = LastLine;
            source.Play();
        }

    }

    public void PlayVoiceLine()
    {
        source.clip = voicelines[Random.Range(0, voicelines.Length)];
        foreach(AudioClip voiceLine in usedVoiceLines)
        {
            if (source.clip == voiceLine)
            {
                PlayVoiceLine();
                return;
            }
        }
        usedVoiceLines.Add(source.clip);
        source.Play();
        return;
    }
}
