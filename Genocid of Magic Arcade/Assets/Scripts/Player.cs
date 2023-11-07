using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    static public Transform[] ActiveRoomArray;
    public float Speed;
    static public int ActivePoint;
    //public int bullets;
    //public int money;
    //public TextMeshPro bulletsText;
    //public TextMesh moneyText;
    //public bool GameMode = false;
    //public Animator CamAnim;
    //public GameObject Marker;

    private void GoToPoint()
    {
        if (ActivePoint < ActiveRoomArray.Length)
        {
            Transform targetPoint = ActiveRoomArray[ActivePoint];
            transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, Speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                ActivePoint++;
            }
        }
    }


    private void Update()
    {
        GoToPoint();
    }


}
