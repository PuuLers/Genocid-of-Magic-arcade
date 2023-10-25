using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Marker : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int rotationBoost;
    [SerializeField] private int rotationSpeedMax;
    
    private void Update()
    {
        Rotate(rotationSpeed);
        RotateMarker();
        Boost();
        //SpeedLimit();
    }
    private void SpeedLimit()
    {
        if (rotationSpeed > rotationSpeedMax)
        {
            rotationSpeed = rotationSpeedMax;
        }
    }
    private void Boost()
    {
        if (rotationSpeed < 0 && rotationSpeed > -rotationSpeedMax)
        {
            rotationSpeed += -rotationBoost;
        }
        else if (rotationSpeed > 0 && rotationSpeed < rotationSpeedMax)
        {
            rotationSpeed += rotationBoost;
        }
    }
    private void Rotate(int speed)
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(currentRotation);
        Debug.Log(speed);
    }
    private void RotateMarker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rotationSpeed < 0)
            {
                rotationSpeed = -1;
            }
            else if (rotationSpeed > 0)
            {
                rotationSpeed = 1;
            }
            rotationSpeed *= -1;
            
        }
    }
}
