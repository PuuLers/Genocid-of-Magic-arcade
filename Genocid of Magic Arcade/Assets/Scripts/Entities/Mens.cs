using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flip();
    }

    private void flip()
    {
        float GunAngle = Weapons._rotZ;
        Vector3 LocalScale = Vector3.one;
        if (GunAngle < 90 || GunAngle > 270)
        {
            LocalScale.x = LocalScale.x * 1f;
        }
        else
        {
            LocalScale.x = LocalScale.x * -1f;
        }
        transform.localScale = LocalScale;
    }




}
