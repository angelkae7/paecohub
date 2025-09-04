using UnityEngine;
using UnityEngine.UIElements;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuController : MonoBehaviour
{
    private Button jouerButton;
    private Button optionsButton;
    private Button quitterButton;

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        jouerButton = root.Q<Button>("Playbutton");
        optionsButton = root.Q<Button>("Optionsbutton");
        quitterButton = root.Q<Button>("Quitterbutton");

        // Sécurise les clics
        jouerButton.clicked -= OnJouerClicked;
        optionsButton.clicked -= OnOptionsClicked;
        quitterButton.clicked -= OnQuitterClicked;

        jouerButton.clicked += OnJouerClicked;
        optionsButton.clicked += OnOptionsClicked;
        quitterButton.clicked += OnQuitterClicked;
    }

    private void OnJouerClicked()
    {
        Debug.Log("==> CLIC JOUER !");
        gameObject.SetActive(false); // ou charge une scène si tu veux
    }

    private void OnOptionsClicked()
    {
        Debug.Log("==> CLIC OPTIONS !");
        // Ajoute ta logique ici
    }

    private void OnQuitterClicked()
    {
        Debug.LogWarning("==> CLIC QUITTER !");
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
