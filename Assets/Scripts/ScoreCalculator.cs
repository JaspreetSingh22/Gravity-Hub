using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    
    public PlayerCntrl PlayerReff;
    public Text ScoreText;
    public float ScoreAmount;
    public float PointsIncPerSec = 1f;
    public float CurrentBest = 0f;

   void Start()
    {
        ScoreAmount = 0;
        CurrentBest = PlayerPrefs.GetFloat("currentBest");

    }
    // Update is called once per frame
    void Update()
    {
        //Check if Game is over or Not
        if (!PlayerReff.GameOver)
        {
            //Calculating the score.
            ScoreText.text = (int)ScoreAmount + "";
            ScoreAmount += PointsIncPerSec * Time.deltaTime;
        }
    }
}
