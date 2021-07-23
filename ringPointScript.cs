using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringPointScript : MonoBehaviour //класс отвечающий за добавление очков
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Score.SetScorePoint();
        }
    }
}
