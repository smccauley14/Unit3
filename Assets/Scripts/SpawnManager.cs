using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnOpstacle), startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnOpstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
