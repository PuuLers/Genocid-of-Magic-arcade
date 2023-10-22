using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    private Transform Player;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FollowingPlayer()
    {
        Vector3 temp = transform.position;
        temp.y = Player.position.y + 2;
        transform.position = temp;
    }


    void Update()
    {
        FollowingPlayer();
    }
}
