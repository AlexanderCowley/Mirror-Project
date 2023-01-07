using UnityEngine;
public class CanvasToggle : MonoBehaviour
{
    CanvasGroup _canvasGroup;
    bool _IsActive = false;
    [SerializeField] bool IsHidden = true;
    void Awake() 
    {
        _canvasGroup = transform.GetChild(0).GetComponent<CanvasGroup>();

        if(!IsHidden)
            ToggleCanvas();
    }

    public void ToggleCanvas() 
    {
        _IsActive = !_IsActive;
        _canvasGroup.alpha = _IsActive ? 1 : 0;
    }
}