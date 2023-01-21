using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeSpriteEffect : MonoBehaviour, IInteractEffect
{
    SpriteRenderer _spriteRenderer;
    [SerializeField] Sprite _spriteToChange;
    Sprite _originalSprite;
    void Awake() 
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _originalSprite = _spriteRenderer.sprite;
    }

    public void InteractEvent()
    {
        ChangeSprite();
    }

    void ChangeSprite()
    {
        if(_spriteRenderer.sprite == _originalSprite)
            _spriteRenderer.sprite = _spriteToChange;
        else
        {
            _spriteRenderer.sprite = _originalSprite;
        }
            
    }
}
