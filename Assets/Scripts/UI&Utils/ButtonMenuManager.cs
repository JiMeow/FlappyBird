using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenuManager : MonoBehaviour
{
    public void GoNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credit()
    {
        Application.OpenURL("https://github.com/JiMeow/FlappyBird");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadSettingScene()
    {
        SceneManager.LoadScene("Setting");
    }

    public void SettingSound()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 objectPosition = new Vector3(0.5f, 0f, 0f);

        float distanceX = (float)(worldPosition.x - objectPosition.x);
        int index = (int)(Mathf.RoundToInt(distanceX / 0.2f));
        GameObject soundPhoto = GameObject.Find("SoundPhoto");
        Transform[] allChildren = soundPhoto.GetComponentsInChildren<Transform>();
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
        index = Mathf.Min(index + 1, 10);
        float soundMul = (float)(index) / 5f;
        SoudManager.instance.SetBirdSound(soundMul);
    }
}
