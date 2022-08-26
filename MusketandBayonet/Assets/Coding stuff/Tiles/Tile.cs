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
        _highlight.SetActive(true);
        Debug.Log("work");
    }
    private void OnMouseExit()
    {
        Debug.Log("yes");
        _highlight.SetActive(false);
    }
}
