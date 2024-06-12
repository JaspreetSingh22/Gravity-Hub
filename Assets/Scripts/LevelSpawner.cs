using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public List<GameObject> Levels;
    public int LastIndex;

     void Start()
    {
        LastIndex = Random.Range(0, Levels.Count);
        PlayerPrefs.SetInt("lastIndex", LastIndex);
        Instantiate(Levels[LastIndex]);
    }

}
