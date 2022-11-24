using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMove : MonoBehaviour
{
    bool isMoving = false;

    void Update()
    {
        //bad code may need TimeTravel.cs
        Time.timeScale = 1;

        StartCoroutine(MoveHand());
    }

    IEnumerator MoveHand()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;
        for (int i = 0; i < 10; i++)
        {
            transform.position = new Vector3(transform.position.x + 0.0025f, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.05f);
        }
        for (int i = 0; i < 10; i++)
        {
            transform.position = new Vector3(transform.position.x - 0.0025f, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.05f);
        }
        isMoving = false;
    }
}
