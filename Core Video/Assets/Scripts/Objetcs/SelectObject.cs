using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectObject : MonoBehaviour, IPointerDownHandler
{
    public bool select;
    public GameObject minameObject;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(minameObject.name);
        IdScrollbar.idName = minameObject.name;    //Asignamos el nombre del objeto
        IdHandle.idName = minameObject.name;       //Ocultamos Panel Handle
    }

    void Update()
    {
        if (IdScrollbar.idName == minameObject.name)
        {
            select = true;
        }
        else
        {
            select = false;
        }

    }
}
