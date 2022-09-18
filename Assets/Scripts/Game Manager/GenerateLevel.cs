using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public float zPos = 20f;
    public GameObject player; 
    
    private int _sectionNum;

    private void Start()
    {
        StartCoroutine(GenerateSection());
    }
    IEnumerator GenerateSection()
    {
        while (player.GetComponent<PlayerMovement>().enabled)
        {
            _sectionNum = Random.Range(0, 3);
            Instantiate(section[_sectionNum], new Vector3(0, 0, zPos), Quaternion.identity);
            zPos += 20;
            yield return new WaitForSeconds(2);
        }
    }
    
}
