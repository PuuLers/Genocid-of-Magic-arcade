using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Weapons : Player
{
    //[SerializeField] private float _speed;
    private Transform _weapon;
    public bool rot_to_angle;
    private Transform _marker;
    static public float _rotZ;

    private void Update()
    {
        Rotate();
    }

    private void Start()
    {
        _weapon = GetComponent<Transform>();
        _marker = GameObject.FindWithTag("Marker").GetComponent<Transform>();
        
    }


    public void Rotate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rot_to_angle)
            {
                _weapon.rotation = _marker.rotation;
                _rotZ = transform.rotation.eulerAngles.z;
                Vector3 LocalScale = Vector3.one;
                if (_rotZ < 90 || _rotZ > 270)
                {
                    LocalScale.y = LocalScale.y * 1f;
                }
                else
                {
                    LocalScale.y = LocalScale.y * -1f;
                }
                transform.localScale = LocalScale;
            }
        }
    }
}
