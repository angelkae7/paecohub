using UnityEngine;

public class IntroTrigger : MonoBehaviour
{
    public GameObject[] objectsToReveal;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player est entré dans la zone");

            foreach (GameObject obj in objectsToReveal)
            {
                obj.SetActive(true); // Active l'objet (et donc déclenche RevealObject si présent)
            }

            Destroy(gameObject); // On ne veut l'activer qu'une fois
        }
    }
}
