using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnpoint : MonoBehaviour
{
    public GameObject[] Enemy;
    public Transform Zero;

    private void SpawnEnemy()
    {
        int rand = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[rand], Zero);
    }

    private void Start()
    {
        SpawnEnemy();
    }
}
