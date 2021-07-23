using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurScore : MonoBehaviour //подсчет текущих очков
{
    public Text TextCurScore;

    void Start()
    {
        TextCurScore = GetComponent<Text>();
    }

    void Update()
    {
        TextCurScore.text = "SCORE: " + Score.GetScorePoint().ToString(); //возвращение набранных очков и записывание в компонент текста
    }
}
