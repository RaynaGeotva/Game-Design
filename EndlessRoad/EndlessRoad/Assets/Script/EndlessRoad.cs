using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRoad : MonoBehaviour
{
    public Transform startPosition;
    int nextStep = 0;
    public GameObject[] PrefabsEndlessRoad;

    // Update is called once per frame
    void Update()
    {
        nextStep += 7;
        Instantiate(PrefabsEndlessRoad[Random.Range(0, PrefabsEndlessRoad.Length)], new Vector3(startPosition.position.x,
           startPosition.position.y, transform.position.z + nextStep), Quaternion.identity);
    }
}
