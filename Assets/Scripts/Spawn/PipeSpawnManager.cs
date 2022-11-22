using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnManager : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            SpawnPipe(i);
        }
    }
    public void SpawnPipe(int number)
    {
        float pos_x = (number + 1) * 2;
        float pos_y_bottom = -0.3f;
        float pos_y_top = 0.3f;
        float error = Random.Range(-0.6f, 0.6f);
        pos_y_bottom += error;
        pos_y_top += error;
        GameObject pipe_bottom = Instantiate(Resources.Load("PipeBottom")) as GameObject;
        GameObject pipe_top = Instantiate(Resources.Load("PipeTop")) as GameObject;
        pipe_bottom.transform.position = new Vector3(pos_x, pos_y_bottom, 0);
        pipe_top.transform.position = new Vector3(pos_x, pos_y_top, 0);
    }
}
