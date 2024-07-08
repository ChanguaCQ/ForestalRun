using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclesListPrefabs;
    [SerializeField] private List<GameObject> pooledItems = new List<GameObject>();
    public Transform pointToSpawn;
    private float startDelay = 2f;
    private float repeatRate = 2f;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    
    void SpawnObstacle()
    {
        GameObject obstacleObject = obstaclesListPrefabs [Random.Range (0,obstaclesListPrefabs.Length)];
        Instantiate(obstacleObject, pointToSpawn.position, obstacleObject.transform.rotation);
    }
}
