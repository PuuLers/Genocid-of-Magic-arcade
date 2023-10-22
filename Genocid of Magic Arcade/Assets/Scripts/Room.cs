using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public Transform[] Points;

    public void SendingArray()
    {
        Player.ActiveRoomArray = Points;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.ActivePoint = 0;
            Player.ActiveRoomArray = Points;
        }
    }

 
}
