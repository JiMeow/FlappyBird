using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    GameObject bird;
    void Start()
    {
        bird = GameObject.Find("Bird").gameObject;
    }

    void Update()
    {
        int nowScore = (int)bird.transform.position.x / 2;
        TMP_Text nowText = gameObject.GetComponent<TMP_Text>();

        if (nowText.text.ToString().Contains("High"))
        {
            gameObject.GetComponent<TMP_Text>().text = "High Score: " + PlayerPrefs.GetInt("Score");
        }
        else
        {
            int nowTextScore = int.Parse(nowText.text.ToString().Substring(7));
            if (nowScore > nowTextScore)
            {
                SoudManager.instance.PlayBirdScore();
                gameObject.GetComponent<TMP_Text>().text = "Score: " + nowScore;
            }
        }
        if (nowScore > PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", nowScore);
        }
    }
}
