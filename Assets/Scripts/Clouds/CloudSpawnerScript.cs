using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject cloud;
    [SerializeField] private float hightOffSet = 15;
    [SerializeField] private float timer = 0;
    [SerializeField] private float spawnRate = 3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else 
        {
            SpawnCloud();
            timer = 0;
        }
    }

    private void SpawnCloud()
    {
        float lowestPoint = transform.position.y - hightOffSet;
        float highestPoint = transform.position.y + hightOffSet;
        cloud.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(-1, 2); // choose layer of cloud
        cloud.GetComponent<SpriteRenderer>().flipX = Random.value > 0.5f; // change horizontal orientation (random true or false)
        cloud.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(Random.Range(1f, 1.3f), Random.Range(1f, 1.3f), 0);
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
