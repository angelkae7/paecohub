using UnityEngine;
using System.Collections;

public class IntroTriggerWithAnimation : MonoBehaviour
{
    public GameObject[] objectsToReveal;
    public float heightOffset = 1f;
    public float scaleStart = 0.3f;
    public float duration = 1f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject obj in objectsToReveal)
            {
                StartCoroutine(RevealObject(obj));
            }

            Destroy(gameObject); // pour que ça ne se relance pas
        }
    }

    IEnumerator RevealObject(GameObject obj)
    {
        obj.SetActive(true);

        Vector3 startPos = obj.transform.position - new Vector3(0, heightOffset, 0);
        Vector3 endPos = obj.transform.position;

        Vector3 startScale = obj.transform.localScale * scaleStart;
        Vector3 endScale = obj.transform.localScale;

        obj.transform.position = startPos;
        obj.transform.localScale = startScale;

        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / duration);

            obj.transform.position = Vector3.Lerp(startPos, endPos, t);
            obj.transform.localScale = Vector3.Lerp(startScale, endScale, t);

            yield return null;
        }
    }
}
