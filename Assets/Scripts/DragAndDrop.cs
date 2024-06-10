using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface ICustomDrag
{
    void OnCurrentDrag();
}
public class DragAndDrop : MonoBehaviour, ICustomDrag, IDragHandler
{
    private RectTransform rectTransform;
    private ICustomDrag onDrag;

    void Start()
    {
        onDrag = gameObject.GetComponent<ICustomDrag>();
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        onDrag.OnCurrentDrag();
    }

    public void OnCurrentDrag()
    {
        rectTransform.position = Input.mousePosition;
    }
}
