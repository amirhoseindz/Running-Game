using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectablesControl.coinCount += 1;
        gameObject.SetActive(false);
    }
}
