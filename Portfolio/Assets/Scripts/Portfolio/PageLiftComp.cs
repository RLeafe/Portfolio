using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PageLiftComp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject pageCorner;

    public Vector3 defaultRotation = new Vector3(-79f, 0.0f, 0.0f);
    public Vector3 newRotation = new Vector3(-60f, -7f, -16f);

    public void OnPointerEnter(PointerEventData eventData)
    {
        pageCorner.transform.eulerAngles = newRotation;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pageCorner.transform.eulerAngles = defaultRotation;
    }

    public void OnPageClick()
    {
        pageCorner.transform.eulerAngles = defaultRotation;
    }
}
