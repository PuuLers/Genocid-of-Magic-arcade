using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Speed;
    [Range(0.1f, 50f)]
    public int Spread = 10;
    public static int Damage;
    public LayerMask WhatIsSolid;
    public float distance;

    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    Destroy(gameObject);
        //    Destroy(collision.gameObject);
        //}
        //else if (collision.gameObject.CompareTag("Room"))
        //{
        //    Destroy(gameObject);
        //}
    }

  

    private void Start()
    {
        //transform.rotation *= Quaternion.Euler(0f, 0f, Random.Range(-Spread, Spread));
    }

}
