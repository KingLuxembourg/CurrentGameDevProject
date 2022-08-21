using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    [SerializeField] private GameObject _highlight;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //for (int i = 0; i < hit.transform.childCount; i++)
        //{
        //_highlight.name = $"Highlight {i}";
        hit.transform.GetChild(0).gameObject.SetActive(true);
        //}

    }
}
