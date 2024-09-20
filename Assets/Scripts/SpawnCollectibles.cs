using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectibles : MonoBehaviour
{
    public GameObject collectibelePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(collectibelePrefab, new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(-10f, 10f)), Quaternion.Euler(0f, 0f, 0f));
        Instantiate(collectibelePrefab, new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(-10f, 10f)), Quaternion.Euler(0f, 0f, 0f));
        Instantiate(collectibelePrefab, new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(-10f, 10f)), Quaternion.Euler(0f, 0f, 0f));
    }
}
