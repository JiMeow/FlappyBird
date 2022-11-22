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

    public float soundMul;
    void Awake()
    {
        DontDestroyOnLoad(this);
        soundMul = 1f;
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

    public void SetBirdSound(float soundMul)
    {
        this.soundMul = soundMul;
        BirdFly.volume = 0.1f * soundMul;
        BirdScore.volume = 0.2f * soundMul;
        BirdDead.volume = 0.2f * soundMul;
        BirdBg.volume = 0.1f * soundMul;
    }
}
