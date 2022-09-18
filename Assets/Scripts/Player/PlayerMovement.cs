using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveSpeed = 2f;
    private float _maxMoveSpeed = 8f;
    private float _movingAsideSpeed = 2f;
    private float _maxMovingAsideSpeed = 2f;
    private Vector3 _tempPos;
    private Camera _cam;
    private RaycastHit _hit;
    private Ray _ray;

    private void Start()
    {
        _cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if (_moveSpeed < _maxMoveSpeed)
        {
            _moveSpeed += 0.1f * Time.deltaTime;
            if (_movingAsideSpeed < _maxMovingAsideSpeed)
            {
                _movingAsideSpeed += 0.05f;
            }
        }
        transform.Translate (Time.deltaTime * _moveSpeed * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > RoadBoundaries.leftSide)
            {
                transform.Translate (Time.deltaTime * _movingAsideSpeed * Vector3.left);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x < RoadBoundaries.rightSide)
            {
                transform.Translate (Time.deltaTime * _movingAsideSpeed * -Vector3.left);
            }
        }
        if (gameObject.transform.position.x < RoadBoundaries.rightSide
            && gameObject.transform.position.x > RoadBoundaries.leftSide)
        {
            _ray = _cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit))
            {
                _tempPos = _hit.point;
                _tempPos.y = 0.3f;
                _tempPos.z = transform.position.z;
                transform.position = Vector3.MoveTowards(transform.position, _tempPos, Time.deltaTime);
            }
        }
    }
}
