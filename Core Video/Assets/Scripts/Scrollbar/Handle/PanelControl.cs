using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelControl : MonoBehaviour
{
    //Conecting two scrollbar
    public Scrollbar scrollbarObject;
    public Scrollbar scrollbarPanel;

    private void Update()
    {
        Size();
    }

    private void Size()
    {
        if (scrollbarPanel.value > 0.01f)
        {
            scrollbarObject.size = scrollbarPanel.value;
        }
        if (scrollbarPanel.value <= 0.01f)
        {
            scrollbarObject.size = 0.01f;
        }
    }
}
