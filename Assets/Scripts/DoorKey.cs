using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    public KeyDoor KeyDoorReff;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //To check collision of player with keys
        if (collision.CompareTag("Player"))
        {
            //to increase the key count in Keydoor script
            KeyDoorReff.keyCollect();
            Destroy(gameObject);
        }
    }
}
