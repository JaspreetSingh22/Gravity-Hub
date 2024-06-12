using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayLevel : MonoBehaviour
{
    public List<GameObject> Levels;
   

    void Start()
    {
       
        Instantiate(Levels[PlayerPrefs.GetInt("lastIndex")]);
    }

}
