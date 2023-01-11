using UnityEngine;

public class FlipSprites : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    
    void Awake() => _spriteRenderer = GetComponent<SpriteRenderer>();

    void Flip()
    {
        if(Input.GetAxis("Horizontal") > 0) 
            _spriteRenderer.flipX = false;
        else if(Input.GetAxis("Horizontal") < 0) 
            _spriteRenderer.flipX = true;
    }

    void Update() => Flip();
}
