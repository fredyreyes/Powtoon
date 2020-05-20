using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchHandle : MonoBehaviour, IPointerDownHandler
{
    public ToggleButton scrollbarTime;
    

    public void OnPointerDown(PointerEventData eventData)
    {
        if (PlayButton.state)
        {
            //scrollbarTime.ToogleButton();
            scrollbarTime.Increment();
        }
    }

   
}
