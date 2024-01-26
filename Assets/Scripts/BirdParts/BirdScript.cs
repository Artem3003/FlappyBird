using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // body of bird
    [SerializeField] private float flapStrength; // height of takeoff
    public LogicScript logic;
    public AudioSource hitSound;
    [SerializeField] private GameObject damageFlashBird;
    [SerializeField] private GameObject damageFlashWing1;
    [SerializeField] private GameObject damageFlashWing2;
    [SerializeField] private GameObject deadBird;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        hitSound.Play();
        logic.GameOver();   
        birdIsAlive = false; 
        Invoke(nameof(EnableDamageFlash), 0f);
        Invoke(nameof(DisableDamageFlash), 0.1f);
        EnableDeadBird();
    }

    private void EnableDamageFlash()
    {
        damageFlashBird.SetActive(true);
        damageFlashWing1.SetActive(true);
        damageFlashWing2.SetActive(true);
    }

    private void DisableDamageFlash()
    {
        damageFlashBird.SetActive(false);
        damageFlashWing1.SetActive(false);
        damageFlashWing2.SetActive(false);
    }

    private void EnableDeadBird()
    {
        deadBird.SetActive(true);
    }
}
