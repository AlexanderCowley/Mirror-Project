using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitLevelPortal : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        NextScene();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 % SceneManager.sceneCount);
    }
}
