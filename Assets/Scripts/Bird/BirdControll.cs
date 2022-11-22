using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControll : MonoBehaviour
{
    public float force = 0.2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        //press any key down
        if (Input.anyKeyDown)
        {
            if (force == 0f)
            {
                return;
            }
            //move up
            rb.velocity = new Vector2(0, force);
            SoudManager.instance.PlayBirdFly();
        }
    }
}
