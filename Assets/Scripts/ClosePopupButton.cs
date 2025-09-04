using UnityEngine;

public class ClosePopupButton : MonoBehaviour
{
    [SerializeField] private GameObject panel; // ton pop-up

    public void Close()
    {
        if (panel != null)
        {
            panel.SetActive(false);
            Debug.Log("Panel fermé: " + panel.name);
        }
        else
        {
            Debug.LogWarning("⚠ Aucun panel assigné dans FermerPanelDirect !");
        }
    }
}
