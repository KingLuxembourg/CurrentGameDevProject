using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject _highlight;

    //bool willhighlight;
    // public void yeshighlight(bool isOffset = false)
    // {
    // willhighlight = isOffset;
    //_highlight.SetActive(false);

    //}
    private void OnMouseEnter()
    {
        Debug.Log("work");
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{


    //}

    //public void OnPointerExit(PointerEventData eventData)
    //{

    //}
}
