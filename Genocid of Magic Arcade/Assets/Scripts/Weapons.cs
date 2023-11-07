using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _marker;
    [SerializeField] private Transform _weapon;
    public bool rot_to_angle;
    public int offset = 90;

    public void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rot_to_angle)
            {
                _weapon.rotation = Quaternion.Lerp(_weapon.rotation, _marker.rotation, _speed * Time.deltaTime);
            }
        }
    }
}
