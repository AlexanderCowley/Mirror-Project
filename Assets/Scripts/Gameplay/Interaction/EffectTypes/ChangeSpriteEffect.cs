using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeSpriteEffect : InteractEffect
{
    SpriteRenderer _spriteRenderer;
    [SerializeField] Sprite _spriteToChange;
    void Awake() 
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void InteractEvent()
    {
        ChangeSprite();
    }

    void ChangeSprite()
    {
        _spriteRenderer.sprite = _spriteToChange;
    }
}
