﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageSetNone : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("001");
    }

    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.01f;
    }


}
