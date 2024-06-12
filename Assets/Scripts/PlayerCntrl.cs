using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    public ScoreCalculator ScalReff;
    public bool GameOver = false;
    public float GravityVal = 10f;
    

     void Start()
    {
        Physics2D.gravity = new Vector2(0, -GravityVal);
    }
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W) && !GameOver)
        {
            Physics2D.gravity = new Vector2(0, GravityVal);
        }
        else if (Input.GetKey(KeyCode.S) && !GameOver)
        {
            Physics2D.gravity = new Vector2(0, -GravityVal);
        }
        else if (Input.GetKey(KeyCode.A) && !GameOver)
        {
            Physics2D.gravity = new Vector2(-GravityVal, 0);
        }
        else if (Input.GetKey(KeyCode.D) && !GameOver)
        {
            Physics2D.gravity = new Vector2(GravityVal, 0);
        }
    }
}
