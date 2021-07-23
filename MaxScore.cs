using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour //подсчет максимальных очков
{
    public Text TextMaxScore;

    void Start()
    {
        TextMaxScore = GetComponent<Text>();
        TextMaxScore.text = "BEST SCORE: " + PlayerPrefs.GetInt("Score").ToString();
    }

    void Update()
    {
        SuddenlyScore();
    }

    public void SuddenlyScore()
    {
        if (PlayerPrefs.GetInt("Score") < Score.GetScorePoint())
        {
            PlayerPrefs.SetInt("Score", Score.GetScorePoint());
            TextMaxScore.text = "NEW BEST SCORE: " + PlayerPrefs.GetInt("Score").ToString();
        }
    }
}
