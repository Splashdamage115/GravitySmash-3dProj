// changes the size of the asteroid when the game starts

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform body = GetComponent<Transform>();

        float scale = Random.value;
        body.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
