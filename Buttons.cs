using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static bool MusicAction = false;

    private void Start()
    {
        ButtonsGameover.BoolMusicAction();
    }

    public void ButtonsChoose()
    {
        switch (gameObject.name)
        {
            case "Play" :
                SceneManager.LoadScene("play");
                break;
            case "Quit":
                Application.Quit();
                break;
            case "VolumeOff":
                AudioManager.MusicEnd();
                MusicAction = false;
                break;
            case "VolumeOn":
                AudioManager.MusicBegin();
                MusicAction = true;
                break;
        }
    }
}
