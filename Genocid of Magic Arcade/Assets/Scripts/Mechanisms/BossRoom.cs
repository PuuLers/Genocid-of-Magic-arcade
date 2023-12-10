using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoom : MonoBehaviour
{
    public bool BossDie = false;
    public GameObject Boss;
    public Transform bossSpawnPoint;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void SpawnBoss()
    {
        GameObject boss = Instantiate(Boss, bossSpawnPoint);
        boss.transform.localPosition = bossSpawnPoint.position;
    }

}
