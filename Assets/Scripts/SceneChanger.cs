using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName; // <- à remplir dans l’inspector

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
