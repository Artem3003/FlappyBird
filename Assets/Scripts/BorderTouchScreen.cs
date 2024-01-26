using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BorderTouchScreen : MonoBehaviour
{
    public BirdScript birdScript;
    public LogicScript logic;
    public AudioSource dieSound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.layer == 3)
        {
            dieSound.Play();
            logic.GameOver();
            birdScript.birdIsAlive = false;
        }    
    }
}
