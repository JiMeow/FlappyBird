using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdDead : MonoBehaviour
{
    BirdMove bMove, cameraMove;
    BirdControll bControll;
    Rigidbody2D bRb;

    bool isDead = false;

    private void Start()
    {
        cameraMove = GameObject.Find("Main Camera").GetComponent<BirdMove>(); ;
        bMove = gameObject.GetComponent<BirdMove>();
        bControll = gameObject.GetComponent<BirdControll>();
        bRb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isDead)
        {
            Dead();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead)
        {
            Dead();
        }
    }

    private void Dead()
    {
        isDead = true;
        cameraMove.speed = 0f;
        bMove.speed = 0f;
        bControll.force = 0f;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        Invoke("DeadAnimation", 5f);
    }

    private void DeadAnimation()
    {
        GameObject sprite = gameObject.transform.GetChild(0).gameObject;
        sprite.GetComponent<Animator>().SetBool("Dead", true);
        bRb.gravityScale = 0f;
        bRb.velocity = new Vector2(0, 0.3f);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        Invoke("Restart", 8f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
