using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Marker : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationBoost;
    [SerializeField] private float _rotationSpeedMax;
    


    private void Update()
    {
        Rotate(_rotationSpeed);
        RotateMarker();
        Boost();
        
    }
    private void Boost()
    {
        if (_rotationSpeed < 0 && _rotationSpeed > -_rotationSpeedMax)
        {
            _rotationSpeed += -_rotationBoost;
        }
        else if (_rotationSpeed > 0 && _rotationSpeed < _rotationSpeedMax)
        {
            _rotationSpeed += _rotationBoost;
        }
    }
    private void Rotate(float speed)
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
            if (_rotationSpeed < 0)
            {
                _rotationSpeed = -1;
            }
            else if (_rotationSpeed > 0)
            {
                _rotationSpeed = 1;
            }
            _rotationSpeed *= -1;           
        }
    }

}
