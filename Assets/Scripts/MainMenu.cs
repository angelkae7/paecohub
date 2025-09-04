using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void GotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        // Logic to load the specified scene
        Debug.Log($"Loading scene: {sceneName}");
    }
    
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
        
    }
    
}
