using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    private LogicScript logic;
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate = 5;
    [SerializeField] private float timer = 0;
    [SerializeField] private float hightOffSet = 10;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // spawner of pipes
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else 
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffSet;
        float highestPoint = transform.position.y + hightOffSet;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
