using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudManager : MonoBehaviour
{
    public static SoudManager instance;

    public AudioSource BirdFly;
    public AudioSource BirdScore;
    public AudioSource BirdDead;
    public AudioSource BirdBg;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBirdDead()
    {
        BirdDead.Play();
    }

    public void PlayBirdScore()
    {
        BirdScore.Play();
    }

    public void PlayBirdFly()
    {
        BirdFly.Play();
    }

    public void LowerBirdBg()
    {
        BirdBg.volume = 0.02f;
    }
}
