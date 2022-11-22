using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartBirdOnSound : MonoBehaviour
{
    void Start()
    {
        float soundScale = SoudManager.instance.soundMul;
        int index = (int)(soundScale / 0.2f);
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        for (int i = 1; i <= 10; i++)
        {
            SpriteRenderer sprite = allChildren[i].gameObject.GetComponent<SpriteRenderer>();
            if (i > index + 1)
            {
                sprite.color = new Color(1f, 1f, 1f, 100f / 255f);
            }
            else
            {
                sprite.color = new Color(1f, 1f, 1f, 255f / 255f);
            }
        }
    }
}
