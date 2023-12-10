using System;
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
    private bool _gameMode = false;
    private Transform _playerTransform;
    static public int Money;
    static public int Ammo = 30;
    public Text MoneyText;
    public Text AmmoText;

    public void BuyAmmo()
    {
        Money--;
        Ammo++;
    }



    private void ShowParemetrs()
    {
        AmmoText.text = " " + Ammo;
    }



    public void Stop()
    {
        Speed = 0;
    }

    public void GoToPoint()
    {
        if (ActivePoint < ActiveRoomArray.Length && _gameMode == true)
        {
            Transform targetPoint = ActiveRoomArray[ActivePoint];
            transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, Speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                ActivePoint++;
            }
        }
    }

    private void Start()
    {
        _playerTransform = GetComponent<Transform>();
        _playerTransform.localScale = _playerTransform.localScale * 1;


    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _gameMode = true;
        }
        ShowParemetrs();
    }

    private void FixedUpdate()
    {
        GoToPoint();
    }


}
