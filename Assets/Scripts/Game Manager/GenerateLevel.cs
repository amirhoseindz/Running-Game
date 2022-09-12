using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public float zPos = 20f;
    public bool creatingSection = false;

    private int _sectionNum;
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        _sectionNum = Random.Range(0, 3);
        Instantiate(section[_sectionNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 20;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
