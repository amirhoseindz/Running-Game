using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject player;

    private void Start()
    {
        uiObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        uiObject.SetActive(true);
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
    }
}
