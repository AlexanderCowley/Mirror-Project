using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeSpriteEffect : MonoBehaviour, IInteractEffect
{
    SpriteRenderer _spriteRenderer;
    [SerializeField] Sprite _spriteToChange;
    void Awake() 
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void InteractEvent()
    {
        ChangeSprite();
    }

    void ChangeSprite()
    {
        _spriteRenderer.sprite = _spriteToChange;
    }
}
