using UnityEngine;
using UnityEngine.UI; // ← important pour Text UI

public class AfficheDetails : MonoBehaviour
{
    [Header("Références UI")]
    public GameObject modalPanel;
    public Text titreText;        // UI Text classique
    public Text descriptionText;  // UI Text classique

    [Header("Contenu")]
    public string titreSpectacle;
    [TextArea(3,10)] public string descriptionSpectacle;

    void OnMouseDown()
    {
        OuvrirPanel();
    }

    public void OuvrirPanel()
    {
        modalPanel.SetActive(true);
        titreText.text = titreSpectacle;
        descriptionText.text = descriptionSpectacle;
    }

// dans ton AfficheDetails.cs
public void FermerPanel()
{
    Debug.Log($"FermerPanel() called on {gameObject.name}. modalPanel={(modalPanel? modalPanel.name : "NULL")}");
    if (modalPanel)
        modalPanel.SetActive(false);
}


}
