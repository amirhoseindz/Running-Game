using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _rotationSpeed = 1f;
    void Update()
    {
        transform.Rotate(Time.deltaTime * _rotationSpeed *new Vector3(0,0 , 90));
    }
}
