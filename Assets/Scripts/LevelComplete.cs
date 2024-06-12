using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public PlayerCntrl PlayerReff;
    public ScoreCalculator ScoreReff;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(ScoreReff.CurrentBest > ScoreReff.ScoreAmount)
            {
                PlayerPrefs.SetFloat("currentBest", ScoreReff.ScoreAmount);
            }
            PlayerReff.GameOver = true;
            PlayerPrefs.SetString("currentScore", ScoreReff.ScoreText.text);
            SceneManager.LoadScene("EndScreen");
        }
    }
    
   
}
