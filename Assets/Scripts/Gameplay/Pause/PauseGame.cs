using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool IsPaused = false;
    CanvasToggle _pauseCanvas;
    void Awake() 
    {
        _pauseCanvas = GetComponent<CanvasToggle>();
        DontDestroyOnLoad(this);
    }

    void TogglePause()
    {
        IsPaused = !IsPaused;
        Time.timeScale = IsPaused ? 0 : 1;
        _pauseCanvas.ToggleCanvas();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
}
