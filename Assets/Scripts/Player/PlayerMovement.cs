using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveSpeed = 1.5f;
    private float _movingAsideSpeed = 2f;
    
    void Update()
    {
        transform.Translate(  Time.deltaTime * _moveSpeed * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > RoadBoundaries.leftSide)
            {
                transform.Translate(  Time.deltaTime * _movingAsideSpeed * Vector3.left);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x < RoadBoundaries.rightSide)
            {
                transform.Translate(  Time.deltaTime * _movingAsideSpeed * -Vector3.left);
            }
        }
    }
}
