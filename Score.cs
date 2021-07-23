using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int scorePoint;

    public static int GetScorePoint()
    {
        return scorePoint;
    }

    public static void SetScorePoint()
    {
        scorePoint++;
    }
}
