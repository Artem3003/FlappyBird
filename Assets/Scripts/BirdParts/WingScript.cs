using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingScript : MonoBehaviour
{
    public BirdScript bird;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && bird.birdIsAlive)
        { 
            animator.SetTrigger("Wing");
        }
    }
}
