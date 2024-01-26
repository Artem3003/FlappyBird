using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleToFitScreenScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // world height is always camera's orthographicSize * 2
        float worldScreenHeight = Camera.main.orthographicSize * 2;
        // world width is calculated by diving world height with screen heigh
        // then multiplying it with screen width
        float worldScreenWidth = worldScreenHeight / Screen.width * Screen.height;

        // to scale the game object we divide the world screen width with the
        // size x of the sprite, and we divide the world screen height with the
        // size y of the sprite
        transform.localScale = new Vector3(worldScreenHeight / spriteRenderer.bounds.size.x, worldScreenWidth / spriteRenderer.bounds.size.y, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
