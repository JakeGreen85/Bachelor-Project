using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompetenceFeedback : MonoBehaviour
{
    [SerializeField] AudioClip missionComplete;
    [SerializeField] public AudioClip score100;
    [SerializeField] public AudioClip score1000;
    [SerializeField] public AudioClip score5000;
    [SerializeField] public AudioClip score10000;
    [SerializeField] public AudioClip score25000;
    [SerializeField] public AudioClip score50000;
    [SerializeField] public AudioClip score100000;
    [SerializeField] AudioSource source;

    public void playMissionComplete()
    {
        source.clip = score100;
        source.Play();
    }

    public void playScore(int score)
    {
        switch (score)
        {
            case >100000:
                source.clip = score100000;
                break;
            case >50000:
                source.clip = score50000;
                break;
            case >25000:
                source.clip = score25000;
                break;
            case >10000:
                source.clip = score10000;
                break;
            case >5000:
                source.clip = score5000;
                break;
            case >1000:
                source.clip = score1000;
                break;
            case >100:
                source.clip = score100;
                break;
            default:
                break;
        }
        source.Play();
    }
}
