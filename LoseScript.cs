using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    public GameObject pLost;
    public GameObject controllers;

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "ringComponent") //проигрыш
        {
            Debug.Log(collision.gameObject.name);
            pLost.SetActive(true);
            controllers.SetActive(false);
            Time.timeScale = 0;
            AudioManager.MusicPause();
        }

    }

}
