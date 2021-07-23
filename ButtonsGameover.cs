using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class ButtonsGameover : MonoBehaviour
{
    public GameObject pPause;
    public GameObject controllers;
    public GameObject pCont;
    public GameObject pLost;

    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4136407", false);
        }

        if (AudioManager.fixValue == 0)
        {
            BoolMusicAction();
            AudioManager.fixValue++;
        }
    }

    public void ButtonsLosed()
    {
        switch (gameObject.name)
        {
            case "Retry":
                SceneManager.LoadScene("play");
                Time.timeScale = 1;
                Score.scorePoint = 0;
                AudioManager.fixValue = 0;
                break;
            case "Main menu":
                SceneManager.LoadScene("main");
                Time.timeScale = 1;
                Score.scorePoint = 0;
                AudioManager.fixValue = 0;
                break;
            case "Continue":
                pPause.SetActive(false);
                pCont.SetActive(false);
                controllers.SetActive(true);
                Time.timeScale = 1;
                BoolContMusicAction();
                break;
            case "Pause":
                pPause.SetActive(true);
                controllers.SetActive(false);
                Time.timeScale = 0;
                BoolPauseMusicAction();
                break;
            case "ContinueWithAd":
                pCont.SetActive(true);
                pLost.SetActive(false);
                BoolPauseMusicAction();
                if (Advertisement.IsReady()) //условие рекламы
                {
                    Advertisement.Show("Rewarded_Android");
                }
                break;
            case "ContinueAfterAd":
                SceneManager.LoadScene("play");
                pCont.SetActive(false);
                Time.timeScale = 1;
                BoolContMusicAction();
                AudioManager.fixValue = 0;
                break;

        }
    }

    public static void BoolMusicAction()
    {
        if (Buttons.MusicAction)
        {
            AudioManager.MusicBegin();
        }
    }

    public static void BoolContMusicAction()
    {
        if (Buttons.MusicAction)
        {
            AudioManager.MusicUnPause();
        }
    }

    public static void BoolPauseMusicAction()
    {
        if (Buttons.MusicAction)
        {
            AudioManager.MusicPause();
        }
    }

}
