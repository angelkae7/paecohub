using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDebug : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick on " + gameObject.name + " (button receives pointer)");
    }
}
