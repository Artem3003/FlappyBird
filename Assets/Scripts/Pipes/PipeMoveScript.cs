using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    private float deadZone = -40;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); // destroy pipes and clouds
        }
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;    }
}
