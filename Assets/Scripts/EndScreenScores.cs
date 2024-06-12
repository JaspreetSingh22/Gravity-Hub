using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScores : MonoBehaviour
{
    public Text CurrentScoreText;
    public Text HighScoreText;
    void Start()
    {
        CurrentScoreText.text =  PlayerPrefs.GetString("currentScore");
        HighScoreText.text = "" + (int)(PlayerPrefs.GetFloat("currentBest"));
    }
}
