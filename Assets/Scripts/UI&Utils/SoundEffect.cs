using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    private static SoundEffect soundEffectInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (soundEffectInstance == null)
        {
            soundEffectInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
