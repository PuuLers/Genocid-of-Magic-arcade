using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public int Speed;
    [Range(0.1f, 50f)]
    public int Spread = 10;
    public static int Damage;

    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
           
            Destroy(gameObject);
        }

    }



    private void Start()
    {
        //transform.rotation *= Quaternion.Euler(0f, 0f, Random.Range(-Spread, Spread));
    }

}
