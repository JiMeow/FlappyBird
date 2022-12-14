using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpawnManager : MonoBehaviour
{
    void Start()
    {
        string[] bg = { "Background1", "Background2", "Background3", "Background4" };
        int nowBgIndex = -1;
        for (int i = 0; i <= 85; i++)
        {
            if (i % 4 == 0)
            {
                nowBgIndex++;
                nowBgIndex %= 4;
            }
            GameObject bgObj = Instantiate(Resources.Load(bg[nowBgIndex])) as GameObject;
            bgObj.transform.position = new Vector3(2.5f * i + 0.5f, 0, 1);
        }
    }
}
