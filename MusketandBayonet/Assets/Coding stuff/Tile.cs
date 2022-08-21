using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //[SerializeField] private Color _BaseColor, _Offsetcolor;
    //[SerializeField] private Material _materialBase, _materialOffset;
    [SerializeField] private GameObject _highlight;
    Ray ray;
    RaycastHit hit;
    bool willhighlight;
    public void yeshighlight(bool isOffset = false)
    {
        willhighlight = isOffset;
        _highlight.SetActive(false);

    }
    public void nohighlight(bool isOffset = true)
    {
        willhighlight = isOffset;
        _highlight.SetActive(true);

    }

    private void Start()
    {
        
    }

}
