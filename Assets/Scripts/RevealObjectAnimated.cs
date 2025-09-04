using UnityEngine;

public class RevealObjectAnimated : MonoBehaviour
{
    public float duration = 1f;
    public float heightOffset = 1f;
    public float scaleStart = 0.5f;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 startScale;
    private Vector3 endScale;
    private float timer;
    private bool animating = false;

    void Awake()
    {
        endPos = transform.position;
        startPos = endPos - new Vector3(0, heightOffset, 0);

        endScale = transform.localScale;
        startScale = endScale * scaleStart;

        transform.position = startPos;
        transform.localScale = startScale;
    }

    void OnEnable()
    {
        timer = 0f;
        animating = true;
    }

    void Update()
    {
        if (!animating) return;

        timer += Time.deltaTime;
        float t = Mathf.Clamp01(timer / duration);

        transform.position = Vector3.Lerp(startPos, endPos, t);
        transform.localScale = Vector3.Lerp(startScale, endScale, t);

        if (t >= 1f)
        {
            animating = false;
        }
    }
}
