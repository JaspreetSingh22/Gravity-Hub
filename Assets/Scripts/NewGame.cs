using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void NewLevel(string level)
    {
        PlayerPrefs.SetFloat("currentBest", 9999);
        SceneManager.LoadScene(level);

        
       
    }

}
