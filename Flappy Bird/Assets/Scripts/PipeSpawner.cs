using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    const float pipeRange = 1.5f;
    float spawnTimer;
    const float spawnTime = 2; 

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0){
            spawnTimer = spawnTime;
            GameObject gameObject = Instantiate(pipePrefab, this.transform.position, pipePrefab.transform.rotation);
            gameObject.transform.position += new Vector3(0, Random.Range(-pipeRange, pipeRange), 0);
        }
    }
}
