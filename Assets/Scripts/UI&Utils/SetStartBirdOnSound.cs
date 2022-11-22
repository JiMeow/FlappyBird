using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartBirdOnSound : MonoBehaviour
{
    Transform[] allChildren;
    void Start()
    {
        allChildren = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        float soundScale = SoudManager.instance.soundMul;
        float index = soundScale / 0.2f;
        for (int i = 1; i <= 10; i++)
        {
            SpriteRenderer sprite = allChildren[i].gameObject.GetComponent<SpriteRenderer>();
            if (i > Mathf.RoundToInt(index))
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
