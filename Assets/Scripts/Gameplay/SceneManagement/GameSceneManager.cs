using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    //Make this into a singleton
    public static GameSceneManager _instance;

    public GameSceneManager Instance 
    { 
        get{return _instance;}

        private set{ _instance = value; }
    }

    void Awake() 
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;

        DontDestroyOnLoad(this);
    }

    public void ToFirstLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit() 
    {
        Application.Quit();
    }

    public void ToCredits()
    {
        SceneManager.LoadScene(1);
    }
}
